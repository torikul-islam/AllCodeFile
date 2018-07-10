namespace Library_Management
{
    partial class add_books
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
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.lblAuthorname = new System.Windows.Forms.Label();
            this.lblPublicationName = new System.Windows.Forms.Label();
            this.lblPur = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtahorName = new System.Windows.Forms.TextBox();
            this.txtpublicationName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuartity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(107, 49);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(63, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Book Name";
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(244, 46);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(178, 20);
            this.txtbookname.TabIndex = 1;
            // 
            // lblAuthorname
            // 
            this.lblAuthorname.AutoSize = true;
            this.lblAuthorname.Location = new System.Drawing.Point(107, 91);
            this.lblAuthorname.Name = "lblAuthorname";
            this.lblAuthorname.Size = new System.Drawing.Size(97, 13);
            this.lblAuthorname.TabIndex = 2;
            this.lblAuthorname.Text = "Book Author Name";
            // 
            // lblPublicationName
            // 
            this.lblPublicationName.AutoSize = true;
            this.lblPublicationName.Location = new System.Drawing.Point(107, 134);
            this.lblPublicationName.Name = "lblPublicationName";
            this.lblPublicationName.Size = new System.Drawing.Size(118, 13);
            this.lblPublicationName.TabIndex = 3;
            this.lblPublicationName.Text = "Book Publication Name";
            // 
            // lblPur
            // 
            this.lblPur.AutoSize = true;
            this.lblPur.Location = new System.Drawing.Point(107, 181);
            this.lblPur.Name = "lblPur";
            this.lblPur.Size = new System.Drawing.Size(106, 13);
            this.lblPur.TabIndex = 4;
            this.lblPur.Text = "Book Purchase Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Book Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Book Quantity";
            // 
            // txtahorName
            // 
            this.txtahorName.Location = new System.Drawing.Point(244, 84);
            this.txtahorName.Name = "txtahorName";
            this.txtahorName.Size = new System.Drawing.Size(178, 20);
            this.txtahorName.TabIndex = 7;
            // 
            // txtpublicationName
            // 
            this.txtpublicationName.Location = new System.Drawing.Point(244, 127);
            this.txtpublicationName.Name = "txtpublicationName";
            this.txtpublicationName.Size = new System.Drawing.Size(178, 20);
            this.txtpublicationName.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(244, 220);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(178, 20);
            this.txtPrice.TabIndex = 11;
            // 
            // txtQuartity
            // 
            this.txtQuartity.Location = new System.Drawing.Point(244, 255);
            this.txtQuartity.Name = "txtQuartity";
            this.txtQuartity.Size = new System.Drawing.Size(178, 20);
            this.txtQuartity.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 23);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // add_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 367);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtQuartity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtpublicationName);
            this.Controls.Add(this.txtahorName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPur);
            this.Controls.Add(this.lblPublicationName);
            this.Controls.Add(this.lblAuthorname);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.lblBookName);
            this.Name = "add_books";
            this.Text = "add_books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label lblAuthorname;
        private System.Windows.Forms.Label lblPublicationName;
        private System.Windows.Forms.Label lblPur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtahorName;
        private System.Windows.Forms.TextBox txtpublicationName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuartity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}