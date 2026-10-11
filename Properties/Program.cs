namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //עבודה מהווב
            Rectangle rec = new Rectangle(4, 5,"Rectangle");
            Square sq = new Square(4);
            Console.WriteLine( sq.Area());


            Shape[] shapes = new Shape[4];
            Circle cir = new Circle(3);
            shapes[0] = rec;
            shapes[1] = sq;
            shapes[2] = cir;
            shapes[3] = new Rectangle(6, 2,"Tusik");
            foreach(Shape s in shapes)
            {
                if (s!=null)
                {
                    Console.WriteLine(s.Name);
                    Console.WriteLine(s.Area());
                    //if (s is Circle)
                    //{
                    //    Console.WriteLine(((Circle)s).Radius);
                    //}
                    Circle c = s as Circle;
                    if (c != null)
                    {
                        Console.WriteLine(c.Radius);
                    }
                }
                
                
               

            }
            


            































        }
    }
}
