using System;
using System.Windows.Forms;

namespace QueueProgramDedal
{
    public partial class Form1 : Form
    {
        private CashierClass cashier;

        public Form1()
        {
            InitializeComponent();
            cashier = new CashierClass();
            label2.Text = "P - 10000";
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            label2.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = label2.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            
            var existing = Application.OpenForms["Form2"] as Form2;
            if (existing == null || existing.IsDisposed)
            {
                existing = new Form2();
                existing.Show();
            }
            else
            {
                if (existing.WindowState == FormWindowState.Minimized)
                    existing.WindowState = FormWindowState.Normal;
                existing.Activate();
            }
        }
    }
}
