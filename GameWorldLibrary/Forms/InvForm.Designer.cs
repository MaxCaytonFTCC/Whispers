namespace GameWorldLibrary.Forms
{
    partial class InvForm
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
            this.closeBTN = new System.Windows.Forms.Button();
            this.nameLBL = new System.Windows.Forms.Label();
            this.invLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(170, 245);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 0;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.Location = new System.Drawing.Point(12, 9);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(64, 27);
            this.nameLBL.TabIndex = 1;
            this.nameLBL.Text = "NAME";
            // 
            // invLB
            // 
            this.invLB.BackColor = System.Drawing.Color.Black;
            this.invLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invLB.ForeColor = System.Drawing.Color.White;
            this.invLB.FormattingEnabled = true;
            this.invLB.ItemHeight = 23;
            this.invLB.Location = new System.Drawing.Point(17, 39);
            this.invLB.Name = "invLB";
            this.invLB.Size = new System.Drawing.Size(228, 188);
            this.invLB.TabIndex = 2;
            // 
            // InvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(262, 280);
            this.Controls.Add(this.invLB);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.closeBTN);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "InvForm";
            this.Text = "Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.ListBox invLB;
    }
}