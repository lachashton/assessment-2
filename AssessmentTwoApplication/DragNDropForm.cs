//*********************************************************************
//Programmer:Lachlan Ashton
//CIT Number: 214233
//Date: 08/10/2019
//Software: Microsoft Visual Studio Community 2019
//Platform: Microsoft Windows 10 Professional 64‐bit
//Purpose: Allow a user to drag and drop any image into an image box, this demonstrates drag and drop functions of C#
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
    
    public partial class DragNDropForm : Form
    {
        private string fileLocation = null;

        public DragNDropForm()
        {
            InitializeComponent();
        }

        private void DragNDropForm_Load(object sender, EventArgs e)
        {
            picBox.AllowDrop = true;
        }

        private void picBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var data = e.Data.GetData(DataFormats.FileDrop);
                if (data != null)
                {
                    var fileNames = data as string[]; //get the file name and location
                    if (fileNames.Length > 0)
                        picBox.Image = Image.FromFile(fileNames[0]); //set picture box to dropped file
                    fileLocation = fileNames[0];
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Please only insert image files!"); //return error if anyone attempts to insert a file that is of incorrect type
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            picBox.Image = null; //clear the current image from picture box
            fileLocation = null; //clear saved file location
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); //close this child form
        }

        private void btnFileLocate_Click(object sender, EventArgs e)
        {
            if (fileLocation != null)
                MessageBox.Show("File location is:  " + fileLocation); //shows the dropped file location
            else
                MessageBox.Show("You must drop a file first!"); //user didnt drop a file, yet
            
        }
    }
}
