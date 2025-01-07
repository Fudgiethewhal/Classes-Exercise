namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Jeepy";
            carOne.Model = "Wrangler";
            carOne.Year = 2011;
            
            Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, made in the year {carOne.Year}.");
            
        }
    }
}
