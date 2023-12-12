using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBillingSystem
{
    public partial class Bkash : Form
    {
        private object textBox_SPLP_SUserId;
        private object textBox_SPLP_SUserDueBalanceAmount;
        private object button_SPLP_SUserOK;
        private object button_SPLP_SUserSetDB;
        private object button_SPLP_SUserCancel;
        private object button_SPLP_SUserSet;
        private object label_SPLP_SUserDueBalanceAmount;

        public Bkash()
        {
            InitializeComponent();
        }

        private void Bkash_Load(object sender, EventArgs e)
        {

        }

        private void BKashAmountbttn_Click(object sender, EventArgs e)
        {
         
        }
    }

}
