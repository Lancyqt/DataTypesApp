namespace DataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the pieces of apple: ");
            int apple;
            apple = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + apple + " apples: ");
            double apple_price;
            apple_price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total price of apple(s) " + apple_price );
            Console.WriteLine("The value of original price is " + apple_price);
            Console.WriteLine("The value of converted price is " + (int) apple_price);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}