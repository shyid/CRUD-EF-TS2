using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CRUD_EF_TS2
{
    public partial class Form1 : Form
    {
        Customer model1 = new Customer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            this.ActiveControl = textFName;
        }
        void Clear()
        {
            textFName.Text = textLName.Text = textCity.Text = textAddress.Text = "";
            btnSave.Text = "Save";
            btnDel.Enabled = false;
            model1.IDCus = 0;

            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model1.FirstName = textFName.Text.Trim();
            model1.LastName = textLName.Text.Trim();
            model1.City = textCity.Text.Trim();
            model1.Address = textAddress.Text.Trim();
            using (EFDBEntities db = new EFDBEntities())
            {
                if (model1.IDCus == 0) // insert
                    db.Customers.Add(model1);
                else //update
                    db.Entry(model1).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            MessageBox.Show("Successfully");
            LoadData();
        }
        void LoadData()
        {
            dgcustomer.AutoGenerateColumns = false;//for if col not insert in grid ,dont add, like address 
            using (EFDBEntities db = new EFDBEntities())
            {
                dgcustomer.DataSource = db.Customers.ToList();
            }
        }



        private void dgcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgcustomer.CurrentRow.Index != -1)
            {
                model1.IDCus = Convert.ToInt32(dgcustomer.CurrentRow.Cells["dgCustomerId"].Value);
                using (EFDBEntities db = new EFDBEntities())
                {
                    model1 = db.Customers.Where(x => x.IDCus == model1.IDCus).FirstOrDefault();
                    textFName.Text = model1.FirstName;
                    textLName.Text = model1.LastName;
                    textCity.Text = model1.City;
                    textAddress.Text = model1.Address;
                }
                btnSave.Text = "Update";
                btnDel.Enabled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this Record", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (EFDBEntities db = new EFDBEntities())
                {
                    var entry = db.Entry(model1);
                    if(entry.State == System.Data.Entity.EntityState.Detached) {
                        db.Customers.Attach(model1);
                        db.Customers.Remove(model1);
                        db.SaveChanges();
                        LoadData();
                        Clear();
                        MessageBox.Show("Deleted Successfully");
                    }
                }

            }
        }
    }
}
