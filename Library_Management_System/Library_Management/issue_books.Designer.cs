namespace Library_Management
{
    partial class issue_books
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtStdDept = new System.Windows.Forms.TextBox();
            this.txtStdSemi = new System.Windows.Forms.TextBox();
            this.txtStdCont = new System.Windows.Forms.TextBox();
            this.txtStdEmail = new System.Windows.Forms.TextBox();
            this.txtstdName = new System.Windows.Forms.TextBox();
            this.btnSearchStd = new System.Windows.Forms.Button();
            this.txtSerchStd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnIssueBook);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBookName);
            this.panel1.Controls.Add(this.txtStdDept);
            this.panel1.Controls.Add(this.txtStdSemi);
            this.panel1.Controls.Add(this.txtStdCont);
            this.panel1.Controls.Add(this.txtStdEmail);
            this.panel1.Controls.Add(this.txtstdName);
            this.panel1.Controls.Add(this.btnSearchStd);
            this.panel1.Controls.Add(this.txtSerchStd);
            this.panel1.Location = new System.Drawing.Point(67, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 484);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(466, 320);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 82);
            this.listBox1.TabIndex = 20;
            this.listBox1.Visible = false;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(372, 422);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(100, 33);
            this.btnIssueBook.TabIndex = 19;
            this.btnIssueBook.Text = "Issue Books";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Enter Enrollment No";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(466, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Books Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Issue Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student Semister";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student Contact ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Student Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Student Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Student Name";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(466, 294);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(179, 20);
            this.txtBookName.TabIndex = 8;
            this.txtBookName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBookName_KeyDown);
            this.txtBookName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBookName_KeyUp);
            // 
            // txtStdDept
            // 
            this.txtStdDept.Location = new System.Drawing.Point(466, 88);
            this.txtStdDept.Name = "txtStdDept";
            this.txtStdDept.Size = new System.Drawing.Size(179, 20);
            this.txtStdDept.TabIndex = 7;
            // 
            // txtStdSemi
            // 
            this.txtStdSemi.Location = new System.Drawing.Point(466, 130);
            this.txtStdSemi.Name = "txtStdSemi";
            this.txtStdSemi.Size = new System.Drawing.Size(179, 20);
            this.txtStdSemi.TabIndex = 6;
            // 
            // txtStdCont
            // 
            this.txtStdCont.Location = new System.Drawing.Point(466, 172);
            this.txtStdCont.Name = "txtStdCont";
            this.txtStdCont.Size = new System.Drawing.Size(179, 20);
            this.txtStdCont.TabIndex = 5;
            // 
            // txtStdEmail
            // 
            this.txtStdEmail.Location = new System.Drawing.Point(466, 210);
            this.txtStdEmail.Name = "txtStdEmail";
            this.txtStdEmail.Size = new System.Drawing.Size(179, 20);
            this.txtStdEmail.TabIndex = 4;
            // 
            // txtstdName
            // 
            this.txtstdName.Location = new System.Drawing.Point(466, 43);
            this.txtstdName.Name = "txtstdName";
            this.txtstdName.Size = new System.Drawing.Size(179, 20);
            this.txtstdName.TabIndex = 2;
            // 
            // btnSearchStd
            // 
            this.btnSearchStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStd.Location = new System.Drawing.Point(64, 144);
            this.btnSearchStd.Name = "btnSearchStd";
            this.btnSearchStd.Size = new System.Drawing.Size(121, 31);
            this.btnSearchStd.TabIndex = 1;
            this.btnSearchStd.Text = "Search Student";
            this.btnSearchStd.UseVisualStyleBackColor = true;
            this.btnSearchStd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSerchStd
            // 
            this.txtSerchStd.Location = new System.Drawing.Point(38, 99);
            this.txtSerchStd.Name = "txtSerchStd";
            this.txtSerchStd.Size = new System.Drawing.Size(200, 20);
            this.txtSerchStd.TabIndex = 0;
            this.txtSerchStd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerchStd_KeyUp);
            // 
            // issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 562);
            this.Controls.Add(this.panel1);
            this.Name = "issue_books";
            this.Text = "issue_books";
            this.Load += new System.EventHandler(this.issue_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchStd;
        private System.Windows.Forms.TextBox txtSerchStd;
        private System.Windows.Forms.TextBox txtstdName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtStdDept;
        private System.Windows.Forms.TextBox txtStdSemi;
        private System.Windows.Forms.TextBox txtStdCont;
        private System.Windows.Forms.TextBox txtStdEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.ListBox listBox1;
    }
}