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
    public partial class FormViewReport : Form
    {
        DataTable dt = null;
        Booking abook = new Booking();
        public FormViewReport()
        {
            InitializeComponent();
        }

        private void FormViewReport_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'movieTimeDBDataSet.Booking' table. You can move, or remove it, as needed.
             dt = abook.populate();
            displayDataGrid.DataSource = abook.populate();
           // this.bookingTableAdapter.Fill(this.onlineMovieDataSet.Booking);
        }


      
       
    }
}
