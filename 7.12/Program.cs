namespace _7._12
{
    public interface IDimensions
    {   
        // lỗi trong interface  2 biến width và height phải là properties chứ không phải là fields,
        //long width;
        //long height;
        //Sửa lỗi
        long Width { get; set; }
        long Height { get; set; }
        double Area();
        double Circumference();
        int Side();
    }

    public class Circle : IDimensions
    {
        // Giả sử Width là đường kính của hình tròn
        public long Width { get; set; }
        public long Height
        {
            get => Width; // Height bằng Width vì hình tròn không có chiều cao khác biệt
            set => Width = value; // Thiết lập Width cho giống Height
        }

        public Circle(long diameter)
        {
            Width = diameter;
        }

        public double Area()
        {
            double radius = Width / 2.0;
            return Math.PI * radius * radius;
        }

        public double Circumference()
        {
            double radius = Width / 2.0;
            return 2 * Math.PI * radius;
        }

        public int Side()
        {
            // Hình tròn không có cạnh
            throw new NotImplementedException("Circle does not have sides.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle myCircle = new Circle(10); 

            Console.WriteLine($"Width: {myCircle.Width}");
            Console.WriteLine($"Height: {myCircle.Height}");
            Console.WriteLine($"Area: {myCircle.Area()}");
            Console.WriteLine($"Circumference: {myCircle.Circumference()}");
        }
    }
}
