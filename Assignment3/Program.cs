namespace Assignment3
{
    internal class Program
    {
        class Rectangle
        {
            protected double length;
            protected double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }

            public bool isLegal()
            {
                if (length > 0 && width > 0)
                    Console.WriteLine("This rectangle is legal.");
                else
                    Console.WriteLine("This rectangle is illegal.");
                return length > 0 && width > 0;
            }

            public double Area()
            {
                if (isLegal())
                    Console.WriteLine("The area of this rectangle is " + length * width);
                else
                    Console.WriteLine("This rectangle is illegal with no area!");
                return length * width;
            }
        }

        class Square : Rectangle
        {
            public Square(double side) : base(side, side) { }

            public bool isLegal()
            {
                if (length > 0 && width > 0)
                    Console.WriteLine("This square is legal.");
                else
                    Console.WriteLine("This square is illegal.");
                return length > 0 && width > 0;
            }

            public double Area()
            {
                if (isLegal())
                    Console.WriteLine("The area of this square is " + length * width);
                else
                    Console.WriteLine("This square is illegal with no area!");
                return length * width;
            }
        }

        class Triangle
        {
            private double len1;
            private double len2;
            private double len3;

            public Triangle(double len1, double len2, double len3)
            {
                this.len1 = len1;
                this.len2 = len2;
                this.len3 = len3;
            }

            public bool isLegal()
            {
                if (len1 + len2 > len3 && len2 + len3 > len1 && len1 + len3 > len2)
                    Console.WriteLine("This triangle is legal");
                else
                    Console.WriteLine("This triangle is illegal");
                return len1 + len2 > len3 && len2 + len3 > len1 && len1 + len3 > len2;
            }

            public double Area()
            {
                double p = (len1 + len2 + len3) / 2;
                double s = Math.Sqrt(p * (p - len1) * (p - len2) * (p - len3));
                if (isLegal())
                    Console.WriteLine("The area of this triangle is " + s);
                else
                    Console.WriteLine("This triangle is illegal with no area!");
                return s;
            }
        }

        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(2, 4);
            rec.Area();

            Triangle tri = new Triangle(1, 1.732, 2);
            tri.Area();

            Square sq = new Square(2);
            sq.Area();
        }
    }
}
