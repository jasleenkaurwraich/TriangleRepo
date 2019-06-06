
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Triangleapp
{
    public static class TriangleSolver
    {
        
        public static string Analyze(int sidea, int sideb,int sidec)
         
        {

            string tri =String.Empty;
            if (sidea + sideb <= sidec || sidea + sidec <= sideb || sideb + sidec <= sidea)
            {
                tri = "it is not a Triangle";
            }
            else if (sidea == sideb && sideb == sidec && sidea == sidec)
                {
                  tri=  "Equilateral Triangle";
                }
                  else if (sidea == sideb || sideb == sidec || sidea == sidec)
            { 
                    tri="Isosceles triangle";
                    }
                 else
                {
                  tri="Scalene Triangle";
                }

            return tri;
        }


    }

}

   

