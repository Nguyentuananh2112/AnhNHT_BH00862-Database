namespace QLSVdatabase
{
    partial class frmListStudent
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
            this.dgvstudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.delStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstudent
            // 
            this.dgvstudent.AllowUserToAddRows = false;
            this.dgvstudent.AllowUserToDeleteRows = false;
            this.dgvstudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvstudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudent.Location = new System.Drawing.Point(0, 181);
            this.dgvstudent.MultiSelect = false;
            this.dgvstudent.Name = "dgvstudent";
            this.dgvstudent.ReadOnly = true;
            this.dgvstudent.RowHeadersWidth = 51;
            this.dgvstudent.RowTemplate.Height = 24;
            this.dgvstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstudent.Size = new System.Drawing.Size(800, 269);
            this.dgvstudent.TabIndex = 0;
            this.dgvstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudent_CellContentClick);
            this.dgvstudent.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudent_CellContentDoubleClick);
            this.dgvstudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStudent_CellClick);

            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Keyword";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyword.Location = new System.Drawing.Point(278, 64);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(280, 22);
            this.txtKeyword.TabIndex = 2;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(278, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnew.Location = new System.Drawing.Point(483, 124);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 23);
            this.btnAddnew.TabIndex = 4;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // delStudent
            // 
            this.delStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delStudent.Location = new System.Drawing.Point(634, 124);
            this.delStudent.Name = "delStudent";
            this.delStudent.Size = new System.Drawing.Size(75, 23);
            this.delStudent.TabIndex = 5;
            this.delStudent.Text = "Delete";
            this.delStudent.UseVisualStyleBackColor = true;
            this.delStudent.Click += new System.EventHandler(this.delStudent_Click);
            // 
            // frmListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delStudent);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvstudent);
            this.Name = "frmListStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Student";
            this.Load += new System.EventHandler(this.frmListStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button delStudent;
    }
}