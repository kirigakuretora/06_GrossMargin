using System;

namespace WpfApp.Library.Models
{
    public class Accountant:WpfApp.Library.Models.Discrimination.NetAndAfterTax
    {
        #region 0.Global Variable
        internal new Boolean IsTrue() { return true; }
        #endregion

        #region 1.Load
        public Decimal GrossMargin(Decimal Revenue, Decimal CGOS, Decimal Percent)
        {
            return Revenue / (Percent - CGOS / 100);
        }
        #endregion
    }
}
