using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKAssignment2
{
    public static class TriangleSolver
    {

        public static string Analyze(int u1, int u2, int u3)
        {
            int u1u2 = u1 + u2;
            int u1u3 = u1 + u3;
            int u2u3 = u2 + u3;
            string result = "";
            if (u1u2 > u3 && u1u3 > u2 && u2u3 > u1 )
            {
                if (u1 != u2 && u2 != u3 && u1 != u3)
                {
                    result = "These numbers form Scalene Triangle";
                }
                else if (u1 == u2 || u2 == u3 || u3 == u1)
                {
                    result = "These numbers form Isosceles Triangle";
                }
                else if (u1 == u2 && u2 == u3)
                {
                    result = "These numbers form Equilateral Triangle";
                }
            }
            else
            {
                result = "These numbers do not form a triangle";
            }
            
            return result;
        }
    }
}
