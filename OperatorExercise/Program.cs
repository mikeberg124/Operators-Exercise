namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            double answer = Circle.AreaOfCircle();
            Console.WriteLine($" The area of your circle is: {answer}");




            var x = 3;
            var y = 10;

            Console.WriteLine(x += y);
            Console.WriteLine(x -= y);
            Console.WriteLine(x *= y);
            Console.WriteLine(x /= y);

            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;

            if (a == 17 && b == 4)

            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine(a + " / " + b + "is" + quotient + " remainder " + remainder);

             
        }

        

    }




}



