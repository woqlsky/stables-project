namespace WindowsFormsApplication1.ChangeViews
{
    partial class VisitView
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
            this.visitorLabel = new System.Windows.Forms.Label();
            this.horseLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.horseCombo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // visitorLabel
            // 
            this.visitorLabel.AutoSize = true;
            this.visitorLabel.Location = new System.Drawing.Point(13, 45);
            this.visitorLabel.Name = "visitorLabel";
            this.visitorLabel.Size = new System.Drawing.Size(97, 17);
            this.visitorLabel.TabIndex = 0;
            this.visitorLabel.Text = "Choose visitor";
            // 
            // horseLabel
            // 
            this.horseLabel.AutoSize = true;
            this.horseLabel.Location = new System.Drawing.Point(16, 89);
            this.horseLabel.Name = "horseLabel";
            this.horseLabel.Size = new System.Drawing.Size(98, 17);
            this.horseLabel.TabIndex = 1;
            this.horseLabel.Text = "Choose Horse";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(19, 129);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(83, 17);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "Choose day";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(41, 190);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(156, 190);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // customerCombo
            // 
            this.customerCombo.FormattingEnabled = true;
            this.customerCombo.Location = new System.Drawing.Point(138, 45);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(121, 24);
            this.customerCombo.TabIndex = 5;
            // 
            // horseCombo
            // 
            this.horseCombo.FormattingEnabled = true;
            this.horseCombo.Location = new System.Drawing.Point(138, 89);
            this.horseCombo.Name = "horseCombo";
            this.horseCombo.Size = new System.Drawing.Size(121, 24);
            this.horseCombo.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2016, 4, 17, 0, 0, 0, 0);
            // 
            // VisitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 241);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.horseCombo);
            this.Controls.Add(this.customerCombo);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.horseLabel);
            this.Controls.Add(this.visitorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VisitView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VisitView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label visitorLabel;
        private System.Windows.Forms.Label horseLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.ComboBox horseCombo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}