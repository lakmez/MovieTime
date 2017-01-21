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
    public partial class ParentForm : Form
    {
        FormHome childForm;
        public ParentForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            if (null != childForm)
            {
                childForm.Close();
                childForm = null;
            }
            childForm = new FormHome();
            childForm.MdiParent = this;
            childForm.ControlBox = false;
            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != childForm)
            {
                childForm.Close();
                childForm = null;
            }
            childForm = new FormHome();
            childForm.MdiParent = this;
            childForm.ControlBox = false;
            childForm.MinimizeBox = false;
            childForm.MaximizeBox = false;
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }
    }
}
