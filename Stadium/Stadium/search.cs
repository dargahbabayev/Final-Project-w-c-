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
    public partial class search : Form
    {
        StadiumEntities db = new StadiumEntities();
        public search()
        {
            InitializeComponent();
            FillStadiums();
            dgvSearch.Rows.Clear();
        }

        private void FillStadiums()
        {
            List<Stadiums> staList = db.Stadiums.ToList();
            foreach (var item in staList)
            {
                cmbStadiums.Items.Add(item.Name);
            }
        }
        private int FindIdBYName(string name)
        {
            int StaId = db.Stadiums.FirstOrDefault(s => s.Name == cmbStadiums.Text).Id;
            return StaId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
         
            DateTime day = dtpDate.Value.Date;
            int staId = FindIdBYName(cmbStadium.Text);
            List<Reserves> res = db.Reserves.Where(r => r.Date == day && r.SatdiumId == staId).ToList();
            dgvSearch.DataSource = res.Select(s => new
            {
                s.Stadiums.Name,
                s.Date,
                s.StartTime,
                s.EndTime
            }).ToList();
            cmbStadium.Text = string.Empty;
          

        }
    }
}
