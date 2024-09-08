using System;
using System.Collections.Generic;
using System.Text;

namespace DLL_Tinh
{
    public class Tinh
    {
        public int i, n;
        public int dem { get; private set; }
        public void Uoc()
        {
            dem = 0;
            for (i = 1; i <= n; i++)
            {
                {
                    if (n % i == 0) dem++;
                }
            }
        }
    }
}
