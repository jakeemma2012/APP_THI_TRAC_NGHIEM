using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_THI_TRAC_NGHIEM.Function
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btThiSinh_Click(object sender, EventArgs e)
        {
            frmThiSinh frm = new frmThiSinh();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            hideChild(frm);
            frm.Show();
        }


        void hideChild(Form childrenForm)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Hide();
            }
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.Size = new Size(childrenForm.Width,childrenForm.Height);
            }
        }
    }
}
