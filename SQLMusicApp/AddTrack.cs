using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLMusicApp
{
    public partial class AddTrack : Form
    {
        AlbumsDAO albumsDAO;
        private Main mainForm;
        public event Action TrackAdded;


        public AddTrack(AlbumsDAO albumsDAO, Main mainForm)
        {
            InitializeComponent();
            this.albumsDAO = albumsDAO;
            this.mainForm = mainForm;
        }

        private void TbTitle_TextChanged(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                lblTitle.Text = "Title";
            }
            else
            {
                lblTitle.Text = tbTitle.Text;
            }
            checkInput();
        }

        public void SetAlbumID(int albumID)
        {
            tbAlbumID.Text = albumID.ToString();
        }

        private void TbImage_TextChanged(object sender, EventArgs e)
        {
            if (tbVideoURL.Text == "")
            {
                webView21.Source = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
            }
            else
            {
                try
                {
                    webView21.Source = new Uri(tbVideoURL.Text);
                }
                catch (Exception)
                {
                    webView21.Source = new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png");
                }
            }
            checkInput();
        }

        private void TbDesc_TextChanged(object sender, EventArgs e)
        {
            if (tbLyrics.Text == "")
            {
                lblLyrics.Text = "Lyrics";
            }
            else
            {
                lblLyrics.Text = tbLyrics.Text;
            }
            checkInput();
        }

        private void TbYear_TextChanged(object sender, EventArgs e)
        {
            if (tbNumber.Text == "")
            {
                lblNumber.Text = "Number";
            }
            else
            {
                lblNumber.Text = tbNumber.Text;
            }
            checkInput();
        }

        private void TbArtist_TextChanged(object sender, EventArgs e)
        {
            if (tbAlbumID.Text == "")
            {
                lblAlbumID.Text = "Album ID";
            }
            else
            {
                lblAlbumID.Text = tbAlbumID.Text;
            }
            checkInput();
        }

        private void AddAlbum_OnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbVideoURL.Text))
            {
                tbVideoURL.Text = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            }
            else
            {
                Track track = new Track
                {
                    Title = tbTitle.Text,
                    Number = Convert.ToInt32(tbNumber.Text),
                    VideoUrl = tbVideoURL.Text,
                    Lyrics = tbLyrics.Text,
                    AlbumID = Convert.ToInt32(tbAlbumID.Text),
                    ID = 0
                };
                try
                {
                    mainForm.AddTrack(track);
                }
                catch
                {
                    MessageBox.Show("Error adding track, check your input");
                }
                tbTitle.Text = "";
                tbNumber.Text = "";
                tbVideoURL.Text = "";
                tbLyrics.Text = "";
                tbAlbumID.Text = "";

                this.Close();
            }
        }

        private void checkInput()
        {
            string errMsg = "";

            if (string.IsNullOrWhiteSpace(tbLyrics.Text))
                errMsg = "Lyrics cannot be empty\n";
            if (string.IsNullOrWhiteSpace(tbVideoURL.Text))
                errMsg = "Video URL cannot be empty\n";
            if (string.IsNullOrWhiteSpace(tbNumber.Text))
                errMsg = "Number cannot be empty\n";
            if (!int.TryParse(tbNumber.Text, out int number))
                errMsg = "Number must be a number\n";
            if (string.IsNullOrWhiteSpace(tbAlbumID.Text))
                errMsg = "Album ID cannot be empty\n";
            if (!int.TryParse(tbAlbumID.Text, out int albumID))
                errMsg = "Album ID must be a number\n";
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
                errMsg = "Title cannot be empty\n";

            if (errMsg != "")
            {
                lblError.Text = errMsg;
                lblError.Visible = true;
                btnAddTrack.Enabled = false;
            } else
            {
                lblError.Visible = false;
                btnAddTrack.Enabled = true;
            }


        }
    }
}
