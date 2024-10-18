namespace SQLMusicApp
{
    public partial class Main : Form
    {

        BindingSource albumBinding = new BindingSource();
        BindingSource trackBinding = new BindingSource();
        AlbumsDAO albumsDAO;
        AddAlbum addAlbum;
        AddTrack addTrack;

        DataGridViewRow selectedRow;
        DataGridViewRow selectedTrack;


        public Main()
        {
            InitializeComponent();
            albumsDAO = new AlbumsDAO();
            addAlbum = new AddAlbum(albumsDAO, this);
            addTrack = new AddTrack(albumsDAO, this);

            // Load albums into the DGV
            albumBinding.DataSource = albumsDAO.LoadAlbums();
            dgvAlbums.DataSource = albumBinding;
            // Load Tracks into the DGV
            trackBinding.DataSource = albumsDAO.LoadTracks(0);
            dgvTracks.DataSource = trackBinding;

            // Set the selected row to the first row
            selectedRow = dgvAlbums.Rows[0];
            selectedTrack = dgvTracks.Rows[0];
            LoadAlbumInfo();
        }

        /// <summary>
        /// Refreshes data in the DGV 
        /// Pulls LATEST data from the database
        /// </summary>
        public void RefreshDGV()
        {
            albumBinding.DataSource = albumsDAO.LoadAlbums();
            albumBinding.ResetBindings(false);
            dgvAlbums.DataSource = albumBinding;
            selectedRow = dgvAlbums.Rows[1];
            LoadAlbumInfo();

            trackBinding.DataSource = albumsDAO.LoadTracks(Convert.ToInt32(selectedRow.Cells[0].Value));
            trackBinding.ResetBindings(false);
            dgvTracks.DataSource = trackBinding;
        }

        /// <summary>
        /// Adds an album to the database
        /// Refreshes the DGV
        /// </summary>
        /// <param name="album"></param>
        public void AddAlbum(Album album)
        {
            albumsDAO.AddAlbum(album);
            RefreshDGV();
        }

        public void AddTrack(Track track)
        {
            albumsDAO.AddTrack(track);
            RefreshDGV();
        }

        /// <summary>
        /// Loads album info into the form
        /// </summary>
        /// <param name="selectedRow"></param>
        private void LoadAlbumInfo()
        {
            if (selectedRow.Cells[1].Value == null)
            {
                return;
            }
            String? imgUrl = selectedRow.Cells[4].Value.ToString();
            pbCover.ImageLocation = imgUrl;
            String? description = selectedRow.Cells[5].Value.ToString();
            lblDesc.Text = description;
            String? title = selectedRow.Cells[1].Value.ToString();
            lblTitle.Text = title;
            String? artist = selectedRow.Cells[2].Value.ToString();
            lblArtist.Text = artist;
            LoadTracks();
        }

        private void LoadTracks()
        {
            trackBinding.DataSource = albumsDAO.LoadTracks(Convert.ToInt32(selectedRow.Cells[0].Value));
            dgvTracks.DataSource = trackBinding;
        }


        // ------------------------------
        // Event Handlers
        // ------------------------------


        private void LoadAlbums_OnClick(object sender, EventArgs e)
        {
            RefreshDGV();
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                albumBinding.DataSource = albumsDAO.GetAlbums();
                dgvAlbums.Invalidate(); // Force a visual refresh
                dgvAlbums.Update();
            }
            else
            {
                List<Album> albums = albumsDAO.GetAlbums();
                List<Album> filtered = albums.Where(x => x.Title.ToLower().Contains(tbSearch.Text.ToLower()) || x.ArtistName.ToLower().Contains(tbSearch.Text.ToLower())).ToList();
                albumBinding.DataSource = filtered;
                selectedRow = dgvAlbums.Rows[0];
                LoadAlbumInfo();
                dgvAlbums.Invalidate(); // Force a visual refresh
                dgvAlbums.Update();
            }
        }

        /// <summary>
        /// Triggered when the user clicks a cell in the Albums DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGValbum_OnClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvAlbums.Rows.Count - 1)
            {
                return;
            }



            selectedRow = dgvAlbums.Rows[e.RowIndex];
            btnDelAlbum.Text = "Remove Album " + selectedRow.Cells[0].Value.ToString();
            LoadAlbumInfo();

        }

        /// <summary>
        /// Triggered when the user clicks the Add Album button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAlbum_OnClick(object sender, EventArgs e)
        {

            addAlbum.ShowDialog();

        }

        /// <summary>
        /// Triggered when the user clicks the Delete Album button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelAlbum_OnClick(object sender, EventArgs e)
        {
            if (selectedRow.Cells[1].Value == null)
            {
                return;
            }


            int id = Convert.ToInt32(selectedRow.Cells[0].Value);
            String? title = selectedRow.Cells[1].Value.ToString();
            lblTitle.Text = title;

            DialogResult result = MessageBox.Show("Are you sure you want to delete " + title + "?", "Delete Album", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                albumsDAO.RemoveAlbum(id);
                RefreshDGV();
            }
        }

        /// <summary>
        /// Used to handle placeholder image if the image URL is invalid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbCover_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null || pbCover.ImageLocation == "")
            {
                pbCover.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            }
        }

        /// <summary>
        /// Triggered when the user clicks a cell in the Tracks DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGVTracks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvTracks.Rows.Count - 1)
            {
                return;
            }
            selectedTrack = dgvTracks.Rows[e.RowIndex];

            btnDelTrack.Text = "Remove Track " + selectedTrack.Cells[0].Value.ToString();

            String videoURL = selectedTrack.Cells[3].Value.ToString();
            webView.Source = new Uri(videoURL);

        }

        /// <summary>
        /// Triggered when the user clicks the Delete Track button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelTrack_Click(object sender, EventArgs e)
        {
            if (selectedTrack.Cells[1].Value == null)
            {
                return;
            }

            int id = Convert.ToInt32(selectedTrack.Cells[0].Value);
            String? title = selectedTrack.Cells[1].Value.ToString();
            lblTitle.Text = title;

            DialogResult result = MessageBox.Show("Are you sure you want to delete " + title + "?", "Delete Track", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                albumsDAO.RemoveTrack(id);
                RefreshDGV();
            }

        }

        /// <summary>
        /// Triggered when the user clicks the Add Track button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            addTrack.ShowDialog();

            if (selectedRow.Cells[0].Value == null)
            {
                return;
            }
            addTrack.SetAlbumID(Convert.ToInt32(selectedRow.Cells[0].Value));
        }
    }

}
