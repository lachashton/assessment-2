//*********************************************************************
//Programmer:Lachlan Ashton
//CIT Number: 214233
//Date: 08/10/2019
//Software: Microsoft Visual Studio Community 2019
//Platform: Microsoft Windows 10 Professional 64‐bit
//Purpose: Give a user access to various differant application demonstations
//*********************************************************************

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

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
