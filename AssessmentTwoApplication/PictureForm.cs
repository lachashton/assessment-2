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
    public partial class PictureForm : Form
    {
        public PictureForm()
        {
            InitializeComponent();
            this.Height = 1000;
            this.Width = 1000;
        }

        private void PictureForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen blackPen = new Pen(Color.Black); //Black pen
            Pen redPen = new Pen(Color.Orange); //Red pen
            Brush orangeBrush = new SolidBrush(Color.Orange); //Orange Brush
            Brush tourqBrush = new SolidBrush(Color.Turquoise); //Blue Brush
            Brush greenBrush = new SolidBrush(Color.LawnGreen); //Green Brush
            Brush brownBrush = new SolidBrush(Color.SandyBrown); //Brown Brush
            Brush greyBrush = new SolidBrush(Color.Gray); //Grey Brush
            Brush skyBlueBrush = new SolidBrush(Color.SkyBlue); //Sky-Blue Brush
            Brush inRedBrush = new SolidBrush(Color.IndianRed); //Sky-Blue Brush


            g.FillRectangle(skyBlueBrush, 0, 0, 1000, 1000);      //Sky colour

            g.DrawRectangle(blackPen, 250, 250, 500, 500);  //House
            g.FillRectangle(brownBrush, 251, 251, 499, 499); //house colour
            g.DrawRectangle(blackPen, 600, 450, 100, 100);    //Window Right
            g.DrawRectangle(blackPen, 300, 450, 100, 100);    //Window Left
            g.DrawRectangle(blackPen, 450, 600, 100, 150);   //Door
            g.DrawLine(blackPen, 250, 250, 500, 100);      //Roof Left
            g.DrawLine(blackPen, 750, 250, 500, 100);       //Roof Right
            g.DrawLine(blackPen, 1000, 750, 0, 750);       //Footpath Top
            g.DrawLine(blackPen, 1000, 850, 0, 850);       //Footpath Bottom
            g.DrawEllipse(redPen, -50, -50, 220, 220);   //A Sun
            g.DrawEllipse(blackPen, 455, 675, 10, 10);    //Door Knob

            g.FillEllipse(orangeBrush, -50, -50, 220, 220);      //Sun Colour
            g.FillRectangle(tourqBrush, 301, 451, 99, 99);      //Window Left Colour
            g.FillRectangle(tourqBrush, 601, 451, 99, 99);      //Window Right Colour
            g.FillRectangle(greyBrush, 0, 751, 1000, 99);      //footpath top Colour
            g.FillRectangle(greenBrush, 0, 851, 1000, 120);      //footpath bottom Colour
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
