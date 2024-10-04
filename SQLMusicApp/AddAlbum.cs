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
                mainForm.AddAlbum(album);

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
    }
}
