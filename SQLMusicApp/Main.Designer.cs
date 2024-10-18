namespace SQLMusicApp
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadAlbums = new Button();
            dgvAlbums = new DataGridView();
            tbSearch = new TextBox();
            pbCover = new PictureBox();
            lblSearch = new Label();
            lblTitle = new Label();
            lblDesc = new Label();
            lblArtist = new Label();
            btnAddAlbum = new Button();
            btnDelAlbum = new Button();
            dgvTracks = new DataGridView();
            lblTracks = new Label();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            btnDelTrack = new Button();
            btnAddTrack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTracks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // loadAlbums
            // 
            loadAlbums.BackColor = Color.FromArgb(192, 255, 255);
            loadAlbums.FlatStyle = FlatStyle.Popup;
            loadAlbums.Location = new Point(871, 292);
            loadAlbums.Name = "loadAlbums";
            loadAlbums.Size = new Size(131, 29);
            loadAlbums.TabIndex = 0;
            loadAlbums.Text = "Load Albums";
            loadAlbums.UseVisualStyleBackColor = false;
            loadAlbums.Click += LoadAlbums_OnClick;
            // 
            // dgvAlbums
            // 
            dgvAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbums.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAlbums.Location = new Point(294, 12);
            dgvAlbums.Name = "dgvAlbums";
            dgvAlbums.RowHeadersWidth = 51;
            dgvAlbums.Size = new Size(708, 274);
            dgvAlbums.TabIndex = 1;
            dgvAlbums.CellClick += DGValbum_OnClick;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(74, 12);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(200, 27);
            tbSearch.TabIndex = 2;
            tbSearch.TextChanged += Search_TextChanged;
            // 
            // pbCover
            // 
            pbCover.BorderStyle = BorderStyle.FixedSingle;
            pbCover.ErrorImage = Properties.Resources._991px_Placeholder_view_vector_svg_1_;
            pbCover.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            pbCover.Location = new Point(12, 47);
            pbCover.Name = "pbCover";
            pbCover.Size = new Size(262, 239);
            pbCover.SizeMode = PictureBoxSizeMode.Zoom;
            pbCover.TabIndex = 3;
            pbCover.TabStop = false;
            pbCover.LoadCompleted += PbCover_LoadCompleted;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(56, 20);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Search:";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 289);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 36);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Album";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 10F);
            lblDesc.Location = new Point(12, 344);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(262, 224);
            lblDesc.TabIndex = 6;
            lblDesc.Text = "Description";
            // 
            // lblArtist
            // 
            lblArtist.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblArtist.Location = new Point(12, 324);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(170, 20);
            lblArtist.TabIndex = 7;
            lblArtist.Text = "Artist";
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.BackColor = Color.FromArgb(192, 255, 192);
            btnAddAlbum.FlatStyle = FlatStyle.Popup;
            btnAddAlbum.Location = new Point(549, 292);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(150, 29);
            btnAddAlbum.TabIndex = 8;
            btnAddAlbum.Text = "Add Album";
            btnAddAlbum.UseVisualStyleBackColor = false;
            btnAddAlbum.Click += AddAlbum_OnClick;
            // 
            // btnDelAlbum
            // 
            btnDelAlbum.BackColor = Color.FromArgb(255, 192, 192);
            btnDelAlbum.FlatStyle = FlatStyle.Popup;
            btnDelAlbum.Location = new Point(705, 292);
            btnDelAlbum.Name = "btnDelAlbum";
            btnDelAlbum.Size = new Size(160, 29);
            btnDelAlbum.TabIndex = 9;
            btnDelAlbum.Text = "Remove Album";
            btnDelAlbum.UseVisualStyleBackColor = false;
            btnDelAlbum.Click += BtnDelAlbum_OnClick;
            // 
            // dgvTracks
            // 
            dgvTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTracks.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTracks.Location = new Point(294, 329);
            dgvTracks.Name = "dgvTracks";
            dgvTracks.RowHeadersWidth = 51;
            dgvTracks.Size = new Size(306, 239);
            dgvTracks.TabIndex = 10;
            dgvTracks.CellClick += DGVTracks_CellClick;
            // 
            // lblTracks
            // 
            lblTracks.AutoSize = true;
            lblTracks.Location = new Point(294, 306);
            lblTracks.Name = "lblTracks";
            lblTracks.Size = new Size(52, 20);
            lblTracks.TabIndex = 11;
            lblTracks.Text = "Tracks:";
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(606, 329);
            webView.Name = "webView";
            webView.Size = new Size(396, 239);
            webView.TabIndex = 12;
            webView.ZoomFactor = 1D;
            // 
            // btnDelTrack
            // 
            btnDelTrack.BackColor = Color.FromArgb(255, 192, 192);
            btnDelTrack.FlatStyle = FlatStyle.Popup;
            btnDelTrack.Location = new Point(294, 574);
            btnDelTrack.Name = "btnDelTrack";
            btnDelTrack.Size = new Size(147, 29);
            btnDelTrack.TabIndex = 13;
            btnDelTrack.Text = "Remove Track";
            btnDelTrack.UseVisualStyleBackColor = false;
            btnDelTrack.Click += btnDelTrack_Click;
            // 
            // btnAddTrack
            // 
            btnAddTrack.BackColor = Color.FromArgb(192, 255, 192);
            btnAddTrack.FlatStyle = FlatStyle.Popup;
            btnAddTrack.Location = new Point(447, 574);
            btnAddTrack.Name = "btnAddTrack";
            btnAddTrack.Size = new Size(153, 29);
            btnAddTrack.TabIndex = 14;
            btnAddTrack.Text = "Add Track";
            btnAddTrack.UseVisualStyleBackColor = false;
            btnAddTrack.Click += btnAddTrack_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1013, 638);
            Controls.Add(btnAddTrack);
            Controls.Add(btnDelTrack);
            Controls.Add(webView);
            Controls.Add(lblTracks);
            Controls.Add(dgvTracks);
            Controls.Add(btnDelAlbum);
            Controls.Add(btnAddAlbum);
            Controls.Add(lblArtist);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Controls.Add(lblSearch);
            Controls.Add(pbCover);
            Controls.Add(tbSearch);
            Controls.Add(dgvAlbums);
            Controls.Add(loadAlbums);
            Name = "Main";
            Text = "Album Viewer";
            ((System.ComponentModel.ISupportInitialize)dgvAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTracks).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAlbums;
        private DataGridView dgvAlbums;
        private TextBox tbSearch;
        private PictureBox pbCover;
        private Label lblSearch;
        private Label lblTitle;
        private Label lblDesc;
        private Label lblArtist;
        private Button btnAddAlbum;
        private Button btnDelAlbum;
        private DataGridView dgvTracks;
        private Label lblTracks;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Button btnDelTrack;
        private Button btnAddTrack;
    }
}
