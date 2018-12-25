using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckTriangle
{
    public static class CheckTriangle
    {
        public static bool CheckingTriangle(int a, int b, int c)
        {
            bool k = false;
            CheckSides(a, b, c);

            if((a < b + c) && (b < a + c) && (c < a + b))
            {
                k = true;
                return k;
            }

            else
            {
                return k;
            }
        }

        private static void CheckSides(int a, int b, int c)
        {
            if (a <= 0) 
            {
                throw new ArgumentException($"The value of parameter{nameof(a)} can't be zero and less");
            }

            if (b <= 0)
            {
                throw new ArgumentException($"The value of parameter{nameof(b)} can't be zero and less");
            }

            if (c <= 0)
            {
                throw new ArgumentException($"The value of parameter{nameof(c)} can't be zero and less");
            }
        }
    }
}
