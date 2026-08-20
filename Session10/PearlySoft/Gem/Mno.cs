using System;
using System.Collections.Generic;
using System.Text;

namespace Gem
{
    public class Mno
    {
        // 3. Generic Methods
        public void Print<T>(T value)
        {
            Console.WriteLine(value);
        }

        public Mno()
        {
            double x = 14.75;
            Print(x);

            decimal y = 27.3m;
            Print(y);

            int z = 8;
            Print(z);

            RawMaterial rawMaterial1 = new RawMaterial();
            rawMaterial1.Id = 20;
            rawMaterial1.Name = "Flour";
            rawMaterial1.ExpiryDate = new DateTime(2026, 12, 20);

            Print(rawMaterial1);
        }
    }
}