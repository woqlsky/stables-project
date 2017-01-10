namespace WindowsFormsApplication1.Change
{
    partial class PaymentChange
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
            this.actionBox = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.changeGridView = new System.Windows.Forms.DataGridView();
            this.actionBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionBox
            // 
            this.actionBox.Controls.Add(this.backButton);
            this.actionBox.Controls.Add(this.deleteButton);
            this.actionBox.Controls.Add(this.updateButton);
            this.actionBox.Controls.Add(this.addButton);
            this.actionBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionBox.Location = new System.Drawing.Point(0, 277);
            this.actionBox.Name = "actionBox";
            this.actionBox.Size = new System.Drawing.Size(520, 82);
            this.actionBox.TabIndex = 0;
            this.actionBox.TabStop = false;
            this.actionBox.Text = "Choose an action";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(426, 34);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 36);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(318, 34);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 36);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(204, 34);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 36);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(90, 34);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 36);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // changeGridView
            // 
            this.changeGridView.AllowUserToAddRows = false;
            this.changeGridView.AllowUserToDeleteRows = false;
            this.changeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.changeGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeGridView.Location = new System.Drawing.Point(0, 0);
            this.changeGridView.MultiSelect = false;
            this.changeGridView.Name = "changeGridView";
            this.changeGridView.ReadOnly = true;
            this.changeGridView.RowTemplate.Height = 24;
            this.changeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.changeGridView.Size = new System.Drawing.Size(520, 277);
            this.changeGridView.TabIndex = 1;
            // 
            // PaymentChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 359);
            this.Controls.Add(this.changeGridView);
            this.Controls.Add(this.actionBox);
            this.Name = "PaymentChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PaymentChange";
            this.actionBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox actionBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView changeGridView;
    }
}