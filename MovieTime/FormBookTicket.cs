using MovieTime.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieTime
{
    public partial class FormBookTicket : Form
    {
        Booking abook;
        List<Movie> movieList = new List<Movie>();
        
        public FormBookTicket()
        {
            InitializeComponent();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {

            if (null != movieListBox.SelectedItem && !movieListBox.SelectedItem.Equals(""))
            {
                try
                {
                    int bid = int.Parse(bookingIdTextBox.Text);
                    string name = customerNameTextBox.Text;
                    int seats = int.Parse(noOfSeatsTextBox.Text);
                    string phNo = phoneNumberTextBox.Text;
                    Movie selMovie = movieList[movieListBox.SelectedIndex];
                    string moviename = selMovie.MovieName;
                    DateTime dat = selMovie.Date;
                    string stime = selMovie.ShowTime;
                    Double unitprice = selMovie.Price;
                    abook = new Booking(bid, moviename, name, phNo, seats, dat, stime, unitprice);
                    int r = abook.AddBooking(selMovie);
                    if (r == -1)
                    {
                        throw new Exception("Error while adding customer");
                    }
                    else
                    {
                        MessageBox.Show("\tBook Id:" + abook.BookingId + " \n\tMovieName:" + abook.MovieName
                    + " \n\tCustomer:" + abook.CustName
                    + " \n\tDate:" + abook.Date
                    + "  ShowTime:" + abook.ShowTime
                    +" \n\tAmount Due:"+abook.Price.ToString("c"), "Ticket Booked");
                    }
                }
                catch (Exception ey) { MessageBox.Show(ey.Message); }
            }
            else
            {
                MessageBox.Show("Select A Movie to Book Tickets", "Movie Not selected");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string movieName = movieNameTextBox.Text;
            string language = languageTextBox.Text;
            DateTime date = movieDateDateTimePicker.Value.Date;
            DataTable dt = new DataTable();
            Movie movie = new Movie();

            try
            {
                dt = movie.PopulateMovieListBox(movieName, language, date);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DateTime dat = DateTime.Parse(dt.Rows[i]["Date"].ToString());
                        Double price = Double.Parse(dt.Rows[i]["Price"].ToString());
                        int mId = int.Parse(dt.Rows[i]["MovieId"].ToString());
                        int num = int.Parse(dt.Rows[i]["NumofSeats"].ToString());
                        movie = new Movie(mId, dt.Rows[i]["MovieName"].ToString() , dat 
                            , dt.Rows[i]["Showtime"].ToString(), dt.Rows[i]["Language"].ToString(), price, num);


                        movieList.Add(movie);
                        movieListBox.Items.Add(movie.ToString());
                       // movieListBox.Items.Add("Movie Name: " + dt.Rows[i]["MovieName"].ToString().Trim() + "; Date: " + 
                            //dt.Rows[i]["Date"].ToString() + "; Show Time: " + dt.Rows[i]["Showtime"].ToString() + "; Language " 
                            //+ dt.Rows[i]["Language"].ToString());
                    }
                }
                    else
                    movieListBox.Items.Add("Records not Found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            movieListBox.Items.Clear();
            movieNameTextBox.Text = "";
            languageTextBox.Text = "";
            bookingIdTextBox.Text = "";
            customerNameTextBox.Text = "";
            noOfSeatsTextBox.Text = "";
            phoneNumberTextBox.Text = "";
        }

        private void searchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            movieListBox.Items.Clear();

            //Linq query showing students with status 1 only
            var query = (from movie in movieList
                         where movie.TotalNumSeats > 0 
                         orderby movie.Date
                         select movie);

            movieList = new List<Movie>();
            foreach (Movie a in query)
            {
                movieList.Add(a);
                movieListBox.Items.Add(a.ToString());

            }
        }
    }
}
