using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab4_GUIShapes
{
    public partial class Form1 : Form
    {
        private ArrayList shapes = new ArrayList();
        Random random = new Random();

        private Rectangle CreateRectangle()
        {
            int left = random.Next(1, 200);
            int top = random.Next(1, 200);
            int right = random.Next(210, 250);
            int bottom = random.Next(210, 250);

            return new Rectangle(left, top, right, bottom);
        }

        private Square CreateSquare()
        {
            int left = random.Next(1, 200);
            int top = random.Next(200, 300);
            int width = random.Next(50, 150);
            return new Square(left, top, width, Brushes.DarkSlateBlue);
        }

        private Circle CreateCircle()
        {
            int centerX = random.Next(50, 350);
            int centerY = random.Next(50, 350);
            float radius = (float)random.Next(20, 150);
            return new Circle(new Point(centerX, centerY), radius);
        }

        private Triangle CreateTriangle()
        {
            int top = random.Next(50, 350);
            int HalfWidth = random.Next(25, 50);
            int height = random.Next(50,100);
            return new Triangle(new Point(top, top),
                new Point(top - HalfWidth, top + height), 
                new Point(top + HalfWidth, top + height));
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = CreateRectangle();
            shapes.Add(rectangle);
            Form1_Paint(null, null);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = this.CreateGraphics())
            {
                foreach (Shape shape in shapes)
                {
                    shape.Show(g);
                }
            }
        }

        private void square_Click(object sender, EventArgs e)
        {
            Square square = CreateSquare();
            shapes.Add(square);
            Form1_Paint(null, null);

        }

        private void circle_Click(object sender, EventArgs e)
        {
            Circle circle = CreateCircle();
            shapes.Add(circle);
            Form1_Paint(null, null);
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            Triangle triangle = CreateTriangle();
            shapes.Add(triangle);
            Form1_Paint(null, null);
        }
    }
}
