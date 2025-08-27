using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueProgramDedal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UpdateNowServingFromQueue();
        }

        
        public void SetNowServing(string number)
        {
            label2.Text = string.IsNullOrWhiteSpace(number) ? "" : number;
        }

        
        public void UpdateNowServingFromQueue()
        {
            string first = (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
                ? CashierClass.CashierQueue.Peek()
                : string.Empty;
            SetNowServing(first);
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            
            UpdateNowServingFromQueue();
        }
    }
}
