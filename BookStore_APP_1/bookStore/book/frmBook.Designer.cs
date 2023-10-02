﻿namespace bookStore
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            label2 = new Label();
            tbBookID = new TextBox();
            label3 = new Label();
            tbBookName = new TextBox();
            label4 = new Label();
            tbBookAuthor = new TextBox();
            label5 = new Label();
            tbBookDesc = new TextBox();
            label6 = new Label();
            tbBookEdition = new TextBox();
            dgvList = new DataGridView();
            tbSearch = new TextBox();
            label7 = new Label();
            btnNew = new Button();
            btnEdit = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(215, 23);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 25);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Book ID :";
            // 
            // tbBookID
            // 
            tbBookID.Location = new Point(115, 22);
            tbBookID.Name = "tbBookID";
            tbBookID.Size = new Size(169, 23);
            tbBookID.TabIndex = 0;
            tbBookID.Validated += tbBookID_Validated;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 59);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 6;
            label3.Text = "Book Name :";
            // 
            // tbBookName
            // 
            tbBookName.CharacterCasing = CharacterCasing.Upper;
            tbBookName.Location = new Point(115, 56);
            tbBookName.Name = "tbBookName";
            tbBookName.Size = new Size(169, 23);
            tbBookName.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 93);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "Book Author :";
            // 
            // tbBookAuthor
            // 
            tbBookAuthor.CharacterCasing = CharacterCasing.Upper;
            tbBookAuthor.Location = new Point(115, 90);
            tbBookAuthor.Name = "tbBookAuthor";
            tbBookAuthor.Size = new Size(169, 23);
            tbBookAuthor.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 127);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 10;
            label5.Text = "Book Description :";
            // 
            // tbBookDesc
            // 
            tbBookDesc.CharacterCasing = CharacterCasing.Upper;
            tbBookDesc.Location = new Point(115, 124);
            tbBookDesc.Multiline = true;
            tbBookDesc.Name = "tbBookDesc";
            tbBookDesc.Size = new Size(169, 53);
            tbBookDesc.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 189);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 12;
            label6.Text = "Edition :";
            // 
            // tbBookEdition
            // 
            tbBookEdition.Location = new Point(115, 186);
            tbBookEdition.Name = "tbBookEdition";
            tbBookEdition.Size = new Size(169, 23);
            tbBookEdition.TabIndex = 8;
            tbBookEdition.KeyPress += tbBookEdition_KeyPress;
            // 
            // dgvList
            // 
            dgvList.AllowUserToAddRows = false;
            dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = Color.AliceBlue;
            dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvList.BackgroundColor = Color.White;
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvList.DefaultCellStyle = dataGridViewCellStyle4;
            dgvList.Location = new Point(3, 45);
            dgvList.Name = "dgvList";
            dgvList.ReadOnly = true;
            dgvList.RowHeadersVisible = false;
            dgvList.RowTemplate.Height = 25;
            dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvList.Size = new Size(455, 398);
            dgvList.TabIndex = 14;
            dgvList.CellDoubleClick += dgvList_CellDoubleClick;
            // 
            // tbSearch
            // 
            tbSearch.CharacterCasing = CharacterCasing.Upper;
            tbSearch.Location = new Point(85, 16);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(205, 23);
            tbSearch.TabIndex = 13;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(4, 19);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 15;
            label7.Text = "Search Book :";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.ForestGreen;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(7, 242);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(61, 30);
            btnNew.TabIndex = 16;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkCyan;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(74, 242);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(61, 30);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(tbBookID);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(tbBookAuthor);
            groupBox1.Controls.Add(btnNew);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbBookName);
            groupBox1.Controls.Add(tbBookDesc);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tbBookEdition);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(3, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(345, 450);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightCoral;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(275, 242);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(61, 30);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(208, 242);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(61, 30);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LightSeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(141, 242);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(61, 30);
            btnSave.TabIndex = 18;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbSearch);
            groupBox2.Controls.Add(dgvList);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(354, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(460, 449);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // frmBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 451);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmBook";
            Text = "Book";
            Activated += frmBook_Activated;
            Load += frmBook_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox1;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private Label label2;
        private TextBox tbBookID;
        private Label label3;
        private TextBox tbBookName;
        private Label label4;
        private TextBox tbBookAuthor;
        private Label label5;
        private TextBox tbBookDesc;
        private Label label6;
        private TextBox tbBookEdition;
        private DataGridView dgvList;
        private TextBox tbSearch;
        private Label label7;
        private Button btnNew;
        private Button btnEdit;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
    }
}