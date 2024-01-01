namespace CRUD_EF_TS2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgcustomer = new System.Windows.Forms.DataGridView();
            this.dgCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName";
            // 
            // textFName
            // 
            this.textFName.Location = new System.Drawing.Point(129, 39);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(100, 20);
            this.textFName.TabIndex = 1;
            // 
            // textLName
            // 
            this.textLName.Location = new System.Drawing.Point(129, 88);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(100, 20);
            this.textLName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(129, 124);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 20);
            this.textCity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "City";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(129, 171);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 56);
            this.textAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(110, 305);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(92, 44);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(208, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 44);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgcustomer
            // 
            this.dgcustomer.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgCustomerId,
            this.FirstName,
            this.lastName,
            this.city});
            this.dgcustomer.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dgcustomer.Location = new System.Drawing.Point(306, 33);
            this.dgcustomer.Name = "dgcustomer";
            this.dgcustomer.Size = new System.Drawing.Size(492, 394);
            this.dgcustomer.TabIndex = 12;
            this.dgcustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgcustomer_CellContentClick);
            // 
            // dgCustomerId
            // 
            this.dgCustomerId.DataPropertyName = "IDCus";
            this.dgCustomerId.HeaderText = "CustomerID";
            this.dgCustomerId.Name = "dgCustomerId";
            this.dgCustomerId.ReadOnly = true;
            this.dgCustomerId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "first name";
            this.FirstName.Name = "FirstName";
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "last name";
            this.lastName.Name = "lastName";
            // 
            // city
            // 
            this.city.DataPropertyName = "City";
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgcustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
    }
}

