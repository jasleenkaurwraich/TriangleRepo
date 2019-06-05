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
     
//
        public static void Main(string[] args)
        {
            string respo = string.Empty;
            do
            {
                int userInputtri = 0;
                do
                {
                    userInputtri = TriangleMenuSelection();
                } while (userInputtri != 1);

                TriangleSolver.Analyze();
           
            respo = Console.ReadLine();
            if (!String.IsNullOrEmpty(respo))
                respo = respo.ToUpper();
        } while (respo.Length == 0 || respo.Length > 1 || respo.ToUpper() == "Y");
        }
    }
}

