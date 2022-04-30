using EmployeesManager.Models;
using EmployeesManager.Repository;
using EmployeesManager.Services;
using System;
using System.Windows.Forms;

namespace EmployeesManagerForm
{
    public partial class EmployeeDetails : Form
    {
        EmployeesService _employeesService;
        DepartmentsService _departmentsService;
        PositionsService _positionsService;
        KPIService _KPIService;
        private Employee _employee;
        public EmployeeDetails(Employee employee, DatabaseContext context)
        {
            _employeesService = new EmployeesService(context);
            _departmentsService = new DepartmentsService(context);
            _positionsService = new PositionsService(context);
            _KPIService = new KPIService(context);
            _employee = employee;
            InitializeComponent();

        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            name.Text = _employee.Name;
            lastName.Text = _employee.LastName;
            middleName.Text = _employee.MiddleName;
            Phone.Text = _employee.PhoneNumber;
            Adress.Text = _employee.Address;
            comboBox2.Text = _employee.Department.Name;
            comboBox3.Text = _employee.Position.Name;
            sallary.Text = _employee.Salary.ToString();
            comboBox1.Text = _employee.KPI_Ref.KPI;

            var valuesKPI = _KPIService.GetKPIs().ToArray();
            var valuesDepartments = _departmentsService.GetNamesDepartments().ToArray();
            var valuesPositions = _positionsService.GetNamesPositions().ToArray();

            comboBox1.Items.AddRange(valuesKPI);
            comboBox2.Items.AddRange(valuesDepartments);
            comboBox3.Items.AddRange(valuesPositions);
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                var kpi = comboBox1.Text;
                var resSal = Convert.ToDecimal(sallary.Text);
                var department = _departmentsService.CreateIfNotExists(comboBox2.Text);
                var position = _positionsService.CreateIfNotExists(comboBox3.Text);

                _employee.Name = name.Text;
                _employee.LastName = lastName.Text;
                _employee.MiddleName = middleName.Text;
                _employee.PhoneNumber = Phone.Text;
                _employee.Address = Adress.Text;
                _employee.Department = department;
                _employee.Departmant_Id = department.Id;
                _employee.Position = position;
                _employee.Position_Id = position.Id;
                _employee.Salary = resSal;
                _employee.KPI_Ref = _KPIService.GetKPIFromStr(kpi);

                _employeesService.Update(_employee);
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неправильно введены данные!");
            }



            
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var employee_Id = _employee.Id;
            _employee = _employeesService.GetById(employee_Id);
            _employeesService.Delete(_employee);

            this.Close();
            this.Dispose();

        }
    }
}
