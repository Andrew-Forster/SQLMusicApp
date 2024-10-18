namespace SQLMusicApp
{
    partial class AddTrack
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            lblNumber = new Label();
            btnAddTrack = new Button();
            lblAlbumID = new Label();
            lblLyrics = new Label();
            lblTitle = new Label();
            tbLyrics = new RichTextBox();
            label5 = new Label();
            tbVideoURL = new TextBox();
            label4 = new Label();
            tbNumber = new TextBox();
            label3 = new Label();
            tbAlbumID = new TextBox();
            label2 = new Label();
            tbTitle = new TextBox();
            label1 = new Label();
            lblError = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblError);
            groupBox1.Controls.Add(webView21);
            groupBox1.Controls.Add(lblNumber);
            groupBox1.Controls.Add(btnAddTrack);
            groupBox1.Controls.Add(lblAlbumID);
            groupBox1.Controls.Add(lblLyrics);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(tbLyrics);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbVideoURL);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbNumber);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbAlbumID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 328);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Track";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(246, 30);
            webView21.Name = "webView21";
            webView21.Size = new Size(223, 261);
            webView21.TabIndex = 16;
            webView21.ZoomFactor = 1D;
            // 
            // lblNumber
            // 
            lblNumber.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNumber.Location = new Point(483, 62);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(37, 18);
            lblNumber.TabIndex = 15;
            lblNumber.Text = "Number";
            // 
            // btnAddTrack
            // 
            btnAddTrack.BackColor = Color.FromArgb(192, 255, 192);
            btnAddTrack.FlatStyle = FlatStyle.Flat;
            btnAddTrack.Location = new Point(6, 262);
            btnAddTrack.Name = "btnAddTrack";
            btnAddTrack.Size = new Size(218, 29);
            btnAddTrack.TabIndex = 14;
            btnAddTrack.Text = "Add Track";
            btnAddTrack.UseVisualStyleBackColor = false;
            btnAddTrack.Click += AddAlbum_OnClick;
            // 
            // lblAlbumID
            // 
            lblAlbumID.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAlbumID.Location = new Point(526, 62);
            lblAlbumID.Name = "lblAlbumID";
            lblAlbumID.Size = new Size(170, 20);
            lblAlbumID.TabIndex = 13;
            lblAlbumID.Text = "Album ID";
            // 
            // lblLyrics
            // 
            lblLyrics.Font = new Font("Segoe UI", 10F);
            lblLyrics.Location = new Point(480, 82);
            lblLyrics.Name = "lblLyrics";
            lblLyrics.Size = new Size(290, 166);
            lblLyrics.TabIndex = 12;
            lblLyrics.Text = "Lyrics";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(475, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(295, 36);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Track";
            // 
            // tbLyrics
            // 
            tbLyrics.BackColor = Color.White;
            tbLyrics.BorderStyle = BorderStyle.FixedSingle;
            tbLyrics.Location = new Point(99, 165);
            tbLyrics.Name = "tbLyrics";
            tbLyrics.Size = new Size(125, 83);
            tbLyrics.TabIndex = 9;
            tbLyrics.Text = "";
            tbLyrics.TextChanged += TbDesc_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 165);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 8;
            label5.Text = "Lyrics";
            // 
            // tbVideoURL
            // 
            tbVideoURL.Location = new Point(99, 129);
            tbVideoURL.Name = "tbVideoURL";
            tbVideoURL.Size = new Size(125, 27);
            tbVideoURL.TabIndex = 7;
            tbVideoURL.TextChanged += TbImage_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 132);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 6;
            label4.Text = "Video URL";
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(99, 96);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(125, 27);
            tbNumber.TabIndex = 5;
            tbNumber.TextChanged += TbYear_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 99);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 4;
            label3.Text = "Number";
            // 
            // tbAlbumID
            // 
            tbAlbumID.Location = new Point(99, 63);
            tbAlbumID.Name = "tbAlbumID";
            tbAlbumID.Size = new Size(125, 27);
            tbAlbumID.TabIndex = 3;
            tbAlbumID.TextChanged += TbArtist_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 66);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Album ID";
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
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Track Title";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(6, 294);
            lblError.Name = "lblError";
            lblError.Size = new Size(27, 20);
            lblError.TabIndex = 17;
            lblError.Text = "Err";
            lblError.Visible = false;
            // 
            // AddTrack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 351);
            Controls.Add(groupBox1);
            Name = "AddTrack";
            Text = "AddAlbum";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox tbLyrics;
        private Label label5;
        private TextBox tbVideoURL;
        private Label label4;
        private TextBox tbNumber;
        private Label label3;
        private TextBox tbAlbumID;
        private Label label2;
        private TextBox tbTitle;
        private Label label1;
        private Button btnAddTrack;
        private Label lblAlbumID;
        private Label lblLyrics;
        private Label lblTitle;
        private Label lblNumber;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label lblError;
    }
}