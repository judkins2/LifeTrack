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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (HomeTrackEntities context = new HomeTrackEntities())
            {
                //context.Accounts.Add(new Account { NickName = "todd", Type = "TYPE" });
                //context.SaveChanges();
                //Account account = context.Accounts.FirstOrDefault(r => r.Id == 2);
                //MessageBox.Show(account.NickName);
                //List<Account> AccountList = new List<Account>();
                //AccountList = context.Accounts.ToList();
                //string j= string.Empty;
                //foreach (var item in AccountList)
                //{
                //    j = j + item.NickName + "\n";
                //}
                //MessageBox.Show(j);

                context.Accounts.Add(new Account { NickName = txtNickname.Text, Type = (string)cmbType.SelectedItem, StartingBalance = Convert.ToDecimal(txtStartingBalance.Text) });
                context.SaveChanges();
            }



        }
    }

  
}
