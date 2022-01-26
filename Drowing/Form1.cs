using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drowing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int x, y, x1, y1;

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);
        }

        private void radLine_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           
            
            if (radLine.Checked)
            {
                x1 = e.X;
                y1 = e.Y;
                Point p1 = new Point(x, y);
                Point p2 = new Point(x1, y1);
                this.CreateGraphics().DrawLine(Pens.Black, p1, p2);
            }else if (radElips.Checked)
            {
               
              
                    x1 = Math.Abs(e.X - x);
                    y1 = Math.Abs(e.Y - y);
                   
                
                Rectangle shape = new Rectangle(x, y, x1, y1);
                this.CreateGraphics().DrawEllipse(Pens.Black,shape);
            }
            else if(radRegtangle.Checked)
            {
                x1 = Math.Abs(e.X - x);
                y1 =Math.Abs( e.Y - y);
                Rectangle shape = new Rectangle(x, y, x1, y1);
                this.CreateGraphics().DrawRectangle(Pens.Black, shape); }
            
        }
        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

        }
        

    }
}
