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
    public partial class AddPosition : Form
    {
        PositionsService _positionsService;
        public AddPosition(DatabaseContext context)
        {
            _positionsService = new PositionsService(context);
            InitializeComponent();
        }

        private void AddPos_Click(object sender, EventArgs e)
        {
            Position position = new Position()
            {
                Name = textBox1.Text
            };
            _positionsService.Create(position);
            this.Close();
            this.Dispose();
        }
    }
}
