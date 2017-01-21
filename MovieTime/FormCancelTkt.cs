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

    public partial class FormCancelTkt : Form
    {

        Booking abook = new Booking();

        public FormCancelTkt()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            if (bookingIdTextBox.Text != "")
            {
                int bookid = Convert.ToInt32(bookingIdTextBox.Text);
                abook.SearchBooking(bookid);
                MessageBox.Show("Book Id:"+abook.BookingId+" \nMovieName:"+abook.MovieName
                    +" \nCustomer:"+abook.CustName
                    +" \nDate:"+abook.Date
                    +" ShowTime:"+abook.ShowTime,"Confirm Delete");
                int count = abook.DeleteBooking(bookid);
               // MessageBox.Show(count + ": Ticket cancellation confirmed");
                //int count = abook.DeleteBooking(bookid);

            }
            else
            {

                if (nameTextBox.Text != "")
                {
                    string name = nameTextBox.Text;
                    int count = abook.DeleteName(name);

                    MessageBox.Show(count + ": Ticket Cancellation confirmed");
                }


                else
                {

                    if (phoneNumberTextBox.Text != "")
                    {
                        string num = phoneNumberTextBox.Text;
                        int count = abook.DeletePhone(num);
                        MessageBox.Show(count + ":Ticket Cancellation confirmed");
                    }
                }
            }
        }
    }
}
