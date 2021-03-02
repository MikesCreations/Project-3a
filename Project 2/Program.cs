using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
   
        static void Main(string[] args)
        {
            string response;
            int age;
            int year;
            int number;
            int number2;
            int number3;
            int total;
            double km;
            double km2;
            double km3;
            double kmtotal;
            double tri;
            double tri2;
            double trisq;
            double trisq2;
            double trisum;

            Console.WriteLine("What is your name?");
            response = Console.ReadLine();

            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            year = 2021 - age;
            Console.WriteLine("So "+ response + " you were born in " + year);

            Console.WriteLine("");

            Console.WriteLine("2. Adding");

            Console.WriteLine("Type a number");
            number = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Type a number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a number");
            
            number3 = Convert.ToInt32(Console.ReadLine());
            total = number + number2 + number3;
           
            Console.WriteLine("That adds to " + total);

            Console.WriteLine("");

            Console.WriteLine("3. Average");

            Console.WriteLine("Type a distacne to be averaged");
            km = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type a distacne to be averaged");
            km2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Type a distance to be averaged");
            km3 = Convert.ToDouble(Console.ReadLine());

            kmtotal = km + km2 + km3;

            Console.WriteLine("The average distacne is " + kmtotal /3.0);

            Console.WriteLine("");

            Console.WriteLine("4. Hypotenuse");

            Console.WriteLine("What is the triangles 1st side?");
            tri = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the triangles 2nd side?");
            tri2 = Convert.ToDouble(Console.ReadLine());

            trisq = tri * tri;
            trisq2 = tri2 * tri2;
            trisum = trisq + trisq2;
            Console.WriteLine("The hypotenuse of your triangle is " + Math.Sqrt(trisum));

            Console.WriteLine("Press enter to leave");

            Console.ReadLine();

        }
    }
}
