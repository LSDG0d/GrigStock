namespace GrigStock.Forms
{
    partial class RegistrationForm
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
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(53, 142);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 23);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(291, 127);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(134, 52);
            button1.TabIndex = 9;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(113, 48);
            textBoxPassword.Margin = new Padding(4, 3, 4, 3);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(312, 30);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(113, 12);
            textBoxLogin.Margin = new Padding(4, 3, 4, 3);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(312, 30);
            textBoxLogin.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 51);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 6;
            label1.Text = "Login:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 12;
            label3.Text = "Role:";
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Employee", "Visitor" });
            comboBoxRole.Location = new Point(113, 84);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(312, 31);
            comboBoxRole.TabIndex = 13;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 197);
            Controls.Add(comboBoxRole);
            Controls.Add(label3);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            Load += RegistrationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Button button1;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxRole;
    }
}