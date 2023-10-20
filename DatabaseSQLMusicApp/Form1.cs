using System.Reflection;
using System.Windows.Forms;


namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control

            albums = albumsDAO.getAllAlbums();

            albumBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumBindingSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control

            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            //get the row number cicked

            int rowClicked = dataGridView.CurrentRow.Index;
            // MessageBox.Show("You clicked row " + rowClicked);

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            // MessageBox.Show("URL=" + imageURL);

            pictureBox1.Load(imageURL);


            tracksBindingSource.DataSource = albums[rowClicked].Tracks;

            dataGridView2.DataSource = tracksBindingSource;


        }

        // This is For the Video Player

        // Here the code for the Video Player ends



        private void button3_Click(object sender, EventArgs e)
        {
            // add a new item to the database with an inline constructor
            Album album = new Album
            {
                AlbumName = txt_albumName.Text,
                ArtistName = txt_albumArtist.Text,
                Year = Int32.Parse(txt_albumYear.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_description.Text

            };

            AlbumsDAO albumsDao = new AlbumsDAO();
            int result = albumsDao.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //get the row number cicked

            int rowClicked = dataGridView2.CurrentRow.Index;

            MessageBox.Show("You clicked row " + rowClicked);

            // fetching the id number from the click in the grid

            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;

            MessageBox.Show("ID of track " + trackID);

            AlbumsDAO albumsDao = new AlbumsDAO();

            int result = albumsDao.deleteTrack(trackID);

            MessageBox.Show("Result " + result);

            dataGridView2.DataSource = null;

            albums = albumsDao.getAllAlbums();

        }
    }
}