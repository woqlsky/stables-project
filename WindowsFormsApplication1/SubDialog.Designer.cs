namespace WindowsFormsApplication1
{
    partial class SubDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.customerButton = new System.Windows.Forms.Button();
            this.staffButton = new System.Windows.Forms.Button();
            this.horseButton = new System.Windows.Forms.Button();
            this.visitButton = new System.Windows.Forms.Button();
            this.paymentButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would You like to change?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(93, 124);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(97, 33);
            this.customerButton.TabIndex = 1;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // staffButton
            // 
            this.staffButton.Location = new System.Drawing.Point(93, 180);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(97, 34);
            this.staffButton.TabIndex = 2;
            this.staffButton.Text = "Staff";
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.staffButton_Click);
            // 
            // horseButton
            // 
            this.horseButton.Location = new System.Drawing.Point(93, 234);
            this.horseButton.Name = "horseButton";
            this.horseButton.Size = new System.Drawing.Size(97, 31);
            this.horseButton.TabIndex = 3;
            this.horseButton.Text = "Horse";
            this.horseButton.UseVisualStyleBackColor = true;
            this.horseButton.Click += new System.EventHandler(this.horseButton_Click);
            // 
            // visitButton
            // 
            this.visitButton.Location = new System.Drawing.Point(93, 282);
            this.visitButton.Name = "visitButton";
            this.visitButton.Size = new System.Drawing.Size(97, 32);
            this.visitButton.TabIndex = 4;
            this.visitButton.Text = "Visit";
            this.visitButton.UseVisualStyleBackColor = true;
            this.visitButton.Click += new System.EventHandler(this.visitButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(93, 334);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(97, 30);
            this.paymentButton.TabIndex = 5;
            this.paymentButton.Text = "Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(318, 427);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(201, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back to main menu";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // SubDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(590, 497);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.visitButton);
            this.Controls.Add(this.horseButton);
            this.Controls.Add(this.staffButton);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button horseButton;
        private System.Windows.Forms.Button visitButton;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button backButton;
    }
}