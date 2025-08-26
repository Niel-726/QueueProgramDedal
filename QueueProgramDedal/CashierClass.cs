using System.Collections.Generic;

namespace QueueProgramDedal
{
    public class CashierClass
    {
        private int x;
        public static string getNumberInQueue = string.Empty;
        public static Queue<string> CashierQueue;

        public CashierClass()
        {
            x = 10000;
            if (CashierQueue == null)
            {
                CashierQueue = new Queue<string>();
            }
        }

        public string CashierGeneratedNumber(string cashierNumber)
        {
            x++;
            cashierNumber = cashierNumber + x.ToString();
            return cashierNumber;
        }
    }
}