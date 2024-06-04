namespace GrigStock.Forms
{
    partial class OtchetForm
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
            dataGridViewOtchet = new DataGridView();
            dateTimePickerFrom = new DateTimePicker();
            dateTimePickerTo = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            DateOrder = new DataGridViewTextBoxColumn();
            CountPosition = new DataGridViewTextBoxColumn();
            SummToRub = new DataGridViewTextBoxColumn();
            EmployeeWorker = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtchet).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewOtchet
            // 
            dataGridViewOtchet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOtchet.Columns.AddRange(new DataGridViewColumn[] { DateOrder, CountPosition, SummToRub, EmployeeWorker, Address });
            dataGridViewOtchet.Dock = DockStyle.Bottom;
            dataGridViewOtchet.Location = new Point(0, 56);
            dataGridViewOtchet.Name = "dataGridViewOtchet";
            dataGridViewOtchet.RowHeadersWidth = 51;
            dataGridViewOtchet.Size = new Size(856, 418);
            dataGridViewOtchet.TabIndex = 0;
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Location = new Point(36, 4);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new Size(168, 27);
            dateTimePickerFrom.TabIndex = 1;
            // 
            // dateTimePickerTo
            // 
            dateTimePickerTo.Location = new Point(245, 4);
            dateTimePickerTo.Name = "dateTimePickerTo";
            dateTimePickerTo.Size = new Size(168, 27);
            dateTimePickerTo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 3;
            label1.Text = "С";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 4;
            label2.Text = "По";
            // 
            // button1
            // 
            button1.Location = new Point(419, 4);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Вывод";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DateOrder
            // 
            DateOrder.HeaderText = "Дата заказа";
            DateOrder.MinimumWidth = 6;
            DateOrder.Name = "DateOrder";
            DateOrder.ReadOnly = true;
            DateOrder.Width = 125;
            // 
            // CountPosition
            // 
            CountPosition.HeaderText = "Кол-во позиций";
            CountPosition.MinimumWidth = 6;
            CountPosition.Name = "CountPosition";
            CountPosition.ReadOnly = true;
            CountPosition.Width = 125;
            // 
            // SummToRub
            // 
            SummToRub.HeaderText = "Сумма заказа";
            SummToRub.MinimumWidth = 6;
            SummToRub.Name = "SummToRub";
            SummToRub.ReadOnly = true;
            SummToRub.Width = 125;
            // 
            // EmployeeWorker
            // 
            EmployeeWorker.HeaderText = "Выполнил Работник";
            EmployeeWorker.MinimumWidth = 6;
            EmployeeWorker.Name = "EmployeeWorker";
            EmployeeWorker.ReadOnly = true;
            EmployeeWorker.Width = 125;
            // 
            // Address
            // 
            Address.HeaderText = "Адрес доставки";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.Width = 125;
            // 
            // OtchetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 474);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerTo);
            Controls.Add(dateTimePickerFrom);
            Controls.Add(dataGridViewOtchet);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OtchetForm";
            Text = "Отчёт";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOtchet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewOtchet;
        private DateTimePicker dateTimePickerFrom;
        private DateTimePicker dateTimePickerTo;
        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridViewTextBoxColumn DateOrder;
        private DataGridViewTextBoxColumn CountPosition;
        private DataGridViewTextBoxColumn SummToRub;
        private DataGridViewTextBoxColumn EmployeeWorker;
        private DataGridViewTextBoxColumn Address;
    }
}