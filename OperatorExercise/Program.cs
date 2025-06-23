namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int prod = a * b;
            int diff = a - b;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} * {b} is {prod}");
            Console.WriteLine($"{a} - {b} is {diff}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}\n");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius {radius} is {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)
        {
            
            return Math.PI * Math.Pow(radius, 2);
        }        
    }
}
