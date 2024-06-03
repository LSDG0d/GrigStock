namespace GrigStock.Forms
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            button1 = new Button();
            textBoxClients = new TextBox();
            label1 = new Label();
            label15 = new Label();
            textBoxCname = new TextBox();
            button2 = new Button();
            button3 = new Button();
            dataGridViewClients = new DataGridView();
            tabPage3 = new TabPage();
            button14 = new Button();
            textBoxEmployee = new TextBox();
            label2 = new Label();
            dateTimePickerBirthday = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            textBoxJTitle = new TextBox();
            label12 = new Label();
            textBoxLname = new TextBox();
            label11 = new Label();
            textBoxFname = new TextBox();
            button4 = new Button();
            button5 = new Button();
            dataGridViewEmployees = new DataGridView();
            tabPage4 = new TabPage();
            button15 = new Button();
            textBoxOrders = new TextBox();
            label3 = new Label();
            label19 = new Label();
            textBoxAdress = new TextBox();
            label18 = new Label();
            textBoxRecipient = new TextBox();
            label17 = new Label();
            comboBoxOEmployees = new ComboBox();
            label16 = new Label();
            comboBoxOClients = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            dataGridViewOrders = new DataGridView();
            tabPage5 = new TabPage();
            button16 = new Button();
            textBoxTovars = new TextBox();
            label20 = new Label();
            label10 = new Label();
            comboBoxType = new ComboBox();
            label9 = new Label();
            comboBoxProvider = new ComboBox();
            label8 = new Label();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            textBoxtovar = new TextBox();
            button8 = new Button();
            button9 = new Button();
            dataGridViewTovars = new DataGridView();
            tabPage6 = new TabPage();
            button17 = new Button();
            textBoxTypes = new TextBox();
            label21 = new Label();
            label4 = new Label();
            textBoxcategory = new TextBox();
            button10 = new Button();
            button11 = new Button();
            dataGridViewTypes = new DataGridView();
            tabPage7 = new TabPage();
            button18 = new Button();
            textBoxSearchProviders = new TextBox();
            label22 = new Label();
            label5 = new Label();
            textBoxprovider = new TextBox();
            button12 = new Button();
            button13 = new Button();
            dataGridViewProviders = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovars).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProviders).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 392);
            tabControl1.TabIndex = 1;
            tabControl1.MouseClick += tabControl1_MouseClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBoxClients);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBoxCname);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dataGridViewClients);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(692, 356);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Клиенты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(305, 313);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxClients
            // 
            textBoxClients.Location = new Point(83, 315);
            textBoxClients.Name = "textBoxClients";
            textBoxClients.Size = new Size(216, 30);
            textBoxClients.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 319);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 13;
            label1.Text = "Поиск:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(21, 267);
            label15.Name = "label15";
            label15.Size = new Size(49, 23);
            label15.TabIndex = 12;
            label15.Text = "Имя:";
            // 
            // textBoxCname
            // 
            textBoxCname.Location = new Point(83, 261);
            textBoxCname.Name = "textBoxCname";
            textBoxCname.Size = new Size(216, 30);
            textBoxCname.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(590, 316);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(490, 316);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AllowUserToOrderColumns = true;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Dock = DockStyle.Top;
            dataGridViewClients.Location = new Point(3, 3);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(686, 252);
            dataGridViewClients.TabIndex = 1;
            dataGridViewClients.CellContentClick += dataGridViewClients_CellContentClick;
            dataGridViewClients.CellEndEdit += dataGridViewClients_CellEndEdit;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button14);
            tabPage3.Controls.Add(textBoxEmployee);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(dateTimePickerBirthday);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(textBoxJTitle);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBoxLname);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(textBoxFname);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(dataGridViewEmployees);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(692, 356);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Сотрудники";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(585, 290);
            button14.Name = "button14";
            button14.Size = new Size(94, 29);
            button14.TabIndex = 22;
            button14.Text = "Поиск";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // textBoxEmployee
            // 
            textBoxEmployee.Location = new Point(419, 290);
            textBoxEmployee.Name = "textBoxEmployee";
            textBoxEmployee.Size = new Size(160, 30);
            textBoxEmployee.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 297);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 20;
            label2.Text = "Поиск:";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Location = new Point(108, 323);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(216, 30);
            dateTimePickerBirthday.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(10, 322);
            label14.Name = "label14";
            label14.Size = new Size(102, 23);
            label14.TabIndex = 18;
            label14.Text = "Дата Рожд.:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(354, 261);
            label13.Name = "label13";
            label13.Size = new Size(103, 23);
            label13.TabIndex = 16;
            label13.Text = "Должность:";
            // 
            // textBoxJTitle
            // 
            textBoxJTitle.Location = new Point(463, 258);
            textBoxJTitle.Name = "textBoxJTitle";
            textBoxJTitle.Size = new Size(216, 30);
            textBoxJTitle.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 293);
            label12.Name = "label12";
            label12.Size = new Size(88, 23);
            label12.TabIndex = 14;
            label12.Text = "Фамилия:";
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(108, 290);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(216, 30);
            textBoxLname.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(10, 261);
            label11.Name = "label11";
            label11.Size = new Size(49, 23);
            label11.TabIndex = 12;
            label11.Text = "Имя:";
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(108, 258);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(216, 30);
            textBoxFname.TabIndex = 11;
            // 
            // button4
            // 
            button4.Location = new Point(585, 322);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(485, 323);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "Добавить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToOrderColumns = true;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Dock = DockStyle.Top;
            dataGridViewEmployees.Location = new Point(0, 0);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.Size = new Size(692, 252);
            dataGridViewEmployees.TabIndex = 1;
            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
            dataGridViewEmployees.CellEndEdit += dataGridViewEmployees_CellEndEdit;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button15);
            tabPage4.Controls.Add(textBoxOrders);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(textBoxAdress);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(textBoxRecipient);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(comboBoxOEmployees);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(comboBoxOClients);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(dataGridViewOrders);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(692, 356);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Заказы";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(590, 324);
            button15.Name = "button15";
            button15.Size = new Size(94, 29);
            button15.TabIndex = 33;
            button15.Text = "Поиск";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // textBoxOrders
            // 
            textBoxOrders.Location = new Point(363, 324);
            textBoxOrders.Name = "textBoxOrders";
            textBoxOrders.Size = new Size(216, 30);
            textBoxOrders.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 327);
            label3.Name = "label3";
            label3.Size = new Size(65, 23);
            label3.TabIndex = 31;
            label3.Text = "Поиск:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(297, 295);
            label19.Name = "label19";
            label19.Size = new Size(63, 23);
            label19.TabIndex = 30;
            label19.Text = "Адрес:";
            // 
            // textBoxAdress
            // 
            textBoxAdress.Location = new Point(363, 292);
            textBoxAdress.Name = "textBoxAdress";
            textBoxAdress.Size = new Size(216, 30);
            textBoxAdress.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(272, 261);
            label18.Name = "label18";
            label18.Size = new Size(88, 23);
            label18.TabIndex = 28;
            label18.Text = "Заказчик:";
            // 
            // textBoxRecipient
            // 
            textBoxRecipient.Location = new Point(363, 258);
            textBoxRecipient.Name = "textBoxRecipient";
            textBoxRecipient.Size = new Size(216, 30);
            textBoxRecipient.TabIndex = 27;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 304);
            label17.Name = "label17";
            label17.Size = new Size(100, 23);
            label17.TabIndex = 26;
            label17.Text = "Сотрудник:";
            // 
            // comboBoxOEmployees
            // 
            comboBoxOEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOEmployees.FormattingEnabled = true;
            comboBoxOEmployees.Location = new Point(113, 296);
            comboBoxOEmployees.Name = "comboBoxOEmployees";
            comboBoxOEmployees.Size = new Size(151, 31);
            comboBoxOEmployees.TabIndex = 25;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 262);
            label16.Name = "label16";
            label16.Size = new Size(71, 23);
            label16.TabIndex = 24;
            label16.Text = "Клиент:";
            // 
            // comboBoxOClients
            // 
            comboBoxOClients.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOClients.FormattingEnabled = true;
            comboBoxOClients.Location = new Point(113, 259);
            comboBoxOClients.Name = "comboBoxOClients";
            comboBoxOClients.Size = new Size(151, 31);
            comboBoxOClients.TabIndex = 23;
            // 
            // button6
            // 
            button6.Location = new Point(590, 292);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 10;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(590, 258);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 9;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToOrderColumns = true;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Dock = DockStyle.Top;
            dataGridViewOrders.Location = new Point(0, 0);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(692, 252);
            dataGridViewOrders.TabIndex = 1;
            dataGridViewOrders.CellContentClick += dataGridViewOrders_CellContentClick;
            dataGridViewOrders.CellEndEdit += dataGridViewOrders_CellEndEdit;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button16);
            tabPage5.Controls.Add(textBoxTovars);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(comboBoxType);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(comboBoxProvider);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(numericUpDown2);
            tabPage5.Controls.Add(label7);
            tabPage5.Controls.Add(numericUpDown1);
            tabPage5.Controls.Add(label6);
            tabPage5.Controls.Add(textBoxtovar);
            tabPage5.Controls.Add(button8);
            tabPage5.Controls.Add(button9);
            tabPage5.Controls.Add(dataGridViewTovars);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(692, 359);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Товары";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(585, 322);
            button16.Name = "button16";
            button16.Size = new Size(94, 29);
            button16.TabIndex = 27;
            button16.Text = "Поиск";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // textBoxTovars
            // 
            textBoxTovars.Location = new Point(407, 322);
            textBoxTovars.Name = "textBoxTovars";
            textBoxTovars.Size = new Size(172, 30);
            textBoxTovars.TabIndex = 26;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(336, 326);
            label20.Name = "label20";
            label20.Size = new Size(65, 23);
            label20.TabIndex = 25;
            label20.Text = "Поиск:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(359, 293);
            label10.Name = "label10";
            label10.Size = new Size(42, 23);
            label10.TabIndex = 24;
            label10.Text = "Тип:";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(407, 290);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(172, 31);
            comboBoxType.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 261);
            label9.Name = "label9";
            label9.Size = new Size(105, 23);
            label9.TabIndex = 22;
            label9.Text = "Поставщик:";
            // 
            // comboBoxProvider
            // 
            comboBoxProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvider.FormattingEnabled = true;
            comboBoxProvider.Location = new Point(407, 258);
            comboBoxProvider.Name = "comboBoxProvider";
            comboBoxProvider.Size = new Size(172, 31);
            comboBoxProvider.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(179, 293);
            label8.Name = "label8";
            label8.Size = new Size(55, 23);
            label8.TabIndex = 20;
            label8.Text = "Цена:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(237, 290);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(93, 30);
            numericUpDown2.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 292);
            label7.Name = "label7";
            label7.Size = new Size(70, 23);
            label7.TabIndex = 18;
            label7.Text = "Кол-во:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(80, 290);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 30);
            numericUpDown1.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 261);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 16;
            label6.Text = "Имя:";
            // 
            // textBoxtovar
            // 
            textBoxtovar.Location = new Point(74, 258);
            textBoxtovar.Name = "textBoxtovar";
            textBoxtovar.Size = new Size(216, 30);
            textBoxtovar.TabIndex = 15;
            // 
            // button8
            // 
            button8.Location = new Point(585, 291);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 10;
            button8.Text = "Удалить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(585, 260);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 9;
            button9.Text = "Добавить";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridViewTovars
            // 
            dataGridViewTovars.AllowUserToOrderColumns = true;
            dataGridViewTovars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTovars.Dock = DockStyle.Top;
            dataGridViewTovars.Location = new Point(0, 0);
            dataGridViewTovars.Name = "dataGridViewTovars";
            dataGridViewTovars.RowHeadersWidth = 51;
            dataGridViewTovars.Size = new Size(692, 252);
            dataGridViewTovars.TabIndex = 1;
            dataGridViewTovars.CellContentClick += dataGridViewTovars_CellContentClick;
            dataGridViewTovars.CellEndEdit += dataGridViewTovars_CellEndEdit;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button17);
            tabPage6.Controls.Add(textBoxTypes);
            tabPage6.Controls.Add(label21);
            tabPage6.Controls.Add(label4);
            tabPage6.Controls.Add(textBoxcategory);
            tabPage6.Controls.Add(button10);
            tabPage6.Controls.Add(button11);
            tabPage6.Controls.Add(dataGridViewTypes);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(692, 359);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Типы";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(385, 316);
            button17.Name = "button17";
            button17.Size = new Size(94, 29);
            button17.TabIndex = 25;
            button17.Text = "Поиск";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // textBoxTypes
            // 
            textBoxTypes.Location = new Point(219, 316);
            textBoxTypes.Name = "textBoxTypes";
            textBoxTypes.Size = new Size(160, 30);
            textBoxTypes.TabIndex = 24;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(148, 323);
            label21.Name = "label21";
            label21.Size = new Size(65, 23);
            label21.TabIndex = 23;
            label21.Text = "Поиск:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 261);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 12;
            label4.Text = "Категория:";
            // 
            // textBoxcategory
            // 
            textBoxcategory.Location = new Point(109, 258);
            textBoxcategory.Name = "textBoxcategory";
            textBoxcategory.Size = new Size(216, 30);
            textBoxcategory.TabIndex = 11;
            // 
            // button10
            // 
            button10.Location = new Point(585, 316);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 10;
            button10.Text = "Удалить";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(485, 316);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 9;
            button11.Text = "Добавить";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AllowUserToOrderColumns = true;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Top;
            dataGridViewTypes.Location = new Point(0, 0);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.RowHeadersWidth = 51;
            dataGridViewTypes.Size = new Size(692, 252);
            dataGridViewTypes.TabIndex = 1;
            dataGridViewTypes.CellContentClick += dataGridViewTypes_CellContentClick;
            dataGridViewTypes.CellEndEdit += dataGridViewTypes_CellEndEdit;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(button18);
            tabPage7.Controls.Add(textBoxSearchProviders);
            tabPage7.Controls.Add(label22);
            tabPage7.Controls.Add(label5);
            tabPage7.Controls.Add(textBoxprovider);
            tabPage7.Controls.Add(button12);
            tabPage7.Controls.Add(button13);
            tabPage7.Controls.Add(dataGridViewProviders);
            tabPage7.Location = new Point(4, 32);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(692, 356);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Поставщики";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(385, 316);
            button18.Name = "button18";
            button18.Size = new Size(94, 29);
            button18.TabIndex = 25;
            button18.Text = "Поиск";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // textBoxSearchProviders
            // 
            textBoxSearchProviders.Location = new Point(219, 316);
            textBoxSearchProviders.Name = "textBoxSearchProviders";
            textBoxSearchProviders.Size = new Size(160, 30);
            textBoxSearchProviders.TabIndex = 24;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(148, 323);
            label22.Name = "label22";
            label22.Size = new Size(65, 23);
            label22.TabIndex = 23;
            label22.Text = "Поиск:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 261);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 14;
            label5.Text = "Имя:";
            // 
            // textBoxprovider
            // 
            textBoxprovider.Location = new Point(74, 258);
            textBoxprovider.Name = "textBoxprovider";
            textBoxprovider.Size = new Size(216, 30);
            textBoxprovider.TabIndex = 13;
            // 
            // button12
            // 
            button12.Location = new Point(585, 316);
            button12.Name = "button12";
            button12.Size = new Size(94, 29);
            button12.TabIndex = 10;
            button12.Text = "Удалить";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(485, 316);
            button13.Name = "button13";
            button13.Size = new Size(94, 29);
            button13.TabIndex = 9;
            button13.Text = "Добавить";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // dataGridViewProviders
            // 
            dataGridViewProviders.AllowUserToOrderColumns = true;
            dataGridViewProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProviders.Dock = DockStyle.Top;
            dataGridViewProviders.Location = new Point(0, 0);
            dataGridViewProviders.Name = "dataGridViewProviders";
            dataGridViewProviders.RowHeadersWidth = 51;
            dataGridViewProviders.Size = new Size(692, 252);
            dataGridViewProviders.TabIndex = 1;
            dataGridViewProviders.CellContentClick += dataGridViewProviders_CellContentClick;
            dataGridViewProviders.CellEndEdit += dataGridViewProviders_CellEndEdit;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 392);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmployeeForm";
            Text = "Сотрудник";
            Load += EmployeeForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTovars).EndInit();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProviders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private Label label15;
        private TextBox textBoxCname;
        private Button button2;
        private Button button3;
        private DataGridView dataGridViewClients;
        private TabPage tabPage3;
        private DateTimePicker dateTimePickerBirthday;
        private Label label14;
        private Label label13;
        private TextBox textBoxJTitle;
        private Label label12;
        private TextBox textBoxLname;
        private Label label11;
        private TextBox textBoxFname;
        private Button button4;
        private Button button5;
        private DataGridView dataGridViewEmployees;
        private TabPage tabPage4;
        private Label label19;
        private TextBox textBoxAdress;
        private Label label18;
        private TextBox textBoxRecipient;
        private Label label17;
        private ComboBox comboBoxOEmployees;
        private Label label16;
        private ComboBox comboBoxOClients;
        private Button button6;
        private Button button7;
        private DataGridView dataGridViewOrders;
        private TabPage tabPage5;
        private Label label10;
        private ComboBox comboBoxType;
        private Label label9;
        private ComboBox comboBoxProvider;
        private Label label8;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private TextBox textBoxtovar;
        private Button button8;
        private Button button9;
        private DataGridView dataGridViewTovars;
        private TabPage tabPage6;
        private Label label4;
        private TextBox textBoxcategory;
        private Button button10;
        private Button button11;
        private DataGridView dataGridViewTypes;
        private TabPage tabPage7;
        private Label label5;
        private TextBox textBoxprovider;
        private Button button12;
        private Button button13;
        private DataGridView dataGridViewProviders;
        private Button button1;
        private TextBox textBoxClients;
        private Label label1;
        private Button button14;
        private TextBox textBoxEmployee;
        private Label label2;
        private Button button15;
        private TextBox textBoxOrders;
        private Label label3;
        private Button button16;
        private TextBox textBoxTovars;
        private Label label20;
        private Button button17;
        private TextBox textBoxTypes;
        private Label label21;
        private Button button18;
        private TextBox textBoxSearchProviders;
        private Label label22;
    }
}