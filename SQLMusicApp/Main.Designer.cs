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
            DGValbum = new DataGridView();
            tbSearch = new TextBox();
            pbCover = new PictureBox();
            lblSearch = new Label();
            lblTitle = new Label();
            lblDesc = new Label();
            lblArtist = new Label();
            btnAddAlbum = new Button();
            btnDelAlbum = new Button();
            ((System.ComponentModel.ISupportInitialize)DGValbum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCover).BeginInit();
            SuspendLayout();
            // 
            // loadAlbums
            // 
            loadAlbums.BackColor = Color.FromArgb(192, 255, 255);
            loadAlbums.FlatStyle = FlatStyle.Popup;
            loadAlbums.Location = new Point(857, 574);
            loadAlbums.Name = "loadAlbums";
            loadAlbums.Size = new Size(131, 29);
            loadAlbums.TabIndex = 0;
            loadAlbums.Text = "Load Albums";
            loadAlbums.UseVisualStyleBackColor = false;
            loadAlbums.Click += LoadAlbums_OnClick;
            // 
            // DGValbum
            // 
            DGValbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGValbum.Location = new Point(280, 12);
            DGValbum.Name = "DGValbum";
            DGValbum.RowHeadersWidth = 51;
            DGValbum.Size = new Size(708, 556);
            DGValbum.TabIndex = 1;
            DGValbum.CellClick += DGValbum_OnClick;
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
            pbCover.Size = new Size(239, 239);
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
            lblTitle.Size = new Size(239, 36);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Album";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 10F);
            lblDesc.Location = new Point(12, 344);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(252, 224);
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
            btnAddAlbum.Location = new Point(583, 574);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(131, 29);
            btnAddAlbum.TabIndex = 8;
            btnAddAlbum.Text = "Add Album";
            btnAddAlbum.UseVisualStyleBackColor = false;
            btnAddAlbum.Click += AddAlbum_OnClick;
            // 
            // btnDelAlbum
            // 
            btnDelAlbum.BackColor = Color.FromArgb(255, 192, 192);
            btnDelAlbum.FlatStyle = FlatStyle.Popup;
            btnDelAlbum.Location = new Point(720, 574);
            btnDelAlbum.Name = "btnDelAlbum";
            btnDelAlbum.Size = new Size(131, 29);
            btnDelAlbum.TabIndex = 9;
            btnDelAlbum.Text = "Remove Album";
            btnDelAlbum.UseVisualStyleBackColor = false;
            btnDelAlbum.Click += BtnDelAlbum_OnClick;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 615);
            Controls.Add(btnDelAlbum);
            Controls.Add(btnAddAlbum);
            Controls.Add(lblArtist);
            Controls.Add(lblDesc);
            Controls.Add(lblTitle);
            Controls.Add(lblSearch);
            Controls.Add(pbCover);
            Controls.Add(tbSearch);
            Controls.Add(DGValbum);
            Controls.Add(loadAlbums);
            Name = "Main";
            Text = "Album Viewer";
            ((System.ComponentModel.ISupportInitialize)DGValbum).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAlbums;
        private DataGridView DGValbum;
        private TextBox tbSearch;
        private PictureBox pbCover;
        private Label lblSearch;
        private Label lblTitle;
        private Label lblDesc;
        private Label lblArtist;
        private Button btnAddAlbum;
        private Button btnDelAlbum;
    }
}
