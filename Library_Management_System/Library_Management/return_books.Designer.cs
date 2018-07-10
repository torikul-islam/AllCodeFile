namespace Library_Management
{
    partial class return_books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchbooks = new System.Windows.Forms.Button();
            this.txtEnrNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRtnBooks = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblBooksName = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblissue = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchbooks);
            this.panel1.Controls.Add(this.txtEnrNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 133);
            this.panel1.TabIndex = 0;
            // 
            // btnSearchbooks
            // 
            this.btnSearchbooks.Location = new System.Drawing.Point(83, 83);
            this.btnSearchbooks.Name = "btnSearchbooks";
            this.btnSearchbooks.Size = new System.Drawing.Size(113, 31);
            this.btnSearchbooks.TabIndex = 2;
            this.btnSearchbooks.Text = "Search Books";
            this.btnSearchbooks.UseVisualStyleBackColor = true;
            this.btnSearchbooks.Click += new System.EventHandler(this.btnSearchbooks_Click);
            // 
            // txtEnrNo
            // 
            this.txtEnrNo.Location = new System.Drawing.Point(95, 31);
            this.txtEnrNo.Name = "txtEnrNo";
            this.txtEnrNo.Size = new System.Drawing.Size(118, 20);
            this.txtEnrNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eorollment No";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(283, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 250);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblissue);
            this.panel3.Controls.Add(this.lblBookName);
            this.panel3.Controls.Add(this.btnRtnBooks);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.lblIssueDate);
            this.panel3.Controls.Add(this.lblReturnDate);
            this.panel3.Controls.Add(this.lblBooksName);
            this.panel3.Location = new System.Drawing.Point(174, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(655, 235);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // btnRtnBooks
            // 
            this.btnRtnBooks.Location = new System.Drawing.Point(228, 185);
            this.btnRtnBooks.Name = "btnRtnBooks";
            this.btnRtnBooks.Size = new System.Drawing.Size(113, 31);
            this.btnRtnBooks.TabIndex = 7;
            this.btnRtnBooks.Text = "Return Books";
            this.btnRtnBooks.UseVisualStyleBackColor = true;
            this.btnRtnBooks.Click += new System.EventHandler(this.btnRtnBooks_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.Location = new System.Drawing.Point(56, 71);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(72, 16);
            this.lblIssueDate.TabIndex = 5;
            this.lblIssueDate.Text = "Issue Date";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.Location = new System.Drawing.Point(46, 130);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(120, 16);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Select Return Date";
            // 
            // lblBooksName
            // 
            this.lblBooksName.AutoSize = true;
            this.lblBooksName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooksName.Location = new System.Drawing.Point(56, 28);
            this.lblBooksName.Name = "lblBooksName";
            this.lblBooksName.Size = new System.Drawing.Size(87, 16);
            this.lblBooksName.TabIndex = 1;
            this.lblBooksName.Text = "Books Name";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(191, 28);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(45, 16);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "label2";
            // 
            // lblissue
            // 
            this.lblissue.AutoSize = true;
            this.lblissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblissue.Location = new System.Drawing.Point(191, 71);
            this.lblissue.Name = "lblissue";
            this.lblissue.Size = new System.Drawing.Size(45, 16);
            this.lblissue.TabIndex = 8;
            this.lblissue.Text = "label3";
            // 
            // return_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 587);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "return_books";
            this.Text = "return_books1";
            this.Load += new System.EventHandler(this.return_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchbooks;
        private System.Windows.Forms.TextBox txtEnrNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRtnBooks;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblBooksName;
        private System.Windows.Forms.Label lblissue;
        private System.Windows.Forms.Label lblBookName;
    }
}