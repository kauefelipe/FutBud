namespace FutBud.Services
{
    internal static class RoundPrices
    {
        public static uint RoundToFinal(uint pricecalc)
        {
            uint finalprice = 0;

            if (pricecalc <= 1000)
            {
                finalprice = RoundToNearest(pricecalc, 50);
            }
            if (pricecalc > 1000 && pricecalc <= 10000)
            {
                finalprice = RoundToNearest(pricecalc, 100);
            }
            if (pricecalc > 10000 && pricecalc <= 50000)
            {
                finalprice = RoundToNearest(pricecalc, 250);
            }
            if (pricecalc > 50000 && pricecalc <= 100000)
            {
                finalprice = RoundToNearest(pricecalc, 500);
            }
            if (pricecalc > 100000)
            {
                finalprice = RoundToNearest(pricecalc, 1000);
            }

            return finalprice;
        } //round the price
        public static uint RoundToNearest(uint Amount, uint RoundTo)   //round the price
        {
            uint ExcessAmount = Amount % RoundTo;
            if (ExcessAmount < (RoundTo / 2))
            {
                Amount -= ExcessAmount;
            }
            else
            {
                Amount += (RoundTo - ExcessAmount);
            }
            return Amount;
        }
    }
}
