namespace WinApp
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblBornYear = new System.Windows.Forms.Label();
            this.txtBornYear = new System.Windows.Forms.TextBox();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(195, 100);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(452, 100);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.ForeColor = System.Drawing.Color.Red;
            this.txtFirstName.Location = new System.Drawing.Point(269, 93);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(116, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(544, 100);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(116, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.ForeColor = System.Drawing.Color.Red;
            this.btnRun.Location = new System.Drawing.Point(269, 180);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(350, 54);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblBornYear
            // 
            this.lblBornYear.AutoSize = true;
            this.lblBornYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBornYear.Location = new System.Drawing.Point(195, 141);
            this.lblBornYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBornYear.Name = "lblBornYear";
            this.lblBornYear.Size = new System.Drawing.Size(63, 13);
            this.lblBornYear.TabIndex = 16;
            this.lblBornYear.Text = "Born Year";
            // 
            // txtBornYear
            // 
            this.txtBornYear.Location = new System.Drawing.Point(269, 141);
            this.txtBornYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBornYear.Name = "txtBornYear";
            this.txtBornYear.Size = new System.Drawing.Size(116, 20);
            this.txtBornYear.TabIndex = 3;
            // 
            // lstShow
            // 
            this.lstShow.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstShow.FormattingEnabled = true;
            this.lstShow.Location = new System.Drawing.Point(269, 343);
            this.lstShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(417, 95);
            this.lstShow.TabIndex = 17;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(289, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 31);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "This is the best app ever";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(269, 256);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(350, 55);
            this.btnReverse.TabIndex = 19;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.txtBornYear);
            this.Controls.Add(this.lblBornYear);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblBornYear;
        private System.Windows.Forms.TextBox txtBornYear;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnReverse;
    }
}

