namespace bookStore
{
    partial class frmBook
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            tbSearch = new TextBox();
            dgvList = new DataGridView();
            tabPage2 = new TabPage();
            groupBox1 = new GroupBox();
            tbBookEdition = new TextBox();
            label6 = new Label();
            tbBookDesc = new TextBox();
            label5 = new Label();
            tbBookAuthor = new TextBox();
            label4 = new Label();
            tbBookName = new TextBox();
            label3 = new Label();
            tbBookID = new TextBox();
            label2 = new Label();
            btnNew = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(493, 311);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tbSearch);
            tabPage1.Controls.Add(dgvList);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(485, 283);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Book List";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Enter += tabPage1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Search :";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(60, 4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(221, 23);
            tbSearch.TabIndex = 1;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.BackgroundColor = SystemColors.Control;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(6, 30);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(470, 250);
            dgvList.TabIndex = 0;
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(485, 283);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Book Entry";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbBookEdition);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbBookDesc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbBookAuthor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbBookName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbBookID);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(4, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 278);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detail";
            // 
            // tbBookEdition
            // 
            tbBookEdition.Location = new Point(118, 190);
            tbBookEdition.Name = "tbBookEdition";
            tbBookEdition.Size = new Size(139, 23);
            tbBookEdition.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 193);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 12;
            label6.Text = "Edition :";
            // 
            // tbBookDesc
            // 
            tbBookDesc.Location = new Point(118, 119);
            tbBookDesc.Multiline = true;
            tbBookDesc.Name = "tbBookDesc";
            tbBookDesc.Size = new Size(285, 65);
            tbBookDesc.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 122);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 10;
            label5.Text = "Book Description :";
            // 
            // tbBookAuthor
            // 
            tbBookAuthor.Location = new Point(118, 90);
            tbBookAuthor.Name = "tbBookAuthor";
            tbBookAuthor.Size = new Size(285, 23);
            tbBookAuthor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 93);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "Book Author :";
            // 
            // tbBookName
            // 
            tbBookName.Location = new Point(118, 61);
            tbBookName.Name = "tbBookName";
            tbBookName.Size = new Size(285, 23);
            tbBookName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 64);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 6;
            label3.Text = "Book Name :";
            // 
            // tbBookID
            // 
            tbBookID.Location = new Point(118, 32);
            tbBookID.Name = "tbBookID";
            tbBookID.Size = new Size(285, 23);
            tbBookID.TabIndex = 5;
            tbBookID.Validated += tbBookID_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 35);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Book ID :";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(14, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 1;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(105, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(292, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(382, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 338);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(tabControl1);
            Name = "frmBook";
            Text = "Book";
            Activated += frmBook_Activated;
            Load += frmBook_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvList;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Button btnNew;
        private Button btnEdit;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tbBookEdition;
        private Label label6;
        private TextBox tbBookDesc;
        private Label label5;
        private TextBox tbBookAuthor;
        private Label label4;
        private TextBox tbBookName;
        private Label label3;
        private TextBox tbBookID;
        private Label label2;
        private TextBox tbSearch;
    }
}