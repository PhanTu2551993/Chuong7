namespace _7._13
{
    interface IPoint
    {
        // Property signatures:
        int X { get; set; }
        int Y { get; set; }
    }

    class MyPoint : IPoint
    {
        // Fields:
        private int myX;
        private int myY;

        // Constructor:
        public MyPoint(int x, int y)
        {
            myX = x;
            myY = y;
        }

        // Property implementation:
        public int X
        {
            get { return myX; }
            set { myX = value; }
        }
        public int Y
        {
            get { return myY; }
            set { myY = value; }
        }
    }

    class MainClass
    {
        private static void PrintPoint(IPoint p)
        {
            Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        }

        public static void Main()
        {
            MyPoint p = new MyPoint(2, 3);
            Console.Write("My Point: ");
            PrintPoint(p);

            // IPoint p2 = new IPoint(); // Lỗi: Interface không thể khởi tạo đối tượng

            // Thay vì tạo đối tượng từ interface, tạo từ lớp triển khai interface
            IPoint p2 = new MyPoint(5, 7);
            PrintPoint(p2);
        }
    }
}

