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
            //txtEmployeeId.ReadOnly = true;
            MyDatabaseEntities myDatabaseEntities = new MyDatabaseEntities();
            dgvData.DataSource = myDatabaseEntities.Employees.Select(x => new { x.EmployeeId, x.EmployeeName, x.Country.CountryId, x.Country.CountryName}).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MyDatabaseEntities myDatabaseEntities = new MyDatabaseEntities();

            Employee employee = new Employee();
            employee.EmployeeName = txtEmployeeName.Text;
            employee.CountryId = Convert.ToInt32(txtCountryId.Text);

            if (string.IsNullOrEmpty(txtEmployeeId.Text))
            {
                myDatabaseEntities.Employees.Add(employee);
            }
            else
            {
                employee.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
                myDatabaseEntities.Employees.Attach(employee);
            }

            myDatabaseEntities.SaveChanges();
            dgvData.DataSource = myDatabaseEntities.Employees.Select(x => new { x.EmployeeId, x.EmployeeName, x.Country.CountryId, x.Country.CountryName }).ToList();

            setEmpty();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvData.CurrentRow.Selected = true;
                txtEmployeeId.Text = dgvData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtEmployeeName.Text = dgvData.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCountryId.Text = dgvData.Rows[e.RowIndex].Cells[2].Value.ToString();
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
            txtEmployeeId.Text = null;
            txtEmployeeName.Text = null;
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
