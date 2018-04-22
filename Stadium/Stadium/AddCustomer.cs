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
    public partial class AddCustomer : Form
    {
        StadiumEntities db = new StadiumEntities();
        OpenPage pgn;

        public AddCustomer(OpenPage page)
        {
            InitializeComponent();
            FillStadiums();
            FillCustomers();
            this.pgn = page;
        }

    
        private void FillCustomers()
        {
            List<Customers> csmtrList = db.Customers.ToList();
            cmbCustomer.Items.Clear();
            foreach (Customers item in csmtrList)
            {
                cmbCustomer.Items.Add(item.Fullname);
            }
        }

       

        // button 1 ile database 'e Customers table'e elave edir
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            if (txtCustomerNumber.Text != string.Empty || txtCustomerName.Text != string.Empty)
            {
                Customers cstmrs = new Customers()
                {
                    Fullname = txtCustomerName.Text,
                    Number = txtCustomerNumber.Text
                };

                db.Customers.Add(cstmrs);
                db.SaveChanges();
        
                txtCustomerName.Text = string.Empty;
                txtCustomerNumber.Text = string.Empty;

            }
            //else
            //{
            //    lblError.Text = "Boshluq Buraxmayin";
            //    lblError.ForeColor = Color.Red;
            //    return;
            //}
            //lblError.Text = string.Empty;

        }

        private void FillStadiums()
        {
            foreach (Stadiums item in db.Stadiums.ToList())
            {
                cmbStadium.Items.Add(item.Name);
            }
        }


        private int FindStadiumIdByName(string name)
        {
            int StadiumId = Convert.ToInt32(db.Stadiums.FirstOrDefault(s => s.Name == name).Id);
            return StadiumId;
        }
        private int FindCustomerIdByName(string name)
        {
            int CustomerId = Convert.ToInt32(db.Customers.FirstOrDefault(c => c.Fullname == name).Id);
            return CustomerId;
        }

        private void btnAddMatch_Click_1(object sender, EventArgs e)
        {

            Reserves rsv = new Reserves();
            DateTime day = dtpDate.Value.Date;
            int staId = FindStadiumIdByName(cmbStadium.Text);
           DateTime dateNow = DateTime.Now.Date;
            List<Reserves> res = db.Reserves.Where(r=>r.Date==day&&r.SatdiumId== staId).ToList();
            //Kechmish vaxda sifarish etmeyi engellmek ucun
            if (dtpDate.Value < dateNow)
            {
                MessageBox.Show("Gunu duzgun girin");
                return;
            }

            foreach (Reserves item in res)
            {

                if ((item.StartTime.Value.Hours <= dtpStarttime.Value.Hour && item.EndTime.Value.Hours > dtpStarttime.Value.Hour) || 
                    (item.StartTime.Value.Hours < dtpEndtime.Value.Hour && item.EndTime.Value.Hours >= dtpEndtime.Value.Hour)||
                    (item.StartTime.Value.Hours>=dtpStarttime.Value.Hour&&item.StartTime.Value.Hours<dtpEndtime.Value.Hour)||
                    (item.EndTime.Value.Hours>dtpStarttime.Value.Hour&& item.EndTime.Value.Hours<=dtpEndtime.Value.Hour))
                    
                       
                {
                    MessageBox.Show("Bu saatda bos deyil");
                    return;
                }

            }


            if (cmbStadium.Text != string.Empty && cmbCustomer.Text != "")
                {
                //if (dtpStarttime.Text != dtpEndtime.Text && dtpStarttime.Value < dtpEndtime.Value)
                //{

                    int x = 0;
                    TimeSpan starttime = new TimeSpan(dtpStarttime.Value.Hour, 0, 0);
                    TimeSpan endtime = new TimeSpan(dtpEndtime.Value.Hour, 0, 0);
                    int diffTime = dtpEndtime.Value.Hour - dtpStarttime.Value.Hour;

                    for (int i = 0; i < diffTime; i++)
                    {
                        x += 5;
                    }

                    rsv.Price = x;
                    rsv.SatdiumId = FindStadiumIdByName(cmbStadium.Text);
                    rsv.Date = dtpDate.Value;
                    rsv.StartTime = starttime;
                    rsv.EndTime = endtime;
                    rsv.CustomerId = FindCustomerIdByName(cmbCustomer.Text);
                    db.Reserves.Add(rsv);
                    db.SaveChanges();
                    cmbStadium.Text = string.Empty;
                     cmbCustomer.Text = string.Empty;
                }
                else
                {
                    lblError2.Text = "boshluq buraxmayin";
                    lblError2.ForeColor = Color.PaleVioletRed;
                    return;
                }

                lblError2.Text = "";
                lblErrorTimespan.Text = "";
                cmbStadium.Text = "";
           
        }


        private void btnAddCustomer_Click_2(object sender, EventArgs e)
        {
            lblErrorCustomer.Text = string.Empty;
            Customers cstm = new Customers();
            //eyni nomreile qeydiyyatdan kechmenin qarshisin almaq uchun
            List<Customers> cusList = db.Customers.ToList();
            foreach (var item in cusList)
            {
                if (item.Number == txtCustomerNumber.Text)
                {
                    lblErrorNumber.Text = "Bu nömrə artıq qeydiyyatdan keçib";
                    return;
                }
            }

            if (txtCustomerName.Text != string.Empty && txtCustomerNumber.Text != string.Empty)
            {
                cstm.Fullname = txtCustomerName.Text;
                if (!Int32.TryParse(txtCustomerNumber.Text, out int year))
                {
                    lblErrorCustomer.Text = "Reqemi duzgun yazin";
                    return;
                }
                cstm.Number = year.ToString();
                db.Customers.Add(cstm);
                db.SaveChanges();
                txtCustomerName.Text = "";
                txtCustomerNumber.Text = "";
                lblErrorNumber.Text = "";
                cmbCustomer.Text = "";
                FillCustomers();
            }
            else
            {
                lblErrorCustomer.Text = "Boshluq buraxmayin";
                return;
            }
        }

        private void AddCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.pgn.FillDgv();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search src = new search();
            src.ShowDialog();
        }

       
    }
}
