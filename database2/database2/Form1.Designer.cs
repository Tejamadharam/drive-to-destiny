namespace database2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texteid = new System.Windows.Forms.TextBox();
            this.textename = new System.Windows.Forms.TextBox();
            this.textsalary = new System.Windows.Forms.TextBox();
            this.textdpt = new System.Windows.Forms.TextBox();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ename";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dpt";
            // 
            // texteid
            // 
            this.texteid.Location = new System.Drawing.Point(134, 47);
            this.texteid.Name = "texteid";
            this.texteid.Size = new System.Drawing.Size(100, 20);
            this.texteid.TabIndex = 4;
            // 
            // textename
            // 
            this.textename.Location = new System.Drawing.Point(134, 101);
            this.textename.Name = "textename";
            this.textename.Size = new System.Drawing.Size(100, 20);
            this.textename.TabIndex = 5;
            // 
            // textsalary
            // 
            this.textsalary.Location = new System.Drawing.Point(134, 151);
            this.textsalary.Name = "textsalary";
            this.textsalary.Size = new System.Drawing.Size(100, 20);
            this.textsalary.TabIndex = 6;
            // 
            // textdpt
            // 
            this.textdpt.Location = new System.Drawing.Point(134, 203);
            this.textdpt.Name = "textdpt";
            this.textdpt.Size = new System.Drawing.Size(100, 20);
            this.textdpt.TabIndex = 7;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(47, 279);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 8;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(147, 279);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 447);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.textdpt);
            this.Controls.Add(this.textsalary);
            this.Controls.Add(this.textename);
            this.Controls.Add(this.texteid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texteid;
        private System.Windows.Forms.TextBox textename;
        private System.Windows.Forms.TextBox textsalary;
        private System.Windows.Forms.TextBox textdpt;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnback;
    }
}

