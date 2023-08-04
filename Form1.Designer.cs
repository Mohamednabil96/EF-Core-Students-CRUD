namespace Task_Day_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            dgvStudents = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label6 = new Label();
            comboDept = new ComboBox();
            comboSuper = new ComboBox();
            lbl_status = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtFName
            // 
            txtFName.Location = new Point(283, 32);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(200, 27);
            txtFName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 32);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "FName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 93);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "LName:";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(283, 93);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(200, 27);
            txtLName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 161);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 5;
            label3.Text = "Age:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(283, 161);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(200, 27);
            txtAge.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(685, 35);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 7;
            label4.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(784, 35);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(206, 27);
            txtAddress.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(685, 167);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 9;
            label5.Text = "Department:";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Dock = DockStyle.Bottom;
            dgvStudents.Location = new Point(0, 315);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.RowTemplate.Height = 29;
            dgvStudents.Size = new Size(1247, 396);
            dgvStudents.TabIndex = 10;
            dgvStudents.RowHeaderMouseDoubleClick += dgvStudents_RowHeaderMouseDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Location = new Point(470, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Green;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.Snow;
            btnUpdate.Location = new Point(601, 263);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(730, 263);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(685, 96);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 15;
            label6.Text = "Supervisor:";
            // 
            // comboDept
            // 
            comboDept.FormattingEnabled = true;
            comboDept.Location = new Point(784, 167);
            comboDept.Name = "comboDept";
            comboDept.Size = new Size(206, 28);
            comboDept.TabIndex = 16;
            // 
            // comboSuper
            // 
            comboSuper.FormattingEnabled = true;
            comboSuper.Location = new Point(784, 96);
            comboSuper.Name = "comboSuper";
            comboSuper.Size = new Size(206, 28);
            comboSuper.TabIndex = 17;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(1007, 247);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(0, 20);
            lbl_status.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 711);
            Controls.Add(lbl_status);
            Controls.Add(comboSuper);
            Controls.Add(comboDept);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvStudents);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtAddress);
            Controls.Add(label3);
            Controls.Add(txtAge);
            Controls.Add(label2);
            Controls.Add(txtLName);
            Controls.Add(label1);
            Controls.Add(txtFName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFName;
        private Label label1;
        private Label label2;
        private TextBox txtLName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private DataGridView dgvStudents;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label6;
        private TextBox txtSupervisor;
        private ComboBox comboDept;
        private ComboBox comboSuper;
        private Label lbl_status;
    }
}