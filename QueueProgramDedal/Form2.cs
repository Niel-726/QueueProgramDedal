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
            if (cashierList == null) return; // guard if queue not initialized yet
            foreach (object obj in cashierList)
            {
                listView1.Items.Add(obj.ToString());
            }
            UpdateForm3NowServing();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            EnsureForm3Open();
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
            }
            EnsureForm3Open();
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void UpdateForm3NowServing()
        {
            var display = Application.OpenForms["Form3"] as Form3;
            if (display != null && !display.IsDisposed)
            {
                display.UpdateNowServingFromQueue();
            }
        }

        private void EnsureForm3Open()
        {
            var display = Application.OpenForms["Form3"] as Form3;
            if (display == null || display.IsDisposed)
            {
                display = new Form3();
                display.Show();
            }
            else
            {
                if (display.WindowState == FormWindowState.Minimized)
                    display.WindowState = FormWindowState.Normal;
                display.Activate();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            EnsureForm3Open();
            UpdateForm3NowServing();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            EnsureForm3Open();
            UpdateForm3NowServing();
        }
    }
}
