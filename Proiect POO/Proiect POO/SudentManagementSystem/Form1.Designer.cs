namespace SudentManagementSystem
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
            btnRefresh = new Button();
            label7 = new Label();
            txtSearch = new TextBox();
            Male = new RadioButton();
            Female = new RadioButton();
            Exit = new Button();
            label2 = new Label();
            label1 = new Label();
            Email = new TextBox();
            label4 = new Label();
            Mobile = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            Age = new TextBox();
            lebel2 = new Label();
            lebel = new Label();
            StudentClass = new ComboBox();
            Date = new DateTimePicker();
            delete = new Button();
            update = new Button();
            save = new Button();
            Column9 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            StudentName = new TextBox();
            StudentDataGridView = new DataGridView();
            Other = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRefresh.Location = new Point(83, 424);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 40;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(597, 111);
            label7.Name = "label7";
            label7.Size = new Size(106, 15);
            label7.TabIndex = 39;
            label7.Text = "Cauta dupa nume:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(599, 129);
            txtSearch.Name = "txtSearch";
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.Size = new Size(185, 23);
            txtSearch.TabIndex = 38;
            txtSearch.KeyUp += txtSearch_KeyUp;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Location = new Point(597, 83);
            Male.Name = "Male";
            Male.RightToLeft = RightToLeft.No;
            Male.Size = new Size(36, 19);
            Male.TabIndex = 28;
            Male.TabStop = true;
            Male.Text = "M";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += male_CheckedChanged;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Location = new Point(654, 83);
            Female.Name = "Female";
            Female.RightToLeft = RightToLeft.No;
            Female.Size = new Size(31, 19);
            Female.TabIndex = 30;
            Female.TabStop = true;
            Female.Text = "F";
            Female.UseVisualStyleBackColor = true;
            Female.CheckedChanged += female_CheckedChanged;
            // 
            // Exit
            // 
            Exit.BackColor = Color.LightGray;
            Exit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.Location = new Point(5, 423);
            Exit.Margin = new Padding(0);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 37;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(205, 108);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(83, 15);
            label2.TabIndex = 33;
            label2.Text = "Admis la data:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(469, 37);
            label1.TabIndex = 31;
            label1.Text = "Universitatea \"Transilvania\" Brasov";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Email
            // 
            Email.Location = new Point(4, 129);
            Email.Name = "Email";
            Email.RightToLeft = RightToLeft.No;
            Email.Size = new Size(194, 23);
            Email.TabIndex = 18;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 108);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(39, 15);
            label4.TabIndex = 29;
            label4.Text = "Email:";
            // 
            // Mobile
            // 
            Mobile.Location = new Point(205, 79);
            Mobile.Name = "Mobile";
            Mobile.RightToLeft = RightToLeft.No;
            Mobile.Size = new Size(194, 23);
            Mobile.TabIndex = 19;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(597, 61);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(31, 15);
            label6.TabIndex = 27;
            label6.Text = "Sex:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(407, 108);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(76, 15);
            label5.TabIndex = 26;
            label5.Text = "Specializare:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(205, 61);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(93, 15);
            label3.TabIndex = 25;
            label3.Text = "Numar Telefon:";
            // 
            // Age
            // 
            Age.Location = new Point(407, 79);
            Age.Name = "Age";
            Age.RightToLeft = RightToLeft.No;
            Age.Size = new Size(166, 23);
            Age.TabIndex = 21;
            // 
            // lebel2
            // 
            lebel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lebel2.AutoSize = true;
            lebel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lebel2.Location = new Point(407, 61);
            lebel2.Name = "lebel2";
            lebel2.RightToLeft = RightToLeft.No;
            lebel2.Size = new Size(44, 15);
            lebel2.TabIndex = 24;
            lebel2.Text = "Varsta:";
            // 
            // lebel
            // 
            lebel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lebel.AutoSize = true;
            lebel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lebel.Location = new Point(4, 61);
            lebel.Name = "lebel";
            lebel.RightToLeft = RightToLeft.No;
            lebel.Size = new Size(44, 15);
            lebel.TabIndex = 23;
            lebel.Text = "Nume:";
            lebel.Click += lebel_Click;
            // 
            // StudentClass
            // 
            StudentClass.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentClass.FormattingEnabled = true;
            StudentClass.Items.AddRange(new object[] { "AIA", "ROBO", "TI", "ETTI" });
            StudentClass.Location = new Point(407, 129);
            StudentClass.Name = "StudentClass";
            StudentClass.RightToLeft = RightToLeft.No;
            StudentClass.Size = new Size(166, 23);
            StudentClass.TabIndex = 22;
            // 
            // Date
            // 
            Date.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Date.Location = new Point(205, 129);
            Date.Name = "Date";
            Date.RightToLeft = RightToLeft.Yes;
            Date.Size = new Size(194, 23);
            Date.TabIndex = 20;
            // 
            // delete
            // 
            delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delete.Location = new Point(720, 423);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 36;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // update
            // 
            update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            update.Location = new Point(639, 423);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 35;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // save
            // 
            save.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            save.Location = new Point(558, 423);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 34;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Ad_date";
            Column9.FillWeight = 80F;
            Column9.HeaderText = "Date ";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 80;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Class";
            Column8.FillWeight = 80F;
            Column8.HeaderText = "Class";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 80;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Gender";
            Column7.FillWeight = 49F;
            Column7.HeaderText = "Gender";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 49;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Email";
            Column5.FillWeight = 180F;
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 180;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "MobileNumber";
            Column4.FillWeight = 120F;
            Column4.HeaderText = "Mobile Number";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 120;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Age";
            Column3.FillWeight = 51F;
            Column3.HeaderText = "Age";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 51;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Name";
            Column1.FillWeight = 161F;
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 161;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // StudentName
            // 
            StudentName.Location = new Point(4, 79);
            StudentName.Name = "StudentName";
            StudentName.RightToLeft = RightToLeft.No;
            StudentName.Size = new Size(194, 23);
            StudentName.TabIndex = 17;
            // 
            // StudentDataGridView
            // 
            StudentDataGridView.AllowUserToAddRows = false;
            StudentDataGridView.AllowUserToDeleteRows = false;
            StudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, Column3, Column4, Column5, Column7, Column8, Column9 });
            StudentDataGridView.Location = new Point(4, 173);
            StudentDataGridView.Name = "StudentDataGridView";
            StudentDataGridView.ReadOnly = true;
            StudentDataGridView.RightToLeft = RightToLeft.No;
            StudentDataGridView.RowHeadersVisible = false;
            StudentDataGridView.RowTemplate.Height = 25;
            StudentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentDataGridView.Size = new Size(793, 247);
            StudentDataGridView.TabIndex = 16;
            StudentDataGridView.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // Other
            // 
            Other.AutoSize = true;
            Other.Location = new Point(691, 83);
            Other.Name = "Other";
            Other.Size = new Size(51, 19);
            Other.TabIndex = 41;
            Other.TabStop = true;
            Other.Text = "Altul";
            Other.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Other);
            Controls.Add(btnRefresh);
            Controls.Add(label7);
            Controls.Add(txtSearch);
            Controls.Add(Male);
            Controls.Add(Female);
            Controls.Add(Exit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Email);
            Controls.Add(label4);
            Controls.Add(Mobile);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(Age);
            Controls.Add(lebel2);
            Controls.Add(lebel);
            Controls.Add(StudentClass);
            Controls.Add(Date);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(save);
            Controls.Add(StudentName);
            Controls.Add(StudentDataGridView);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "StudentiUnitBv";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRefresh;
        private Label label7;
        private TextBox txtSearch;
        private RadioButton Male;
        private RadioButton Female;
        private Button Exit;
        private Label label2;
        private Label label1;
        private TextBox Email;
        private Label label4;
        private TextBox Mobile;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox Age;
        private Label lebel2;
        private Label lebel;
        private ComboBox StudentClass;
        private DateTimePicker Date;
        private Button delete;
        private Button update;
        private Button save;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ID;
        private TextBox StudentName;
        private DataGridView StudentDataGridView;
        private RadioButton Other;
    }
}