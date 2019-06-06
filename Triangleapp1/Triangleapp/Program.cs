using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangleapp
{
    class Program
    {


        public static int TriangleMenuSelection()


        {
            string userInputtri = "";
            bool triMenuSelect = false;
            while (triMenuSelect == false)
            {
                Console.WriteLine("1: Enter Triangle Dimensions");
                Console.WriteLine("2: Exit\n");
                Console.WriteLine("Please select Menu Option:");
                userInputtri = Console.ReadLine();
                if (userInputtri != "1" &&
                   userInputtri != "2"
                  )
                {
                    Console.WriteLine("This is not a valid Selection, Please try again:\n");
                }
                else
                {
                    triMenuSelect = true;
                }
                //exit
                if(userInputtri=="2")
                    Environment.Exit(0);
               
            }
            Console.WriteLine();
            return int.Parse(userInputtri);
        }
        public void Inputs()
        {
            TriangleMenuSelection();

            int x = 0;
            string a = string.Empty;
            do
            {
                Console.WriteLine("Enter the First Side Of the triangle");
                a = (Console.ReadLine());

            } while (!(int.TryParse(a, out x) && x > 0));

            int y = 0;
            string b = string.Empty;
            do
            {
                Console.WriteLine("Enter the Second Side Of the triangle");
                b = (Console.ReadLine());

            } while (!(int.TryParse(b, out y) && y > 0));

            int z = 0;
            string c = string.Empty;
            do
            {
                Console.WriteLine("Enter the Third Side Of the triangle");
                c = (Console.ReadLine());

            } while (!(int.TryParse(c, out z) && z > 0));

            Console.WriteLine(TriangleSolver.Analyze(x, y, z));
            Inputs();
        }

        public static void Main(string[] args)

      {
            Program p = new Program();
            p.Inputs();
          
            Console.ReadLine();
           
            string respo = string.Empty;
            do
            {
                int userInputtri = 0;
                do
                {
                    userInputtri = TriangleMenuSelection();
                } while (userInputtri != 1);
                respo = Console.ReadLine();
            if (!String.IsNullOrEmpty(respo))
                respo = respo.ToUpper();
        } while (respo.Length == 0 || respo.Length > 1 || respo.ToUpper() == "Y");
          
        }
    }
}

