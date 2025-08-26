using System;
using System.Collections;
using System.Windows.Forms;

namespace QueueProgramDedal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void DisplayCashierQueue(IEnumerable cashierList)
        {
            listView1.Items.Clear();
            if (cashierList == null) return; 
            foreach (object obj in cashierList)
            {
                listView1.Items.Add(obj.ToString());
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
            }
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}
