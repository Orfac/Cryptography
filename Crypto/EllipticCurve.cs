using System;
using System.Collections.Generic;
using System.Text;

namespace Crypto
{
    internal class EllipticCurve
    {
        int _a;

        int _b; 

        public EllipticCurve(int a, int b)
        {
            _a = a;
            _b = b;
        }
    }
}
