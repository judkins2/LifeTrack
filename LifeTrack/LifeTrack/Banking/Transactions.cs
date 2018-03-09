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
            int id;
            using (HomeTrackEntities context = new HomeTrackEntities())
            {
                Category cat = (new Category { Name = cmbCategory.Text });
                 context.Categories.Add(cat);
               
                context.SaveChanges();
                id = cat.Id;
            }

            MessageBox.Show(cmbAccount.Text + " " + cmbAccount.SelectedValue + " " + cmbCategory.Text + " " + cmbCategory.SelectedValue);
            string amount = txtAmount.Text;
            string payee = txtPayee.Text;
            int categoryId = id;
            bool reconciled = chkReconciled.Checked;
            string date = monthCalendar1.SelectionRange.Start.ToShortDateString();
            string checkNumber = txtCheckNumber.Text;
            string memo = txtMemo.Text;


            MessageBox.Show(amount + " " + payee + " " + categoryId + " " + reconciled + " " + date + " " + checkNumber + " " + memo);




        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            LifeTrackDataAccess ltda = new LifeTrackDataAccess();

            cmbAccount.DataSource = ltda.GetAccounts();
            cmbAccount.DisplayMember = "NickName";
            cmbAccount.ValueMember = "Id";

            cmbCategory.DataSource = ltda.GetCategories();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
