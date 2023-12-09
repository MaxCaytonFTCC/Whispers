namespace GameWorldLibrary
{
    partial class StatForm
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
            this.nameLBL = new System.Windows.Forms.Label();
            this.statLB = new System.Windows.Forms.ListBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.Location = new System.Drawing.Point(10, 8);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(64, 27);
            this.nameLBL.TabIndex = 0;
            this.nameLBL.Text = "NAME";
            // 
            // statLB
            // 
            this.statLB.BackColor = System.Drawing.Color.Black;
            this.statLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statLB.ForeColor = System.Drawing.Color.White;
            this.statLB.FormattingEnabled = true;
            this.statLB.ItemHeight = 23;
            this.statLB.Location = new System.Drawing.Point(15, 38);
            this.statLB.Name = "statLB";
            this.statLB.Size = new System.Drawing.Size(228, 188);
            this.statLB.TabIndex = 1;
            // 
            // closeBTN
            // 
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(168, 232);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 2;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(257, 264);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.statLB);
            this.Controls.Add(this.nameLBL);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StatForm";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.ListBox statLB;
        private System.Windows.Forms.Button closeBTN;
    }
}