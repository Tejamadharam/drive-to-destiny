namespace Contextmenu
{
    partial class Nextpage
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnshowfolder = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(57, 71);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(207, 361);
            this.treeView1.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(421, 71);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(421, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnshowfolder
            // 
            this.btnshowfolder.Location = new System.Drawing.Point(421, 309);
            this.btnshowfolder.Name = "btnshowfolder";
            this.btnshowfolder.Size = new System.Drawing.Size(75, 23);
            this.btnshowfolder.TabIndex = 3;
            this.btnshowfolder.Text = "Showfolder";
            this.btnshowfolder.UseVisualStyleBackColor = true;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(421, 409);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 4;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.button4_Click);
            // 
            // Nextpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 560);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnshowfolder);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.treeView1);
            this.Name = "Nextpage";
            this.Text = "Nextpage";
            this.Load += new System.EventHandler(this.Nextpage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnshowfolder;
        private System.Windows.Forms.Button btnremove;
    }
}