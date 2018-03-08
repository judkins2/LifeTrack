using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeTrack
{
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }

        private void butSubmit_Click(object sender, EventArgs e)
        {
            using (HomeTrackEntities context = new HomeTrackEntities())
            {
                Account account = new Account();
                List<Account> accountList = new List<Account>();

                accountList = context.Accounts.ToList();
                var jeff = (from d in context.Accounts
                                         select d).ToList();
                cmbAccount.DataSource = jeff.ToList();
                cmbAccount.DisplayMember = "NickName";

            }
                
        }
    }
}
