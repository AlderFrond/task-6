using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Rect rectangle = new Rect();

        private Random r = new Random(DateTime.Now.TimeOfDay.Milliseconds);

        public Form1()
        {
            InitializeComponent();

            rectangle.X = 50;
            rectangle.Y = 50;
            rectangle.Width = 150;
            rectangle.Height = 150;
            rectangle.Color = Color.White;
            
            //Для отрисовки вне формы. Картинка будет рисоваться в памяти а потом передаваться в форму. 
            DoubleBuffered = true; 
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            rectangle.Draw(e.Graphics);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x.Text = e.X.ToString(); 
            y.Text = e.Y.ToString();
            
            if (rectangle.IsInside(e.X, e.Y))
            {
                rectangle.Color = Color.Aqua;
            }
            else
            {
                rectangle.Color = Color.Red;
            }
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (rectangle.IsInside(e.X, e.Y))
            {
                rectangle.X = r.Next(0, Width - rectangle.Width - 15);
                rectangle.Y = r.Next(0, Height - rectangle.Height - 40);

                newx.Text = rectangle.X.ToString();
                newy.Text = rectangle.Y.ToString();


                Refresh();
            }
        }
    }
}
