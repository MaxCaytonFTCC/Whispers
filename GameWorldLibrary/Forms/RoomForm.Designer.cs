namespace GameWorldLibrary
{
    partial class RoomForm
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
            this.itemDisplayLB = new System.Windows.Forms.ListBox();
            this.nameDisplayLBL = new System.Windows.Forms.Label();
            this.closeBTN = new System.Windows.Forms.Button();
            this.mobDisplayLB = new System.Windows.Forms.ListBox();
            this.itemLBL = new System.Windows.Forms.Label();
            this.mobLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerDisplayLB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // itemDisplayLB
            // 
            this.itemDisplayLB.BackColor = System.Drawing.Color.Black;
            this.itemDisplayLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemDisplayLB.ForeColor = System.Drawing.Color.White;
            this.itemDisplayLB.FormattingEnabled = true;
            this.itemDisplayLB.ItemHeight = 23;
            this.itemDisplayLB.Location = new System.Drawing.Point(17, 63);
            this.itemDisplayLB.Name = "itemDisplayLB";
            this.itemDisplayLB.Size = new System.Drawing.Size(228, 73);
            this.itemDisplayLB.TabIndex = 5;
            // 
            // nameDisplayLBL
            // 
            this.nameDisplayLBL.AutoSize = true;
            this.nameDisplayLBL.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplayLBL.Location = new System.Drawing.Point(12, 9);
            this.nameDisplayLBL.Name = "nameDisplayLBL";
            this.nameDisplayLBL.Size = new System.Drawing.Size(64, 27);
            this.nameDisplayLBL.TabIndex = 4;
            this.nameDisplayLBL.Text = "NAME";
            // 
            // closeBTN
            // 
            this.closeBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBTN.Location = new System.Drawing.Point(165, 385);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 3;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // mobDisplayLB
            // 
            this.mobDisplayLB.BackColor = System.Drawing.Color.Black;
            this.mobDisplayLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobDisplayLB.ForeColor = System.Drawing.Color.White;
            this.mobDisplayLB.FormattingEnabled = true;
            this.mobDisplayLB.ItemHeight = 23;
            this.mobDisplayLB.Location = new System.Drawing.Point(17, 182);
            this.mobDisplayLB.Name = "mobDisplayLB";
            this.mobDisplayLB.Size = new System.Drawing.Size(228, 73);
            this.mobDisplayLB.TabIndex = 6;
            // 
            // itemLBL
            // 
            this.itemLBL.AutoSize = true;
            this.itemLBL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLBL.Location = new System.Drawing.Point(13, 40);
            this.itemLBL.Name = "itemLBL";
            this.itemLBL.Size = new System.Drawing.Size(63, 20);
            this.itemLBL.TabIndex = 7;
            this.itemLBL.Text = "Items:";
            // 
            // mobLBL
            // 
            this.mobLBL.AutoSize = true;
            this.mobLBL.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobLBL.Location = new System.Drawing.Point(13, 159);
            this.mobLBL.Name = "mobLBL";
            this.mobLBL.Size = new System.Drawing.Size(54, 20);
            this.mobLBL.TabIndex = 8;
            this.mobLBL.Text = "Mobs:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mobs:";
            // 
            // playerDisplayLB
            // 
            this.playerDisplayLB.BackColor = System.Drawing.Color.Black;
            this.playerDisplayLB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerDisplayLB.ForeColor = System.Drawing.Color.White;
            this.playerDisplayLB.FormattingEnabled = true;
            this.playerDisplayLB.ItemHeight = 23;
            this.playerDisplayLB.Location = new System.Drawing.Point(12, 307);
            this.playerDisplayLB.Name = "playerDisplayLB";
            this.playerDisplayLB.Size = new System.Drawing.Size(228, 73);
            this.playerDisplayLB.TabIndex = 9;
            // 
            // RoomForm
            // 
            this.AcceptButton = this.closeBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.closeBTN;
            this.ClientSize = new System.Drawing.Size(262, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerDisplayLB);
            this.Controls.Add(this.mobLBL);
            this.Controls.Add(this.itemLBL);
            this.Controls.Add(this.mobDisplayLB);
            this.Controls.Add(this.itemDisplayLB);
            this.Controls.Add(this.nameDisplayLBL);
            this.Controls.Add(this.closeBTN);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RoomForm";
            this.Text = "Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemDisplayLB;
        private System.Windows.Forms.Label nameDisplayLBL;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.ListBox mobDisplayLB;
        private System.Windows.Forms.Label itemLBL;
        private System.Windows.Forms.Label mobLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox playerDisplayLB;
    }
}