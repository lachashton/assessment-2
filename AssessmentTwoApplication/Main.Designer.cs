namespace AssessmentTwoApplication
{
    partial class Main
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
            this.btnOpenApp1 = new System.Windows.Forms.Button();
            this.btnOpenApp2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenApp3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenApp1
            // 
            this.btnOpenApp1.Location = new System.Drawing.Point(43, 100);
            this.btnOpenApp1.Name = "btnOpenApp1";
            this.btnOpenApp1.Size = new System.Drawing.Size(168, 76);
            this.btnOpenApp1.TabIndex = 0;
            this.btnOpenApp1.Text = "Image App";
            this.btnOpenApp1.UseVisualStyleBackColor = true;
            this.btnOpenApp1.Click += new System.EventHandler(this.btnOpenApp1_Click);
            // 
            // btnOpenApp2
            // 
            this.btnOpenApp2.Location = new System.Drawing.Point(43, 198);
            this.btnOpenApp2.Name = "btnOpenApp2";
            this.btnOpenApp2.Size = new System.Drawing.Size(168, 76);
            this.btnOpenApp2.TabIndex = 1;
            this.btnOpenApp2.Text = "Drag n Drop App";
            this.btnOpenApp2.UseVisualStyleBackColor = true;
            this.btnOpenApp2.Click += new System.EventHandler(this.btnOpenApp2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(843, 542);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenApp3
            // 
            this.btnOpenApp3.Location = new System.Drawing.Point(43, 297);
            this.btnOpenApp3.Name = "btnOpenApp3";
            this.btnOpenApp3.Size = new System.Drawing.Size(168, 76);
            this.btnOpenApp3.TabIndex = 3;
            this.btnOpenApp3.Text = "Add User App";
            this.btnOpenApp3.UseVisualStyleBackColor = true;
            this.btnOpenApp3.Click += new System.EventHandler(this.btnOpenApp3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 511);
            this.Controls.Add(this.btnOpenApp3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenApp2);
            this.Controls.Add(this.btnOpenApp1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenApp1;
        private System.Windows.Forms.Button btnOpenApp2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenApp3;
    }
}

