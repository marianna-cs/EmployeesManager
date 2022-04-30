namespace EmployeesManagerForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxDep = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.department = new System.Windows.Forms.TabPage();
            this.Refresh1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.update_depart = new System.Windows.Forms.Button();
            this.delete_depart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDepartment = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.TabPage();
            this.Refresh2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.update_position = new System.Windows.Forms.Button();
            this.delet_position = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.AddPosition = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Payouts = new System.Windows.Forms.TabPage();
            this.Report = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.GetSum = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.position.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.Payouts.SuspendLayout();
            this.Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.department);
            this.tabControl1.Controls.Add(this.position);
            this.tabControl1.Controls.Add(this.Payouts);
            this.tabControl1.Controls.Add(this.Report);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1366, 610);
            this.tabControl1.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Home.Controls.Add(this.label14);
            this.Home.Controls.Add(this.comboBoxDep);
            this.Home.Controls.Add(this.refresh);
            this.Home.Controls.Add(this.dataGridView1);
            this.Home.Controls.Add(this.label1);
            this.Home.Controls.Add(this.button1);
            this.Home.Location = new System.Drawing.Point(4, 25);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1358, 581);
            this.Home.TabIndex = 0;
            this.Home.Text = "Главная";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(385, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "Выберете отдел";
            // 
            // comboBoxDep
            // 
            this.comboBoxDep.FormattingEnabled = true;
            this.comboBoxDep.Location = new System.Drawing.Point(388, 33);
            this.comboBoxDep.Name = "comboBoxDep";
            this.comboBoxDep.Size = new System.Drawing.Size(257, 24);
            this.comboBoxDep.TabIndex = 4;
            this.comboBoxDep.SelectionChangeCommitted += new System.EventHandler(this.comboBoxDep_SelectionChangeCommitted);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(1195, 12);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(153, 45);
            this.refresh.TabIndex = 3;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1355, 502);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(3, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1360, 10);
            this.label1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить сотрудника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // department
            // 
            this.department.BackColor = System.Drawing.Color.PaleTurquoise;
            this.department.Controls.Add(this.Refresh1);
            this.department.Controls.Add(this.label11);
            this.department.Controls.Add(this.label10);
            this.department.Controls.Add(this.update_depart);
            this.department.Controls.Add(this.delete_depart);
            this.department.Controls.Add(this.label5);
            this.department.Controls.Add(this.textBox1);
            this.department.Controls.Add(this.label4);
            this.department.Controls.Add(this.label3);
            this.department.Controls.Add(this.dataGridView2);
            this.department.Controls.Add(this.label2);
            this.department.Controls.Add(this.AddDepartment);
            this.department.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.department.Location = new System.Drawing.Point(4, 25);
            this.department.Name = "department";
            this.department.Padding = new System.Windows.Forms.Padding(3);
            this.department.Size = new System.Drawing.Size(1358, 581);
            this.department.TabIndex = 1;
            this.department.Text = "Отдел";
            // 
            // Refresh1
            // 
            this.Refresh1.Location = new System.Drawing.Point(1186, 6);
            this.Refresh1.Name = "Refresh1";
            this.Refresh1.Size = new System.Drawing.Size(166, 51);
            this.Refresh1.TabIndex = 13;
            this.Refresh1.Text = "Refresh";
            this.Refresh1.UseVisualStyleBackColor = true;
            this.Refresh1.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(473, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(573, 35);
            this.label11.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(468, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Id:";
            // 
            // update_depart
            // 
            this.update_depart.Location = new System.Drawing.Point(1097, 152);
            this.update_depart.Name = "update_depart";
            this.update_depart.Size = new System.Drawing.Size(235, 61);
            this.update_depart.TabIndex = 8;
            this.update_depart.Text = "Изменить";
            this.update_depart.UseVisualStyleBackColor = true;
            this.update_depart.Click += new System.EventHandler(this.updateDepartment_Click);
            // 
            // delete_depart
            // 
            this.delete_depart.Location = new System.Drawing.Point(1097, 77);
            this.delete_depart.Name = "delete_depart";
            this.delete_depart.Size = new System.Drawing.Size(235, 61);
            this.delete_depart.TabIndex = 7;
            this.delete_depart.Text = "Удалить";
            this.delete_depart.UseVisualStyleBackColor = true;
            this.delete_depart.Click += new System.EventHandler(this.deleteDepartment_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(468, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Название отдела:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(473, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(573, 36);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(466, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отдел:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(462, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(609, 269);
            this.label3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(431, 501);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-4, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1366, 10);
            this.label2.TabIndex = 1;
            // 
            // AddDepartment
            // 
            this.AddDepartment.Location = new System.Drawing.Point(6, 6);
            this.AddDepartment.Name = "AddDepartment";
            this.AddDepartment.Size = new System.Drawing.Size(189, 51);
            this.AddDepartment.TabIndex = 0;
            this.AddDepartment.Text = "Добавить отдел";
            this.AddDepartment.UseVisualStyleBackColor = true;
            this.AddDepartment.Click += new System.EventHandler(this.AddDepartment_Click);
            // 
            // position
            // 
            this.position.BackColor = System.Drawing.Color.PaleTurquoise;
            this.position.Controls.Add(this.Refresh2);
            this.position.Controls.Add(this.label13);
            this.position.Controls.Add(this.label12);
            this.position.Controls.Add(this.update_position);
            this.position.Controls.Add(this.delet_position);
            this.position.Controls.Add(this.label9);
            this.position.Controls.Add(this.textBox2);
            this.position.Controls.Add(this.label8);
            this.position.Controls.Add(this.label7);
            this.position.Controls.Add(this.dataGridView3);
            this.position.Controls.Add(this.label6);
            this.position.Controls.Add(this.AddPosition);
            this.position.Location = new System.Drawing.Point(4, 25);
            this.position.Name = "position";
            this.position.Padding = new System.Windows.Forms.Padding(3);
            this.position.Size = new System.Drawing.Size(1358, 581);
            this.position.TabIndex = 2;
            this.position.Text = "Должность";
            // 
            // Refresh2
            // 
            this.Refresh2.Location = new System.Drawing.Point(1167, 6);
            this.Refresh2.Name = "Refresh2";
            this.Refresh2.Size = new System.Drawing.Size(175, 50);
            this.Refresh2.TabIndex = 12;
            this.Refresh2.Text = "Refresh";
            this.Refresh2.UseVisualStyleBackColor = true;
            this.Refresh2.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(516, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(435, 38);
            this.label13.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(511, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "Id:";
            // 
            // update_position
            // 
            this.update_position.Location = new System.Drawing.Point(1074, 191);
            this.update_position.Name = "update_position";
            this.update_position.Size = new System.Drawing.Size(220, 63);
            this.update_position.TabIndex = 9;
            this.update_position.Text = "Изменить";
            this.update_position.UseVisualStyleBackColor = true;
            this.update_position.Click += new System.EventHandler(this.updatePosition_Click);
            // 
            // delet_position
            // 
            this.delet_position.Location = new System.Drawing.Point(1074, 98);
            this.delet_position.Name = "delet_position";
            this.delet_position.Size = new System.Drawing.Size(220, 63);
            this.delet_position.TabIndex = 7;
            this.delet_position.Text = "Удалить";
            this.delet_position.UseVisualStyleBackColor = true;
            this.delet_position.Click += new System.EventHandler(this.deletePosition_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(511, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(268, 29);
            this.label9.TabIndex = 6;
            this.label9.Text = "Название должности:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(516, 329);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(435, 36);
            this.textBox2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(509, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 39);
            this.label8.TabIndex = 4;
            this.label8.Text = "Должность:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(502, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(497, 357);
            this.label7.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 73);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(458, 501);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(-11, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1379, 10);
            this.label6.TabIndex = 1;
            // 
            // AddPosition
            // 
            this.AddPosition.Location = new System.Drawing.Point(6, 6);
            this.AddPosition.Name = "AddPosition";
            this.AddPosition.Size = new System.Drawing.Size(185, 51);
            this.AddPosition.TabIndex = 0;
            this.AddPosition.Text = "Добавить должность";
            this.AddPosition.UseVisualStyleBackColor = true;
            this.AddPosition.Click += new System.EventHandler(this.AddPosition_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Payouts
            // 
            this.Payouts.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Payouts.Controls.Add(this.label18);
            this.Payouts.Controls.Add(this.comboBox1);
            this.Payouts.Controls.Add(this.label17);
            this.Payouts.Controls.Add(this.GetSum);
            this.Payouts.Controls.Add(this.label16);
            this.Payouts.Controls.Add(this.label15);
            this.Payouts.Location = new System.Drawing.Point(4, 25);
            this.Payouts.Name = "Payouts";
            this.Payouts.Size = new System.Drawing.Size(1358, 581);
            this.Payouts.TabIndex = 3;
            this.Payouts.Text = "Выплаты";
            // 
            // Report
            // 
            this.Report.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Report.Controls.Add(this.button2);
            this.Report.Location = new System.Drawing.Point(4, 25);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1358, 581);
            this.Report.TabIndex = 4;
            this.Report.Text = "Отчет";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(16, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(334, 29);
            this.label15.TabIndex = 0;
            this.label15.Text = "Сума выплат сотрудникам:";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(387, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(321, 37);
            this.label16.TabIndex = 1;
            // 
            // GetSum
            // 
            this.GetSum.Location = new System.Drawing.Point(787, 39);
            this.GetSum.Name = "GetSum";
            this.GetSum.Size = new System.Drawing.Size(280, 37);
            this.GetSum.TabIndex = 2;
            this.GetSum.Text = "Получить сумму";
            this.GetSum.UseVisualStyleBackColor = true;
            this.GetSum.Click += new System.EventHandler(this.GetSum_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(16, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(335, 29);
            this.label17.TabIndex = 3;
            this.label17.Text = "Получить сумму по отделу:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(390, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(784, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(283, 37);
            this.label18.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 67);
            this.button2.TabIndex = 0;
            this.button2.Text = "Сохранить отчет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 614);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.department.ResumeLayout(false);
            this.department.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.position.ResumeLayout(false);
            this.position.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.Payouts.ResumeLayout(false);
            this.Payouts.PerformLayout();
            this.Report.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage department;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddDepartment;
        private System.Windows.Forms.TabPage position;
        private System.Windows.Forms.Button AddPosition;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button update_depart;
        private System.Windows.Forms.Button delete_depart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button update_position;
        private System.Windows.Forms.Button delet_position;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Refresh1;
        private System.Windows.Forms.Button Refresh2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxDep;
        private System.Windows.Forms.TabPage Payouts;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button GetSum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

