
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Triangleapp
{
    public static class TriangleSolver
    {

        public static void Analyze()
        {

            Console.WriteLine("Enter the First Side Of the triangle");
            int sidea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Second Side Of the triangle");
            int sideb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  third Side Of the triangle");
            int sidec = Convert.ToInt32(Console.ReadLine());

            if (sidea + sideb <= sidec || sidea + sidec <= sideb || sideb + sidec <= sidea)
            {
                Console.WriteLine("it is not a Triangle");
            }
            else if (sidea == sideb && sideb == sidec && sidea == sidec)
                {
                    Console.WriteLine("Equilateral Triangle ");
                }
                  else if (sidea == sideb || sideb == sidec || sidea == sidec)
                  {
                    Console.WriteLine("Issocelas triangle");
                    }
                 else
                {
                    Console.WriteLine("Scalane Triangle ");
                }
                Console.WriteLine(String.Format("Values are {0} {1} {2}", sidea, sideb, sidec));

               }
        }
    }

   

