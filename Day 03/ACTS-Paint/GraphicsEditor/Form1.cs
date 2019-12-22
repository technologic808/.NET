using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditor
{

    public partial class Form1 : Form
    {

        // Add data members 

        // Declares Two Points to create basic shapes
        private Point StartPoint;
        private Point EndPoint;
        private Point InitiationPoint;

        // Declares color to store color of drawing
        private Color ShapeColor = Color.Black;

        // Declares a rectangle object to use in creation of basic shapes
        private Rectangle Rectangle;

        // Declares pen to draw graphics
        private Pen Pen;

        // Declares graphics to be able to draw graphics
        private Graphics Graphics;

        // Declares variable to store the selected shape 
        private String ShapeString;

        // Declares variable to store pen size
        private int PenSize = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnPenColor(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                ShapeColor = dlg.Color;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            // Sets endpoint 
            this.EndPoint = new Point(e.X, e.Y);

            // Creates graphics
            Graphics = this.CreateGraphics();

            // Create pen object
            Pen = new Pen(ShapeColor, PenSize);


            // Sets Initiation Point of the rectangle based on the points selected
            // Between the two points selected, the Initiation point will have the lesser of the given coordinates
            InitiationPoint.X = (StartPoint.X < EndPoint.X) ? StartPoint.X : EndPoint.X;
            InitiationPoint.Y  = (StartPoint.Y < EndPoint.Y) ? StartPoint.Y : EndPoint.Y;


            int width = Math.Abs(EndPoint.X - StartPoint.X);
            int height = Math.Abs(EndPoint.Y - StartPoint.Y);

            Rectangle = new Rectangle(InitiationPoint.X, InitiationPoint.Y, width, height);
            switch (ShapeString)
            {
                case "Line":
                    Graphics.DrawLine(Pen, StartPoint, EndPoint);
                    break;
                case "Rectangle":
                    Graphics.DrawRectangle(Pen, Rectangle);
                    break;
                case "Ellipse":
                    Graphics.DrawEllipse(Pen, Rectangle);
                    break;

                default:
                    break;
            }

        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            this.StartPoint = new Point(e.X, e.Y);
        }

        private void OnClickRectangle(object sender, EventArgs e)
        {
            ShapeString = sender.ToString();
        }

        private void OnClickLine(object sender, EventArgs e)
        {
            ShapeString = sender.ToString();
        }

        private void OnClickEllipse(object sender, EventArgs e)
        {
            ShapeString = sender.ToString();
        }

        private void OnClickSize(object sender, EventArgs e)
        {
            NumericUpDown dlg = new NumericUpDown();

            PenSize = (int)dlg.Value;
        }

        private void OnPenSizeChange(object sender, EventArgs e)
        {
            NumericUpDown dlg = (NumericUpDown)sender;
            Console.WriteLine(dlg.Value);

            PenSize = (int)dlg.Value;
        }
    }
}
