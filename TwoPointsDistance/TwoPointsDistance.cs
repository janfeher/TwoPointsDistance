namespace TwoPointsDistance
{
    internal class Point
    {
        double x, y;

        readonly string name;

        Point(double x, double y, string name = "point")
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public override string ToString() // informace o souřadnicích bodů
        {
            return name + "\n"
                + "X: " + x + "\n"
                + "Y: " + y + "\n";
        }

        static void Main(string[] args)
        {
            double x1, y1, x2, y2;

            /* pro každý bod jsem vytvořil pole, které na index 0 uloží true,
             * pokud se podařilo převést x na double a na index 1 to samé pro y */
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

            // obě souřadnice pro oba body jsou přeložené
            if (parse1[0] && parse1[1] && parse2[0] && parse2[1])
            {
                Point point1 = new Point(x1, y1, "Point 1");
                Console.Write(point1);

                Point point2 = new Point(x2, y2, "Point 2");
                Console.Write(point2);

                double distance = Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2));
                Console.WriteLine("\nDistance: " + distance);
            }
        }
    }
}