using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3_GUIRectangleList
{
    public partial class Form1 : Form
    {

        private ArrayList rectangles = new ArrayList();

        private Rectangle CreateRectangle()
        {
            Random random = new Random();
            int left = random.Next(1, 200);
            int top = random.Next(1, 200);
            int right = random.Next(210, 400);
            int bottom = random.Next(210, 400);

            return new Rectangle(left, top, right, bottom);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Rectangle rectangle = CreateRectangle();
            rectangles.Add(rectangle);

            Form1_Paint(null, null);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
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
