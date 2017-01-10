namespace WindowsFormsApplication1.ChangeViews
{
    partial class PaymentView
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.visitLabel = new System.Windows.Forms.Label();
            this.overalLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.visitBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(28, 159);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(163, 159);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // visitLabel
            // 
            this.visitLabel.AutoSize = true;
            this.visitLabel.Location = new System.Drawing.Point(25, 44);
            this.visitLabel.Name = "visitLabel";
            this.visitLabel.Size = new System.Drawing.Size(86, 17);
            this.visitLabel.TabIndex = 2;
            this.visitLabel.Text = "Choose Visit";
            // 
            // overalLabel
            // 
            this.overalLabel.AutoSize = true;
            this.overalLabel.Location = new System.Drawing.Point(28, 96);
            this.overalLabel.Name = "overalLabel";
            this.overalLabel.Size = new System.Drawing.Size(85, 17);
            this.overalLabel.TabIndex = 3;
            this.overalLabel.Text = "Overall Cost";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // visitBox
            // 
            this.visitBox.FormattingEnabled = true;
            this.visitBox.Location = new System.Drawing.Point(153, 44);
            this.visitBox.Name = "visitBox";
            this.visitBox.Size = new System.Drawing.Size(100, 24);
            this.visitBox.TabIndex = 6;
            // 
            // PaymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 213);
            this.Controls.Add(this.visitBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.overalLabel);
            this.Controls.Add(this.visitLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label visitLabel;
        private System.Windows.Forms.Label overalLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox visitBox;
    }
}