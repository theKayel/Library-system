namespace LibrarySystem
{
    partial class Form1
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
            this.Titletxt = new System.Windows.Forms.TextBox();
            this.Authortxt = new System.Windows.Forms.TextBox();
            this.Titlelabel = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.Borrowbtn = new System.Windows.Forms.Button();
            this.Returntxt = new System.Windows.Forms.Button();
            this.Authorlabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titletxt
            // 
            this.Titletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titletxt.Location = new System.Drawing.Point(212, 139);
            this.Titletxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Size = new System.Drawing.Size(228, 24);
            this.Titletxt.TabIndex = 0;
            this.Titletxt.TextChanged += new System.EventHandler(this.Titletxt_TextChanged);
            // 
            // Authortxt
            // 
            this.Authortxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authortxt.Location = new System.Drawing.Point(212, 199);
            this.Authortxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Authortxt.Name = "Authortxt";
            this.Authortxt.Size = new System.Drawing.Size(228, 24);
            this.Authortxt.TabIndex = 1;
            this.Authortxt.TextChanged += new System.EventHandler(this.Authortxt_TextChanged);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(163, 141);
            this.Titlelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(41, 20);
            this.Titlelabel.TabIndex = 2;
            this.Titlelabel.Text = "Title";
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.GhostWhite;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(465, 315);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(150, 44);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "Add Book";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Borrowbtn
            // 
            this.Borrowbtn.BackColor = System.Drawing.Color.GreenYellow;
            this.Borrowbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowbtn.Location = new System.Drawing.Point(644, 315);
            this.Borrowbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Borrowbtn.Name = "Borrowbtn";
            this.Borrowbtn.Size = new System.Drawing.Size(150, 44);
            this.Borrowbtn.TabIndex = 5;
            this.Borrowbtn.Text = "Borrow Book";
            this.Borrowbtn.UseVisualStyleBackColor = false;
            this.Borrowbtn.Click += new System.EventHandler(this.Borrowbtn_Click);
            // 
            // Returntxt
            // 
            this.Returntxt.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Returntxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Returntxt.Location = new System.Drawing.Point(815, 315);
            this.Returntxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Returntxt.Name = "Returntxt";
            this.Returntxt.Size = new System.Drawing.Size(150, 44);
            this.Returntxt.TabIndex = 6;
            this.Returntxt.Text = "Return Book";
            this.Returntxt.UseVisualStyleBackColor = false;
            this.Returntxt.Click += new System.EventHandler(this.Returntxt_Click);
            // 
            // Authorlabel
            // 
            this.Authorlabel.AutoSize = true;
            this.Authorlabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Authorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Authorlabel.Location = new System.Drawing.Point(146, 201);
            this.Authorlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Authorlabel.Name = "Authorlabel";
            this.Authorlabel.Size = new System.Drawing.Size(58, 20);
            this.Authorlabel.TabIndex = 7;
            this.Authorlabel.Text = "Author";
            this.Authorlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(465, 139);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 162);
            this.listBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Library Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Authorlabel);
            this.Controls.Add(this.Returntxt);
            this.Controls.Add(this.Borrowbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.Authortxt);
            this.Controls.Add(this.Titletxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Titletxt;
        private System.Windows.Forms.TextBox Authortxt;
        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button Borrowbtn;
        private System.Windows.Forms.Button Returntxt;
        private System.Windows.Forms.Label Authorlabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

