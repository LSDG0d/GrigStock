namespace GrigStock.Forms
{
    partial class VisitorForm
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
            textBoxClients = new TextBox();
            button1 = new Button();
            dataGridViewClients = new DataGridView();
            tabPage3 = new TabPage();
            textBoxEmployee = new TextBox();
            button2 = new Button();
            dataGridViewEmployees = new DataGridView();
            tabPage4 = new TabPage();
            textBoxOrders = new TextBox();
            buttonSearchOrders = new Button();
            dataGridViewOrders = new DataGridView();
            tabPage5 = new TabPage();
            textBoxTovars = new TextBox();
            button3 = new Button();
            dataGridViewTovars = new DataGridView();
            tabPage6 = new TabPage();
            textBoxTypes = new TextBox();
            button4 = new Button();
            dataGridViewTypes = new DataGridView();
            tabPage7 = new TabPage();
            textBoxSearchProviders = new TextBox();
            button5 = new Button();
            dataGridViewProviders = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPage5.SuspendLayout();
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
            tabControl1.Size = new Size(696, 391);
            tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBoxClients);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(dataGridViewClients);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(688, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Клиенты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxClients
            // 
            textBoxClients.Location = new Point(8, 323);
            textBoxClients.Name = "textBoxClients";
            textBoxClients.Size = new Size(572, 30);
            textBoxClients.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(586, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Поиск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.AllowUserToOrderColumns = true;
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Dock = DockStyle.Top;
            dataGridViewClients.Location = new Point(3, 3);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.Size = new Size(682, 315);
            dataGridViewClients.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBoxEmployee);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(dataGridViewEmployees);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(688, 358);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Сотрудники";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxEmployee
            // 
            textBoxEmployee.Location = new Point(8, 320);
            textBoxEmployee.Name = "textBoxEmployee";
            textBoxEmployee.Size = new Size(572, 30);
            textBoxEmployee.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(586, 318);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Поиск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToOrderColumns = true;
            dataGridViewEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployees.Dock = DockStyle.Top;
            dataGridViewEmployees.Location = new Point(0, 0);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.RowHeadersWidth = 51;
            dataGridViewEmployees.Size = new Size(688, 314);
            dataGridViewEmployees.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(textBoxOrders);
            tabPage4.Controls.Add(buttonSearchOrders);
            tabPage4.Controls.Add(dataGridViewOrders);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(688, 358);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Заказы";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBoxOrders
            // 
            textBoxOrders.Location = new Point(8, 317);
            textBoxOrders.Name = "textBoxOrders";
            textBoxOrders.Size = new Size(572, 30);
            textBoxOrders.TabIndex = 7;
            // 
            // buttonSearchOrders
            // 
            buttonSearchOrders.Location = new Point(586, 315);
            buttonSearchOrders.Name = "buttonSearchOrders";
            buttonSearchOrders.Size = new Size(94, 29);
            buttonSearchOrders.TabIndex = 2;
            buttonSearchOrders.Text = "Поиск";
            buttonSearchOrders.UseVisualStyleBackColor = true;
            buttonSearchOrders.Click += buttonSearchOrders_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToOrderColumns = true;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Dock = DockStyle.Top;
            dataGridViewOrders.Location = new Point(0, 0);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(688, 309);
            dataGridViewOrders.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(textBoxTovars);
            tabPage5.Controls.Add(button3);
            tabPage5.Controls.Add(dataGridViewTovars);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(688, 358);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Товары";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxTovars
            // 
            textBoxTovars.Location = new Point(3, 318);
            textBoxTovars.Name = "textBoxTovars";
            textBoxTovars.Size = new Size(572, 30);
            textBoxTovars.TabIndex = 6;
            // 
            // button3
            // 
            button3.Location = new Point(586, 318);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Поиск";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridViewTovars
            // 
            dataGridViewTovars.AllowUserToOrderColumns = true;
            dataGridViewTovars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTovars.Dock = DockStyle.Top;
            dataGridViewTovars.Location = new Point(0, 0);
            dataGridViewTovars.Name = "dataGridViewTovars";
            dataGridViewTovars.RowHeadersWidth = 51;
            dataGridViewTovars.Size = new Size(688, 316);
            dataGridViewTovars.TabIndex = 1;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBoxTypes);
            tabPage6.Controls.Add(button4);
            tabPage6.Controls.Add(dataGridViewTypes);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(688, 358);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Типы";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBoxTypes
            // 
            textBoxTypes.Location = new Point(3, 318);
            textBoxTypes.Name = "textBoxTypes";
            textBoxTypes.Size = new Size(572, 30);
            textBoxTypes.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(586, 318);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Поиск";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AllowUserToOrderColumns = true;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Top;
            dataGridViewTypes.Location = new Point(0, 0);
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.RowHeadersWidth = 51;
            dataGridViewTypes.Size = new Size(688, 312);
            dataGridViewTypes.TabIndex = 1;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(textBoxSearchProviders);
            tabPage7.Controls.Add(button5);
            tabPage7.Controls.Add(dataGridViewProviders);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(688, 358);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Поставщики";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchProviders
            // 
            textBoxSearchProviders.Location = new Point(8, 323);
            textBoxSearchProviders.Name = "textBoxSearchProviders";
            textBoxSearchProviders.Size = new Size(572, 30);
            textBoxSearchProviders.TabIndex = 4;
            // 
            // button5
            // 
            button5.Location = new Point(586, 323);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "Поиск";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridViewProviders
            // 
            dataGridViewProviders.AllowUserToOrderColumns = true;
            dataGridViewProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProviders.Dock = DockStyle.Top;
            dataGridViewProviders.Location = new Point(0, 0);
            dataGridViewProviders.Name = "dataGridViewProviders";
            dataGridViewProviders.RowHeadersWidth = 51;
            dataGridViewProviders.Size = new Size(688, 320);
            dataGridViewProviders.TabIndex = 1;
            // 
            // VisitorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 391);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "VisitorForm";
            Text = "Посетитель";
            Load += VisitorForm_Load;
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
        private DataGridView dataGridViewClients;
        private TabPage tabPage3;
        private DataGridView dataGridViewEmployees;
        private TabPage tabPage4;
        private DataGridView dataGridViewOrders;
        private TabPage tabPage5;
        private DataGridView dataGridViewTovars;
        private TabPage tabPage6;
        private DataGridView dataGridViewTypes;
        private TabPage tabPage7;
        private DataGridView dataGridViewProviders;
        private Button button1;
        private Button button2;
        private Button buttonSearchOrders;
        private Button button3;
        private Button button4;
        private TextBox textBoxSearchProviders;
        private Button button5;
        private TextBox textBoxTypes;
        private TextBox textBoxTovars;
        private TextBox textBoxOrders;
        private TextBox textBoxEmployee;
        private TextBox textBoxClients;
    }
}