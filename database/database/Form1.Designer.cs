﻿namespace database
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
            this.textsid = new System.Windows.Forms.TextBox();
            this.textsname = new System.Windows.Forms.TextBox();
            this.textcourse = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "sid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "sname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "course";
            // 
            // textsid
            // 
            this.textsid.Location = new System.Drawing.Point(344, 125);
            this.textsid.Name = "textsid";
            this.textsid.Size = new System.Drawing.Size(100, 20);
            this.textsid.TabIndex = 3;
            // 
            // textsname
            // 
            this.textsname.Location = new System.Drawing.Point(344, 203);
            this.textsname.Name = "textsname";
            this.textsname.Size = new System.Drawing.Size(100, 20);
            this.textsname.TabIndex = 4;
            // 
            // textcourse
            // 
            this.textcourse.Location = new System.Drawing.Point(343, 288);
            this.textcourse.Name = "textcourse";
            this.textcourse.Size = new System.Drawing.Size(100, 20);
            this.textcourse.TabIndex = 5;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(266, 372);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 495);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.textcourse);
            this.Controls.Add(this.textsname);
            this.Controls.Add(this.textsid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "sname";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textsid;
        private System.Windows.Forms.TextBox textsname;
        private System.Windows.Forms.TextBox textcourse;
        private System.Windows.Forms.Button btninsert;
    }
}

