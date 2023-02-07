namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindType("Salam");


            DoSwapValue<int>(10, 15);
        }




        public static void FindType<T>(T type)
        {
            Console.WriteLine(type);
        }




        public static void DoSwapValue<T>(T v1, T v2)
        {
            T v = default;
            T temporary = v;
            v = v1;
            v1 = v2;
            v2 = v;
            Console.WriteLine($"{v1} {v2}");
        }
    }
}
