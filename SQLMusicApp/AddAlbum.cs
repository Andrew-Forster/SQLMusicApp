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
    public partial class AddAlbum : Form
    {
        AlbumsDAO albumsDAO;
        private Main mainForm;
        public event Action AlbumAdded;


        public AddAlbum(AlbumsDAO albumsDAO, Main mainForm)
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

        private void TbImage_TextChanged(object sender, EventArgs e)
        {
            if (tbImage.Text == "")
            {
                pbImage.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            }
            else
            {
                pbImage.ImageLocation = tbImage.Text;
            }
            checkInput();

        }

        private void TbDesc_TextChanged(object sender, EventArgs e)
        {
            if (tbDesc.Text == "")
            {
                lblDesc.Text = "Description";
            }
            else
            {
                lblDesc.Text = tbDesc.Text;
            }
            checkInput();

        }

        private void TbYear_TextChanged(object sender, EventArgs e)
        {
            if (tbYear.Text == "")
            {
                lblYear.Text = "Year";
            }
            else
            {
                lblYear.Text = tbYear.Text;
            }
            checkInput();

        }

        private void TbArtist_TextChanged(object sender, EventArgs e)
        {
            if (tbArtist.Text == "")
            {
                lblArtist.Text = "Artist";
            }
            else
            {
                lblArtist.Text = tbArtist.Text;
            }
            checkInput();

        }

        private void AddAlbum_OnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbImage.Text))
            {
                tbImage.Text = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            }
            else
            {
                Album album = new Album
                {
                    Title = tbTitle.Text,
                    ArtistName = tbArtist.Text,
                    Year = Convert.ToInt32(tbYear.Text),
                    ImageUrl = tbImage.Text,
                    Description = tbDesc.Text
                };
                try
                {
                    mainForm.AddAlbum(album);
                }
                catch
                {
                    MessageBox.Show("Error adding album, check your input");
                }

                this.Close();
            }
        }

        private void PbImage_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                pbImage.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Placeholder_view_vector.svg/991px-Placeholder_view_vector.svg.png";
            }
        }

        private void checkInput()
        {
            string errMsg = "";
            if (string.IsNullOrWhiteSpace(tbDesc.Text))
                errMsg = "Description cannot be empty\n";
            if (string.IsNullOrWhiteSpace(tbImage.Text))
                errMsg = "Image URL cannot be empty\n";
            if (!int.TryParse(tbYear.Text, out int year))
                errMsg = "Year must be a number\n";
            if (string.IsNullOrWhiteSpace(tbYear.Text))
                errMsg = "Year cannot be empty\n";
            if (string.IsNullOrWhiteSpace(tbArtist.Text))
                errMsg = "Artist cannot be empty\n";
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
                errMsg = "Title cannot be empty\n";

            if (errMsg != "")
            {
                lblError.Text = errMsg;
                lblError.Visible = true;

                btnAddAlbum.Enabled = false;
            }
            else
            {
                lblError.Visible = false;
                btnAddAlbum.Enabled = true;
            }

        }
    }
}
