using System;

namespace WpfApp.Library.Models
{
    public class Accountant
    {
        public Decimal GrossMargin(Decimal Revenue, Decimal CGOS, Decimal Percent)
        {
            return Revenue / (Percent - CGOS / 100);
        }
    }
}
