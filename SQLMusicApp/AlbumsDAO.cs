using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLMusicApp
{
    public class AlbumsDAO
    {
        private string connectionString = "Data Source=localhost;port=3306;username=root;password=root;database=music";
        List<Album> albums = new List<Album>();

        /// <summary>
        /// Loads all albums from the database
        /// </summary>
        /// <returns></returns>
        public List<Album> LoadAlbums()
        {
            albums.Clear();
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM albums";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Album album = new Album
                {
                    ID = reader.GetInt32("ID"),
                    Title = reader.GetString("Album_Title"),
                    ArtistName = reader.GetString("Artist"),
                    Year = reader.GetInt32("Year"),
                    ImageUrl = reader.GetString("Image_Name"),
                    Description = reader.GetString("Description")
                };
                albums.Add(album);
            }
            conn.Close();
            return albums;
        }

        /// <summary>
        /// Adds an album to the database
        /// </summary>
        /// <param name="album"></param>
        public void AddAlbum(Album album)
        {
            albums.Add(album);

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO albums (Album_Title, Artist, Year, Image_Name, Description) VALUES (@title, @artist, @year, @image, @desc)";
            cmd.Parameters.AddWithValue("@title", album.Title);
            cmd.Parameters.AddWithValue("@artist", album.ArtistName);
            cmd.Parameters.AddWithValue("@year", album.Year);
            cmd.Parameters.AddWithValue("@image", album.ImageUrl);
            cmd.Parameters.AddWithValue("@desc", album.Description);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Adds an album to the list without adding it to the database
        /// </summary>
        /// <param name="album"></param>
        public void AddAlbumNoDb(Album album)
        {
            albums.Add(album);
        }

        public List<Album> GetAlbums()
        {
            return albums;
        }

        /// <summary>
        /// Removes an album from the list and the database
        /// </summary>
        /// <param name="id"></param>
        public void RemoveAlbum(int id)
        {

            albums.RemoveAll(x => x.ID == id);
            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM albums WHERE ID = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Error removing album, may have not existed in DB");
            }
            MessageBox.Show("Album removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
