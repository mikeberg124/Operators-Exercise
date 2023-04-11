using System;
namespace OperatorExercise
{
	public class Circle
	{
		public static double AreaOfCircle()
		{

            Console.WriteLine("Please enter the radius of your circle:");
            var radius = double.Parse(Console.ReadLine());

            var area = (Math.PI + radius + radius);
            return area;

        }
	}
}

