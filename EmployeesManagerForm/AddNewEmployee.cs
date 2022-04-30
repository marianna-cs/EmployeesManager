using EmployeesManager.Models;
using EmployeesManager.Repository;
using EmployeesManager.Services;
using System;
using System.Windows.Forms;

namespace EmployeesManagerForm
{
    public partial class AddNewEmployee : Form
    {
        EmployeesService _employeesService;
        DepartmentsService _departmentsService;
        PositionsService _positionsService;
        KPIService _KPIService;
        public AddNewEmployee(DatabaseContext context)
        {
            _employeesService = new EmployeesService(context);
            _departmentsService = new DepartmentsService(context);
            _positionsService = new PositionsService(context);
            _KPIService = new KPIService(context);
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var resSal = Convert.ToDecimal(sallary.Text);
                var kpi = comboBox1.SelectedItem.ToString();

                Employee employee = new Employee()
                {
                    Name = name.Text,
                    LastName = lastName.Text,
                    MiddleName = middleName.Text,
                    PhoneNumber = Phone.Text,
                    Address = Adress.Text,
                    Department = _departmentsService.CreateIfNotExists(comboBox2.Text),
                    Position = _positionsService.CreateIfNotExists(comboBox3.Text),
                    Salary = resSal,
                    KPI_Ref = _KPIService.GetKPIFromStr(kpi)

                };
                _employeesService.Create(employee);
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неправильно введены данные!");
            }


        }

        private void sallary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            var test = Keys.Delete;
            if (!char.IsDigit(ch)  && ch != ',' && ch != '.')
            {
                e.Handled = true;
            }
        }


        private void AddNewEmployee_Load(object sender, EventArgs e)
        {

            var valuesKPI = _KPIService.GetKPIs().ToArray();
            var valuesDepartments = _departmentsService.GetNamesDepartments().ToArray();
            var valuesPositions = _positionsService.GetNamesPositions().ToArray();
            comboBox1.Items.AddRange(valuesKPI);
            comboBox2.Items.AddRange(valuesDepartments);
            comboBox3.Items.AddRange(valuesPositions);
        }

    }
}
