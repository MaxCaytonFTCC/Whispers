namespace GameWorldLibrary
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
            this.nameDisplayLBL = new System.Windows.Forms.Label();
            this.invDisplayLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(170, 233);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 0;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // nameDisplayLBL
            // 
            this.nameDisplayLBL.AutoSize = true;
            this.nameDisplayLBL.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplayLBL.Location = new System.Drawing.Point(12, 9);
            this.nameDisplayLBL.Name = "nameDisplayLBL";
            this.nameDisplayLBL.Size = new System.Drawing.Size(64, 27);
            this.nameDisplayLBL.TabIndex = 1;
            this.nameDisplayLBL.Text = "NAME";
            // 
            // invDisplayLB
            // 
            this.invDisplayLB.BackColor = System.Drawing.Color.Black;
            this.invDisplayLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invDisplayLB.ForeColor = System.Drawing.Color.White;
            this.invDisplayLB.FormattingEnabled = true;
            this.invDisplayLB.ItemHeight = 23;
            this.invDisplayLB.Location = new System.Drawing.Point(17, 39);
            this.invDisplayLB.Name = "invDisplayLB";
            this.invDisplayLB.Size = new System.Drawing.Size(228, 188);
            this.invDisplayLB.TabIndex = 2;
            // 
            // InvForm
            // 
            this.AcceptButton = this.closeBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.closeBTN;
            this.ClientSize = new System.Drawing.Size(262, 268);
            this.Controls.Add(this.invDisplayLB);
            this.Controls.Add(this.nameDisplayLBL);
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
        private System.Windows.Forms.Label nameDisplayLBL;
        private System.Windows.Forms.ListBox invDisplayLB;
    }
}