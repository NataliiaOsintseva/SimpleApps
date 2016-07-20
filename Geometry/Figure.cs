using System;


namespace Geometry
{
    class Figure
    {
        //private double x, y;
        private string name;
        Point[] points;

        public string Name {
            get { return name; }
        }

        private double LengthSide(Point a, Point b) {

            // double d1 = Convert.ToDouble(a.X - b.X);
            // double d2 = Convert.ToDouble(a.Y - b.Y);

            return Math.Sqrt( Math.Pow(Convert.ToDouble(a.X - b.X), 2) + Math.Pow(Convert.ToDouble(a.Y - b.Y), 2));
        }

        public void PerimeterCalculator() {

            double sum = 0;

            for (int i=0; i < points.Length - 1; i++) {
                sum =+ LengthSide(points[i], points[i+1]);
            }

            sum = +LengthSide(points[0], points[points.Length - 1]);
            Console.WriteLine(sum);

        }

        public Figure(Point a, Point b, Point c) {
            points = new Point[3];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            name = "Triangle";
        }

        public Figure(Point a, Point b, Point c, Point d) {
            points = new Point[4];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
            name = "4-angle";
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) {
            points = new Point[5];
            points[0] = a;
            points[1] = b;
            points[2] = c;
            points[3] = d;
            points[4] = e;
            name = "5-something-angle";
        }


    }
}
