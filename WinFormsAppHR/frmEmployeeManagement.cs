using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EmployeeRepository.Repository;
using EmployeeRepository.Entities;

namespace WinFormsAppHR
{
    public partial class frmEmployeeManagement : Form
    {
        private IRepoEmployee repoEmployee;
        private IRepoDepartment repoDepartment;
        private BindingSource source = null;    
        public frmEmployeeManagement()
        {
            InitializeComponent();
            repoEmployee = new RepoEmployee();
            repoDepartment = new RepoDepartment();
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            Department[] departments = repoDepartment.GetDepartments();
            this.cboDepartment.Items.AddRange(departments);
            this.cboDepartment.SelectedIndex = 0;
            _LoadDataToGrid();
        }


        private void _LoadDataToGrid()
        {
            //1. Lay du lieu tu API (Repo)
            var emps = repoEmployee.GetAllEmployees();
            

            try
            {

                source = new BindingSource();
                source.DataSource = emps;




                /*binding data*/
                txtEmployeeId.DataBindings.Clear();
                txtEmployeeName.DataBindings.Clear();
                cboDepartment.SelectedIndex = 0;
                mskSalary.DataBindings.Clear();
                dtDob.DataBindings.Clear();


                txtEmployeeId.DataBindings.Add("text", source, "Id");
                txtEmployeeName.DataBindings.Add("text", source, "Name");
                radFermale.DataBindings.Add("checked", source, "Sex");
                mskSalary.DataBindings.Add("text", source, "Salary");
                dtDob.DataBindings.Add("text", source, "Dob");


                

               



                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = source;

                //var index = dgvEmployees.CurrentRow.Index;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvEmployees.CurrentRow.Index;
            int selectedIndex = (int)dgvEmployees.Rows[index].Cells[5].Value;
            cboDepartment.SelectedIndex = selectedIndex-1;  
        }
    }
}
