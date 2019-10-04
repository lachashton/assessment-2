using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentTwoApplication
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpenApp1_Click(object sender, EventArgs e)
        {
            PictureForm pictureApp = new PictureForm();
            pictureApp.ShowDialog();
        }

        private void btnOpenApp2_Click(object sender, EventArgs e)
        {
            DragNDropForm dragNDropApp = new DragNDropForm();
            dragNDropApp.ShowDialog();
        }
    }
}
