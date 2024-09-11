namespace TwoPointsDistance
{
    internal class Point
    {
        double x = 0;
        double y = 0;

        readonly string name;

        Point(double x, double y, string name = "point")
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public override string ToString()
        {
            return name + "\n"
                + "X: " + x + "\n"
                + "Y: " + y + "\n";
        }

        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            Console.Write("First point\n"
                + "X: ");
            bool[] parse1 = new bool[2];
            parse1[0] = Double.TryParse(Console.ReadLine(), out x1);
            Console.Write("Y: ");
            parse1[1] = Double.TryParse(Console.ReadLine(), out y1);
            Console.Write("Second point\n"
                + "X: ");
            bool[] parse2 = new bool[2];
            parse2[0] = Double.TryParse(Console.ReadLine(),out x2);
            Console.Write("Y: ");
            parse2[1] = Double.TryParse(Console.ReadLine(), out y2);

            Console.WriteLine();

            if (parse1[0] && parse1[1] && parse2[0] && parse2[1])
            {
                Point point1 = new Point(x1, y1, "Point 1");
                Console.Write(point1);

                Point point2 = new Point(x2, y2, "Point 2");
                Console.Write(point2);

                double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                Console.WriteLine("\nDistance: " + distance);
            }
        }
    }
}