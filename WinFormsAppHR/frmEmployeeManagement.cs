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

namespace WinFormsAppHR
{
    public partial class frmEmployeeManagement : Form
    {
        private IRepoEmployee repoEmployee;
        private BindingSource source = null;    
        public frmEmployeeManagement()
        {
            InitializeComponent();
            repoEmployee = new RepoEmployee();
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


                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = source;

            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
