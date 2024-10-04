namespace SQLMusicApp
{
    public partial class Main : Form
    {

        BindingSource albumBinding = new BindingSource();
        AlbumsDAO albumsDAO;
        AddAlbum addAlbum;

        DataGridViewRow selectedRow;

        public Main()
        {
            InitializeComponent();
            albumsDAO = new AlbumsDAO();
            addAlbum = new AddAlbum(albumsDAO, this);
            // Load albums into the DGV
            albumBinding.DataSource = albumsDAO.LoadAlbums();
            DGValbum.DataSource = albumBinding;
            // Set the selected row to the first row
            selectedRow = DGValbum.Rows[0];
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
            DGValbum.DataSource = albumBinding;
            selectedRow = DGValbum.Rows[1];
            LoadAlbumInfo();

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
                DGValbum.Invalidate(); // Force a visual refresh
                DGValbum.Update();
            }
            else
            {
                List<Album> albums = albumsDAO.GetAlbums();
                List<Album> filtered = albums.Where(x => x.Title.ToLower().Contains(tbSearch.Text.ToLower()) || x.ArtistName.ToLower().Contains(tbSearch.Text.ToLower())).ToList();
                albumBinding.DataSource = filtered;
                selectedRow = DGValbum.Rows[0];
                LoadAlbumInfo();
                DGValbum.Invalidate(); // Force a visual refresh
                DGValbum.Update();
            }
        }

        private void DGValbum_OnClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            selectedRow = DGValbum.Rows[e.RowIndex];
            LoadAlbumInfo();

        }

        private void AddAlbum_OnClick(object sender, EventArgs e)
        {

            addAlbum.ShowDialog();

        }

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

        private void PbCover_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null || pbCover.ImageLocation == "")
            {
                pbCover.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            }
        }

    }

}
