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
            this.btnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenApp1
            // 
            this.btnOpenApp1.Location = new System.Drawing.Point(43, 119);
            this.btnOpenApp1.Name = "btnOpenApp1";
            this.btnOpenApp1.Size = new System.Drawing.Size(168, 76);
            this.btnOpenApp1.TabIndex = 0;
            this.btnOpenApp1.Text = "Image App";
            this.btnOpenApp1.UseVisualStyleBackColor = true;
            this.btnOpenApp1.Click += new System.EventHandler(this.btnOpenApp1_Click);
            // 
            // btnOpenApp2
            // 
            this.btnOpenApp2.Location = new System.Drawing.Point(43, 218);
            this.btnOpenApp2.Name = "btnOpenApp2";
            this.btnOpenApp2.Size = new System.Drawing.Size(168, 76);
            this.btnOpenApp2.TabIndex = 1;
            this.btnOpenApp2.Text = "Drag n Drop App";
            this.btnOpenApp2.UseVisualStyleBackColor = true;
            this.btnOpenApp2.Click += new System.EventHandler(this.btnOpenApp2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(80, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 31);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenApp3
            // 
            this.btnOpenApp3.Location = new System.Drawing.Point(43, 317);
            this.btnOpenApp3.Name = "btnOpenApp3";
            this.btnOpenApp3.Size = new System.Drawing.Size(168, 76);
            this.btnOpenApp3.TabIndex = 3;
            this.btnOpenApp3.Text = "Add User App";
            this.btnOpenApp3.UseVisualStyleBackColor = true;
            this.btnOpenApp3.Click += new System.EventHandler(this.btnOpenApp3_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(65, 414);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(126, 50);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "App Selection Menu";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOpenApp3);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenApp2);
            this.Controls.Add(this.btnOpenApp1);
            this.Name = "Main";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenApp1;
        private System.Windows.Forms.Button btnOpenApp2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenApp3;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label1;
    }
}

