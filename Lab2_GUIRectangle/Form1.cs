using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab2_GUIRectangle
{

    public partial class Form1 : Form
    {
        private Rectangle[] rectangles = new Rectangle[]
       {
           new Rectangle(10, 10, 100, 100),
           new Square(150, 30, 70, Brushes.BlueViolet),
           new Rectangle(30, 30, 120, 120),
           new Square(100, 100, 20, Brushes.Crimson)
       };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Rectangle CreateRectangle()
        {
            Random random = new Random();
            int left = random.Next(1, 100);
            int top = random.Next(1, 100);
            int right = random.Next(200, 300);
            int bottom = random.Next(200, 300);

            return new Rectangle(left, top, right, bottom);
        }


        private void Form1_DoubleClick_1(object sender, EventArgs e)
        {
            Rectangle rectangle = CreateRectangle();

            Rectangle[] newArray = new Rectangle[rectangles.Length + 1];
            Array.Copy(rectangles, newArray, 1);
            newArray[1] = rectangle;
            Array.Copy(rectangles, 1, newArray, 2, rectangles.Length - 1);
            rectangles = newArray;

            Form1_Paint_1(null, null);
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                foreach (Rectangle rectangle in rectangles)
                {

                    rectangle.Show(g);
                }
            }
        }




    }
}
