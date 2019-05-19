using System;
using System.Collections.Generic;

namespace WpfApp.Library.Models
{
    public class Accountant
    {
        public Decimal GrossMargin(Decimal Revenue, Decimal CGOS, Decimal Percent)
        {
            return Math.Round(Revenue / (Percent - CGOS / 100),MidpointRounding.AwayFromZero) ;
        }    
    }
}
