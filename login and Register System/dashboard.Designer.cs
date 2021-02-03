namespace login_and_Register_System
{
    partial class dashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Home_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.StepCount_btn = new System.Windows.Forms.Button();
            this.CaloriesCount_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(195)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.CaloriesCount_btn);
            this.panel1.Controls.Add(this.StepCount_btn);
            this.panel1.Controls.Add(this.Home_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 719);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 200);
            this.panel2.TabIndex = 1;
            // 
            // Home_btn
            // 
            this.Home_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(195)))), ((int)(((byte)(105)))));
            this.Home_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.Home_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.Home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_btn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Home_btn.Location = new System.Drawing.Point(0, 200);
            this.Home_btn.Name = "Home_btn";
            this.Home_btn.Size = new System.Drawing.Size(270, 49);
            this.Home_btn.TabIndex = 2;
            this.Home_btn.Text = "Home";
            this.Home_btn.UseVisualStyleBackColor = true;
            this.Home_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.label7.Location = new System.Drawing.Point(1225, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // StepCount_btn
            // 
            this.StepCount_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.StepCount_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(195)))), ((int)(((byte)(105)))));
            this.StepCount_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.StepCount_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.StepCount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StepCount_btn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepCount_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StepCount_btn.Location = new System.Drawing.Point(0, 249);
            this.StepCount_btn.Name = "StepCount_btn";
            this.StepCount_btn.Size = new System.Drawing.Size(270, 49);
            this.StepCount_btn.TabIndex = 3;
            this.StepCount_btn.Text = "StepCounter";
            this.StepCount_btn.UseVisualStyleBackColor = true;
            // 
            // CaloriesCount_btn
            // 
            this.CaloriesCount_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaloriesCount_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(195)))), ((int)(((byte)(105)))));
            this.CaloriesCount_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            this.CaloriesCount_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(175)))), ((int)(((byte)(55)))));
            this.CaloriesCount_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaloriesCount_btn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesCount_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CaloriesCount_btn.Location = new System.Drawing.Point(0, 298);
            this.CaloriesCount_btn.Name = "CaloriesCount_btn";
            this.CaloriesCount_btn.Size = new System.Drawing.Size(270, 49);
            this.CaloriesCount_btn.TabIndex = 4;
            this.CaloriesCount_btn.Text = "CalorieCount";
            this.CaloriesCount_btn.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1257, 719);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Home_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CaloriesCount_btn;
        private System.Windows.Forms.Button StepCount_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}