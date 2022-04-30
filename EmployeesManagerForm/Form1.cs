using EmployeesManager.Repository;
using EmployeesManager.Services;
using EmployeesManager.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesManagerForm
{
    public partial class Form1 : Form
    {
        List<EmployeesInfo> _employeesInfo;
        EmployeesService _employeesService;
        DepartmentsService _departmentsService;
        PositionsService _positionsService;
        KPIService _kPIService;
        DatabaseContext context = new DatabaseContext();
        int _selectedRow;
        public Form1()
        {
            _kPIService = new KPIService(context);
            InitializeComponent();
            _employeesService = new EmployeesService(context);
            _departmentsService = new DepartmentsService(context);
            _positionsService = new PositionsService(context);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _employeesInfo = _employeesService.GetEmployeesInfo();

            dataGridView1.DataSource = _employeesInfo;
            this.dataGridView1.Columns["Id"].Visible = false;
            dataGridView2.DataSource = _departmentsService.GetDepartments();
            dataGridView3.DataSource = _positionsService.GetPositions();
            var valuesDepartments = _departmentsService.GetNamesDepartments().ToArray();
            comboBoxDep.Items.Clear();
            comboBox1.Items.Clear();
            comboBoxDep.Items.AddRange(valuesDepartments);
            comboBox1.Items.AddRange(valuesDepartments);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewEmployee addNewEmployee = new AddNewEmployee(context);
            addNewEmployee.Show();
        }



        private void deleteDepartment_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                var id = Convert.ToInt32(label11.Text);
                var department = _departmentsService.GetDepartmentById(id);
                if (_departmentsService.IsContentEmployees(id))
                {
                    MessageBox.Show("Невозможно удалить, имеет сотрудников!", "Error");
                    return;
                }
                _departmentsService.Delete(department);
                this.Form1_Load(sender, e);
            }
        }
        private void deletePosition_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                var id = Convert.ToInt32(label13.Text);
                var position = _positionsService.GetPositionById(id);
                if (_positionsService.IsContentEmployees(id))
                {
                    MessageBox.Show("Невозможно удалить, имеет сотрудников!", "Error");
                    return;
                }
                _positionsService.Delete(position);
                this.Form1_Load(sender, e);
            }
        }
        private void updateDepartment_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                var id = Convert.ToInt32(label11.Text);
                var department = _departmentsService.GetDepartmentById(id);
                department.Name = textBox1.Text;
                _departmentsService.Update(department);
                this.Form1_Load(sender, e);
            }
        }        
        private void updatePosition_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                var id = Convert.ToInt32(label13.Text);
                var position = _positionsService.GetPositionById(id);
                position.Name = textBox2.Text;
                _positionsService.Update(position);
                this.Form1_Load(sender, e);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[_selectedRow];
                var id = row.Cells[0].Value;

                var employee = _employeesService.GetById((int)id);
                EmployeeDetails employeeDesc = new EmployeeDetails(employee, context);
                employeeDesc.Show();
            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[_selectedRow];

                label11.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();

            }

        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[_selectedRow];

                label13.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();

            }
        }

        private void AddDepartment_Click(object sender, EventArgs e)
        {
            AddDepartmant addDepartmant = new AddDepartmant(context);
            addDepartmant.Show();
        }

        private void AddPosition_Click(object sender, EventArgs e)
        {
            AddPosition addPosition = new AddPosition(context);
            addPosition.Show();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            this.Form1_Load(sender, e);
        }

        private void comboBoxDep_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var field = comboBoxDep.SelectedItem.ToString();
            dataGridView1.DataSource = _employeesInfo.Where(em => em.Department.Equals(field)).ToList();
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var field = comboBox1.SelectedItem.ToString();
            if(!_departmentsService.DepartmentExists(field))
            {
                MessageBox.Show("Отдел не найден", "Error");
            }
            var depart = _departmentsService.GetDepartmentByName(field);
            if(depart.Employees == null)
            {
                label18.Text = "0";
                return;
            }
            label18.Text = _employeesService.GetSumSallaryByList(depart.Employees).ToString();
        }
        private void GetSum_Click(object sender, EventArgs e)
        {
            label16.Text = _employeesService.GetSumSallary().ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "(*.txt)|*.txt";
            
            saveFile.DefaultExt = ".txt";
            saveFile.FileName = $"report_{DateTime.Now.Year}_{DateTime.Now.Month}_{DateTime.Now.Day}.txt";
            
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                FileWriter fileWriter = new FileWriter(saveFile.FileName);
                fileWriter.FileWrite(_employeesInfo);

            }

                string fileName = System.IO.Path.GetFileName(saveFileDialog1.FileName);
        }
    }
}
