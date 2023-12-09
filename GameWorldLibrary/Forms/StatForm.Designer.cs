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
            this.nameDisplayLBL = new System.Windows.Forms.Label();
            this.statDisplayLB = new System.Windows.Forms.ListBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.levelLBL = new System.Windows.Forms.Label();
            this.levelDisplayLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameDisplayLBL
            // 
            this.nameDisplayLBL.AutoSize = true;
            this.nameDisplayLBL.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplayLBL.Location = new System.Drawing.Point(12, 9);
            this.nameDisplayLBL.Name = "nameDisplayLBL";
            this.nameDisplayLBL.Size = new System.Drawing.Size(64, 27);
            this.nameDisplayLBL.TabIndex = 0;
            this.nameDisplayLBL.Text = "NAME";
            // 
            // statDisplayLB
            // 
            this.statDisplayLB.BackColor = System.Drawing.Color.Black;
            this.statDisplayLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statDisplayLB.ForeColor = System.Drawing.Color.White;
            this.statDisplayLB.FormattingEnabled = true;
            this.statDisplayLB.ItemHeight = 23;
            this.statDisplayLB.Location = new System.Drawing.Point(15, 39);
            this.statDisplayLB.Name = "statDisplayLB";
            this.statDisplayLB.Size = new System.Drawing.Size(228, 188);
            this.statDisplayLB.TabIndex = 1;
            // 
            // closeBTN
            // 
            this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(168, 233);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 2;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLBL.Location = new System.Drawing.Point(145, 13);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(45, 20);
            this.levelLBL.TabIndex = 3;
            this.levelLBL.Text = "LVL:";
            // 
            // levelDisplayLBL
            // 
            this.levelDisplayLBL.AutoSize = true;
            this.levelDisplayLBL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelDisplayLBL.Location = new System.Drawing.Point(196, 13);
            this.levelDisplayLBL.Name = "levelDisplayLBL";
            this.levelDisplayLBL.Size = new System.Drawing.Size(54, 20);
            this.levelDisplayLBL.TabIndex = 4;
            this.levelDisplayLBL.Text = "LEVEL";
            // 
            // StatForm
            // 
            this.AcceptButton = this.closeBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.closeBTN;
            this.ClientSize = new System.Drawing.Size(262, 268);
            this.Controls.Add(this.levelDisplayLBL);
            this.Controls.Add(this.levelLBL);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.statDisplayLB);
            this.Controls.Add(this.nameDisplayLBL);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "StatForm";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameDisplayLBL;
        private System.Windows.Forms.ListBox statDisplayLB;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.Label levelDisplayLBL;
    }
}