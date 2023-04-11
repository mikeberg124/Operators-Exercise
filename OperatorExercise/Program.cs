namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            double answer = Circle.AreaOfCircle();
            Console.WriteLine($" The area of your circle is: {answer}");

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine(a + " / " + b + "is" + quotient + " remainder " + remainder);

             
        }

        

    }




}



