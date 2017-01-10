namespace WindowsFormsApplication1
{
    partial class RequestForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeSalaryButton = new System.Windows.Forms.Button();
            this.lowSalaryButton = new System.Windows.Forms.Button();
            this.numberOfStaffButton = new System.Windows.Forms.Button();
            this.maxSalaryButton = new System.Windows.Forms.Button();
            this.allVisitsButton = new System.Windows.Forms.Button();
            this.allPaymentsButton = new System.Windows.Forms.Button();
            this.allStafOptions = new System.Windows.Forms.Button();
            this.allCustomersButton = new System.Windows.Forms.Button();
            this.allHorsebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.changeSalaryButton);
            this.groupBox1.Controls.Add(this.lowSalaryButton);
            this.groupBox1.Controls.Add(this.numberOfStaffButton);
            this.groupBox1.Controls.Add(this.maxSalaryButton);
            this.groupBox1.Controls.Add(this.allVisitsButton);
            this.groupBox1.Controls.Add(this.allPaymentsButton);
            this.groupBox1.Controls.Add(this.allStafOptions);
            this.groupBox1.Controls.Add(this.allCustomersButton);
            this.groupBox1.Controls.Add(this.allHorsebutton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose action:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "<-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.Color.SeaShell;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(462, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 15);
            this.textBox1.TabIndex = 9;
            this.textBox1.TabStop = false;
            // 
            // changeSalaryButton
            // 
            this.changeSalaryButton.Location = new System.Drawing.Point(409, 65);
            this.changeSalaryButton.Name = "changeSalaryButton";
            this.changeSalaryButton.Size = new System.Drawing.Size(131, 23);
            this.changeSalaryButton.TabIndex = 8;
            this.changeSalaryButton.Text = "Change Salary";
            this.changeSalaryButton.UseVisualStyleBackColor = true;
            this.changeSalaryButton.Click += new System.EventHandler(this.changeSalaryButton_Click);
            // 
            // lowSalaryButton
            // 
            this.lowSalaryButton.Location = new System.Drawing.Point(158, 65);
            this.lowSalaryButton.Name = "lowSalaryButton";
            this.lowSalaryButton.Size = new System.Drawing.Size(104, 23);
            this.lowSalaryButton.TabIndex = 7;
            this.lowSalaryButton.Text = "Lowest Salary";
            this.lowSalaryButton.UseVisualStyleBackColor = true;
            this.lowSalaryButton.Click += new System.EventHandler(this.lowSalaryButton_Click);
            // 
            // numberOfStaffButton
            // 
            this.numberOfStaffButton.Location = new System.Drawing.Point(286, 65);
            this.numberOfStaffButton.Name = "numberOfStaffButton";
            this.numberOfStaffButton.Size = new System.Drawing.Size(103, 23);
            this.numberOfStaffButton.TabIndex = 6;
            this.numberOfStaffButton.Text = "Staff number";
            this.numberOfStaffButton.UseVisualStyleBackColor = true;
            this.numberOfStaffButton.Click += new System.EventHandler(this.numberOfStaffButton_Click);
            // 
            // maxSalaryButton
            // 
            this.maxSalaryButton.Location = new System.Drawing.Point(13, 65);
            this.maxSalaryButton.Name = "maxSalaryButton";
            this.maxSalaryButton.Size = new System.Drawing.Size(127, 23);
            this.maxSalaryButton.TabIndex = 5;
            this.maxSalaryButton.Text = "Highest Salary";
            this.maxSalaryButton.UseVisualStyleBackColor = true;
            this.maxSalaryButton.Click += new System.EventHandler(this.maxSalaryButton_Click);
            // 
            // allVisitsButton
            // 
            this.allVisitsButton.Location = new System.Drawing.Point(355, 21);
            this.allVisitsButton.Name = "allVisitsButton";
            this.allVisitsButton.Size = new System.Drawing.Size(75, 23);
            this.allVisitsButton.TabIndex = 4;
            this.allVisitsButton.Text = "Visits";
            this.allVisitsButton.UseVisualStyleBackColor = true;
            this.allVisitsButton.Click += new System.EventHandler(this.allVisitsButton_Click);
            // 
            // allPaymentsButton
            // 
            this.allPaymentsButton.Location = new System.Drawing.Point(268, 21);
            this.allPaymentsButton.Name = "allPaymentsButton";
            this.allPaymentsButton.Size = new System.Drawing.Size(81, 23);
            this.allPaymentsButton.TabIndex = 3;
            this.allPaymentsButton.Text = "Payments";
            this.allPaymentsButton.UseVisualStyleBackColor = true;
            this.allPaymentsButton.Click += new System.EventHandler(this.allPaymentsButton_Click);
            // 
            // allStafOptions
            // 
            this.allStafOptions.Location = new System.Drawing.Point(187, 22);
            this.allStafOptions.Name = "allStafOptions";
            this.allStafOptions.Size = new System.Drawing.Size(75, 23);
            this.allStafOptions.TabIndex = 2;
            this.allStafOptions.Text = "Staff";
            this.allStafOptions.UseVisualStyleBackColor = true;
            this.allStafOptions.Click += new System.EventHandler(this.allStafOptions_Click);
            // 
            // allCustomersButton
            // 
            this.allCustomersButton.Location = new System.Drawing.Point(94, 21);
            this.allCustomersButton.Name = "allCustomersButton";
            this.allCustomersButton.Size = new System.Drawing.Size(87, 23);
            this.allCustomersButton.TabIndex = 1;
            this.allCustomersButton.Text = "Customers";
            this.allCustomersButton.UseVisualStyleBackColor = true;
            this.allCustomersButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // allHorsebutton
            // 
            this.allHorsebutton.Location = new System.Drawing.Point(13, 22);
            this.allHorsebutton.Name = "allHorsebutton";
            this.allHorsebutton.Size = new System.Drawing.Size(75, 23);
            this.allHorsebutton.TabIndex = 0;
            this.allHorsebutton.Text = "Horses";
            this.allHorsebutton.UseVisualStyleBackColor = true;
            this.allHorsebutton.Click += new System.EventHandler(this.allHorsebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(610, 367);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Request Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeSalaryButton;
        private System.Windows.Forms.Button lowSalaryButton;
        private System.Windows.Forms.Button numberOfStaffButton;
        private System.Windows.Forms.Button maxSalaryButton;
        private System.Windows.Forms.Button allVisitsButton;
        private System.Windows.Forms.Button allPaymentsButton;
        private System.Windows.Forms.Button allStafOptions;
        private System.Windows.Forms.Button allCustomersButton;
        private System.Windows.Forms.Button allHorsebutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}