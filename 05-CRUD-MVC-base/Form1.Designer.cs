namespace _05_CRUD_MVC_base
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
            lblID = new Label();
            lblName = new Label();
            lblLastName = new Label();
            lblBirthDate = new Label();
            btnLoad = new Button();
            btnAdd = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            dtpBirthDate = new DateTimePicker();
            dgvEmployees = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(24, 173);
            lblID.Name = "lblID";
            lblID.Size = new Size(21, 15);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(24, 201);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(24, 234);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(54, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Apellido:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(24, 266);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(69, 15);
            lblBirthDate.TabIndex = 3;
            lblBirthDate.Text = "Nacmiento:";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(366, 169);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Cargar";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(366, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Insertar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(366, 231);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 6;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(366, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Borrar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(89, 170);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(89, 204);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(89, 237);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 10;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(89, 266);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 11;
            // 
            // dgvEmployees
            // 
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(12, 12);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(447, 142);
            dgvEmployees.TabIndex = 12;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 314);
            Controls.Add(dgvEmployees);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Controls.Add(lblBirthDate);
            Controls.Add(lblLastName);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblName;
        private Label lblLastName;
        private Label lblBirthDate;
        private Button btnLoad;
        private Button btnAdd;
        private Button btnModify;
        private Button btnDelete;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtLastName;
        private DateTimePicker dtpBirthDate;
        private DataGridView dgvEmployees;
    }
}
