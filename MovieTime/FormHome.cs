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
    public partial class FormHome : Form
    {
        Form childForm;
        public FormHome()
        {
            InitializeComponent();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {


            if (null != childForm)
            {
                childForm.Close();
                childForm = null;
            }
            childForm = new FormBookTicket();
            childForm.MdiParent = ParentForm;
            childForm.ControlBox = false;
            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
         
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (null != childForm)
            {
                childForm.Close();
                childForm = null;
            }
            childForm = new FormCancelTkt();
            childForm.MdiParent = ParentForm;
            childForm.ControlBox = false;
            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

            if (null != childForm)
            {
                childForm.Close();
                childForm = null;
            }
            childForm = new FormViewReport();
            childForm.MdiParent = ParentForm;
            childForm.ControlBox = false;
            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
    }
}
