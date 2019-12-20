using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public abstract class Shape
    {
        public abstract void draw();
    }

    public class Line : Shape
    {

        public override string ToString()
        {
            return "[start, end] : [" + _startPoint + "," + EndPoint + "]";
        }

        private Point _startPoint, _endPoint;

        public Line()
        {

        }

        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Point EndPoint
        {
            get
            {
                return _endPoint;
            }

            set
            {
                _endPoint = value;
            }
        }

        public Point StartPoint
        {
            get
            {
                return _startPoint;
            }

            set
            {
                _startPoint = value;
            }
        }

        public override void draw()
        {
            Console.WriteLine("This is a line.");
        }
        
    }

    public class Rectangle : Shape
    {

        public Rectangle()
        {

        }

        public Rectangle(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        private Point _startPoint, _endPoint;

        public override string ToString()
        {
            return "[start, end] : [" + _startPoint + "," + EndPoint + "]";
        }

        public Point EndPoint
        {
            get
            {
                return _endPoint;
            }

            set
            {
                _endPoint = value;
            }
        }

        public Point StartPoint
        {
            get
            {
                return _startPoint;
            }

            set
            {
                _startPoint = value;
            }
        }

        public override void draw()
        {
            Console.WriteLine("This is a rectangle.");
        }

    }

    public class Point {
        private double _x, _y;

        public double X
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
            }
        }

        public double Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
            }
        }

        public Point()
        {

        }

        public Point(double x, double y)
        {
            _x = x;
            Y = y;
        }
        public override string ToString()
        {
            return "(x, y) : (" + _x + "," + Y + ")";
        }
    }
    
}
