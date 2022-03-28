using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEntityCrud
{
    public partial class frmMyApp : Form
    {
        public frmMyApp()
        {
            InitializeComponent();
        }

        private void frmMyApp_Load(object sender, EventArgs e)
        {
            txtCountryId.ReadOnly = true;
            MyDatabaseEntities myDatabaseEntities = new MyDatabaseEntities();
            dgvData.DataSource = myDatabaseEntities.Countries.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities myDatabaseEntities = new MyDatabaseEntities();

            Country country = new Country();
            country.CountryName = txtCountryName.Text;

            if (string.IsNullOrEmpty(txtCountryId.Text))
            {
                myDatabaseEntities.Countries.Add(country);
            }
            else
            {
                country.CountryId = Convert.ToInt32(txtCountryId.Text);
                myDatabaseEntities.Countries.Attach(country);
            }

            myDatabaseEntities.SaveChanges();
            dgvData.DataSource = myDatabaseEntities.Countries.ToList();

            setEmpty();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvData.CurrentRow.Selected = true;
                txtCountryId.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCountryName.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEmpty();
        }

        public void setEmpty()
        {
            txtCountryId.Text = null;
            txtCountryName.Text = null;
            txtSearch.Text = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                MyDatabaseEntities myDatabaseEntities = new MyDatabaseEntities();
                dgvData.DataSource = myDatabaseEntities.Countries.Where(x => x.CountryName.Contains(txtSearch.Text)).ToList();
            }
        }
    }
}
