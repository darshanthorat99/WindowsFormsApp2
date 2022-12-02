namespace WindowsFormsApp2
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnsoparead = new System.Windows.Forms.Button();
            this.btnsopawrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(242, 49);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "2";
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Location = new System.Drawing.Point(433, 55);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(103, 23);
            this.btnbinarywrite.TabIndex = 1;
            this.btnbinarywrite.Text = "binary write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "deptid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "deptname";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(242, 107);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 3;
            this.txtname.Text = "2dfdfd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "location";
            // 
            // txtlocation
            // 
            this.txtlocation.Location = new System.Drawing.Point(242, 171);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(100, 22);
            this.txtlocation.TabIndex = 5;
            this.txtlocation.Text = "ddewd";
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Location = new System.Drawing.Point(583, 55);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(111, 23);
            this.btnbinaryread.TabIndex = 7;
            this.btnbinaryread.Text = "binary read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnxmlread
            // 
            this.btnxmlread.Location = new System.Drawing.Point(583, 110);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(111, 23);
            this.btnxmlread.TabIndex = 9;
            this.btnxmlread.Text = "XML read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            this.btnxmlread.Click += new System.EventHandler(this.btnxmlread_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Location = new System.Drawing.Point(433, 110);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(103, 23);
            this.btnxmlwrite.TabIndex = 8;
            this.btnxmlwrite.Text = "XML write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnsoparead
            // 
            this.btnsoparead.Location = new System.Drawing.Point(583, 177);
            this.btnsoparead.Name = "btnsoparead";
            this.btnsoparead.Size = new System.Drawing.Size(111, 23);
            this.btnsoparead.TabIndex = 11;
            this.btnsoparead.Text = "SOPA read";
            this.btnsoparead.UseVisualStyleBackColor = true;
            // 
            // btnsopawrite
            // 
            this.btnsopawrite.Location = new System.Drawing.Point(433, 177);
            this.btnsopawrite.Name = "btnsopawrite";
            this.btnsopawrite.Size = new System.Drawing.Size(103, 23);
            this.btnsopawrite.TabIndex = 10;
            this.btnsopawrite.Text = "SOPA write";
            this.btnsopawrite.UseVisualStyleBackColor = true;
            this.btnsopawrite.Click += new System.EventHandler(this.btnsopawrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Location = new System.Drawing.Point(583, 243);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(111, 23);
            this.btnjsonread.TabIndex = 13;
            this.btnjsonread.Text = "JSON read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Location = new System.Drawing.Point(433, 243);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(103, 23);
            this.btnjsonwrite.TabIndex = 12;
            this.btnjsonwrite.Text = "JSON read";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnsoparead);
            this.Controls.Add(this.btnsopawrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.txtid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnsoparead;
        private System.Windows.Forms.Button btnsopawrite;
        private System.Windows.Forms.Button btnjsonread;
        private System.Windows.Forms.Button btnjsonwrite;
    }
}

