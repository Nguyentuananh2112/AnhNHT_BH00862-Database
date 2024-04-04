namespace QLSVdatabase
{
    partial class frmListTeacher
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.dgvListTeacher = new System.Windows.Forms.DataGridView();
            this.delTeacher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsearch.Location = new System.Drawing.Point(304, 43);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(364, 22);
            this.txtsearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(304, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddnew.Location = new System.Drawing.Point(593, 82);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(75, 23);
            this.btnAddnew.TabIndex = 3;
            this.btnAddnew.Text = "Add New";
            this.btnAddnew.UseVisualStyleBackColor = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // dgvListTeacher
            // 
            this.dgvListTeacher.AllowUserToAddRows = false;
            this.dgvListTeacher.AllowUserToDeleteRows = false;
            this.dgvListTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTeacher.Location = new System.Drawing.Point(0, 164);
            this.dgvListTeacher.MultiSelect = false;
            this.dgvListTeacher.Name = "dgvListTeacher";
            this.dgvListTeacher.ReadOnly = true;
            this.dgvListTeacher.RowHeadersWidth = 51;
            this.dgvListTeacher.RowTemplate.Height = 24;
            this.dgvListTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListTeacher.Size = new System.Drawing.Size(981, 320);
            this.dgvListTeacher.TabIndex = 4;
            this.dgvListTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTeacher_CellContentClick);
            this.dgvListTeacher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTeacher_CellDoubleClick);
            this.dgvListTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListTeacher_CellClick);

            // 
            // delTeacher
            // 
            this.delTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delTeacher.Location = new System.Drawing.Point(793, 82);
            this.delTeacher.Name = "delTeacher";
            this.delTeacher.Size = new System.Drawing.Size(75, 23);
            this.delTeacher.TabIndex = 5;
            this.delTeacher.Text = "Delete";
            this.delTeacher.UseVisualStyleBackColor = true;
            this.delTeacher.Click += new System.EventHandler(this.delTeacher_Click);
            // 
            // frmListTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 484);
            this.Controls.Add(this.delTeacher);
            this.Controls.Add(this.dgvListTeacher);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Name = "frmListTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Teacher";
            this.Load += new System.EventHandler(this.frmListTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.DataGridView dgvListTeacher;
        private System.Windows.Forms.Button delTeacher;
    }
}