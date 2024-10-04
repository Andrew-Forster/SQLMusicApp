namespace SQLMusicApp
{
    partial class AddAlbum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            lblYear = new Label();
            btnAddAlbum = new Button();
            lblArtist = new Label();
            lblDesc = new Label();
            lblTitle = new Label();
            pbImage = new PictureBox();
            tbDesc = new RichTextBox();
            label5 = new Label();
            tbImage = new TextBox();
            label4 = new Label();
            tbYear = new TextBox();
            label3 = new Label();
            tbArtist = new TextBox();
            label2 = new Label();
            tbTitle = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblYear);
            groupBox1.Controls.Add(btnAddAlbum);
            groupBox1.Controls.Add(lblArtist);
            groupBox1.Controls.Add(lblDesc);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(pbImage);
            groupBox1.Controls.Add(tbDesc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbImage);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbYear);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbArtist);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add An Album";
            // 
            // lblYear
            // 
            lblYear.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(483, 62);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 18);
            lblYear.TabIndex = 15;
            lblYear.Text = "Year";
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.BackColor = Color.FromArgb(192, 255, 192);
            btnAddAlbum.FlatStyle = FlatStyle.Flat;
            btnAddAlbum.Location = new Point(6, 262);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(218, 29);
            btnAddAlbum.TabIndex = 14;
            btnAddAlbum.Text = "Add Album";
            btnAddAlbum.UseVisualStyleBackColor = false;
            btnAddAlbum.Click += AddAlbum_OnClick;
            // 
            // lblArtist
            // 
            lblArtist.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblArtist.Location = new Point(526, 62);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(170, 20);
            lblArtist.TabIndex = 13;
            lblArtist.Text = "Artist";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 10F);
            lblDesc.Location = new Point(480, 82);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(290, 166);
            lblDesc.TabIndex = 12;
            lblDesc.Text = "Description";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(475, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 36);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Album";
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.ErrorImage = Properties.Resources._991px_Placeholder_view_vector_svg_1_;
            pbImage.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            pbImage.Location = new Point(246, 26);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(222, 222);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 10;
            pbImage.TabStop = false;
            pbImage.LoadCompleted += PbImage_LoadCompleted;
            // 
            // tbDesc
            // 
            tbDesc.BackColor = Color.White;
            tbDesc.BorderStyle = BorderStyle.FixedSingle;
            tbDesc.Location = new Point(99, 165);
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(125, 83);
            tbDesc.TabIndex = 9;
            tbDesc.Text = "";
            tbDesc.TextChanged += TbDesc_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 165);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // tbImage
            // 
            tbImage.Location = new Point(99, 129);
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(125, 27);
            tbImage.TabIndex = 7;
            tbImage.TextChanged += TbImage_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 132);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Image URL";
            // 
            // tbYear
            // 
            tbYear.Location = new Point(99, 96);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(125, 27);
            tbYear.TabIndex = 5;
            tbYear.TextChanged += TbYear_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 99);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // tbArtist
            // 
            tbArtist.Location = new Point(99, 63);
            tbArtist.Name = "tbArtist";
            tbArtist.Size = new Size(125, 27);
            tbArtist.TabIndex = 3;
            tbArtist.TextChanged += TbArtist_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 66);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 2;
            label2.Text = "Artist";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(99, 30);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(125, 27);
            tbTitle.TabIndex = 1;
            tbTitle.TextChanged += TbTitle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Album Title";
            // 
            // AddAlbum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 320);
            Controls.Add(groupBox1);
            Name = "AddAlbum";
            Text = "AddAlbum";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox tbDesc;
        private Label label5;
        private TextBox tbImage;
        private Label label4;
        private TextBox tbYear;
        private Label label3;
        private TextBox tbArtist;
        private Label label2;
        private TextBox tbTitle;
        private Label label1;
        private Button btnAddAlbum;
        private Label lblArtist;
        private Label lblDesc;
        private Label lblTitle;
        private PictureBox pbImage;
        private Label lblYear;
    }
}