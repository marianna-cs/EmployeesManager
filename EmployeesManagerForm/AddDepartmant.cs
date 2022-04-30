using EmployeesManager.Models;
using EmployeesManager.Repository;
using EmployeesManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesManagerForm
{
    public partial class AddDepartmant : Form
    {
        DepartmentsService _departmentsService;
        public AddDepartmant(DatabaseContext context)
        {
            _departmentsService = new DepartmentsService(context);
            InitializeComponent();
        }

        private void AddDepartment_Click(object sender, EventArgs e)
        {
            Department department = new Department()
            {
                Name = textBox1.Text
            };
            _departmentsService.Create(department);
            this.Close();
            this.Dispose();
        }
    }
}
