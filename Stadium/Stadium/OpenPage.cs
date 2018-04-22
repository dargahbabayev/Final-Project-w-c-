using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stadium.Model;

namespace Stadium
{
    public partial class OpenPage : Form
    {
        StadiumEntities db = new StadiumEntities();
    
        int ClickId =0;
        int ClickedRowIndex =0;

        public OpenPage()
        {
            InitializeComponent();
            FillDgv();
        }
        public void FillDgv()
        {
            dgvReserves.Rows.Clear();
            foreach (var item in db.Reserves.ToList())
            {                
                dgvReserves.Rows.Add(
                    item.İd,
                    item.Date.Value.ToString("dd.MM.yyyy"),
                    item.StartTime.Value.ToString(@"hh\:mm"),
                    item.EndTime.Value.ToString(@"hh\:mm"),
                    item.Price,
                    item.Customers.Fullname,
                    item.Stadiums.Name

                );
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer(this);
            ac.ShowDialog();
        }

        private void dgvReserves_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnNewOrder.Visible = false;
            btnDelete.Visible = true;
            btnCancel.Visible = true;

            ClickId = Convert.ToInt32(dgvReserves.Rows[e.RowIndex].Cells[0].Value.ToString());
            ClickedRowIndex = e.RowIndex;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
           
            DialogResult r = MessageBox.Show("Eminsiniz mi?", "Silme", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK && ClickId!=0)
            {
                dgvReserves.Rows.Remove(dgvReserves.Rows[ClickedRowIndex]);
                Reserves rsv = db.Reserves.Find(ClickId);
                db.Reserves.Remove(rsv);
                db.SaveChanges();
                btnNewOrder.Visible = true;
                btnDelete.Visible = false;
                btnCancel.Visible = false;

            }
            
          

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNewOrder.Visible = true;
            btnDelete.Visible = false;
            btnCancel.Visible = false;
        }
    }
}
