namespace Ian_McIntosh___Week3Ex8
{
    partial class pictureBoxDisplay
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
            this.textBoxNumTickets = new System.Windows.Forms.TextBox();
            this.textBoxDiscRate = new System.Windows.Forms.TextBox();
            this.textBoxCostOfTickets = new System.Windows.Forms.TextBox();
            this.textBoxDiscAmount = new System.Windows.Forms.TextBox();
            this.textBoxFinalCost = new System.Windows.Forms.TextBox();
            this.numTickets = new System.Windows.Forms.Label();
            this.discRate = new System.Windows.Forms.Label();
            this.costlabel = new System.Windows.Forms.Label();
            this.discamountlabel = new System.Windows.Forms.Label();
            this.finalcostlabel = new System.Windows.Forms.Label();
            this.calculatebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNumTickets
            // 
            this.textBoxNumTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumTickets.Location = new System.Drawing.Point(313, 64);
            this.textBoxNumTickets.Name = "textBoxNumTickets";
            this.textBoxNumTickets.Size = new System.Drawing.Size(160, 38);
            this.textBoxNumTickets.TabIndex = 0;
            // 
            // textBoxDiscRate
            // 
            this.textBoxDiscRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscRate.Location = new System.Drawing.Point(313, 105);
            this.textBoxDiscRate.Name = "textBoxDiscRate";
            this.textBoxDiscRate.Size = new System.Drawing.Size(160, 38);
            this.textBoxDiscRate.TabIndex = 1;
            // 
            // textBoxCostOfTickets
            // 
            this.textBoxCostOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCostOfTickets.Location = new System.Drawing.Point(313, 211);
            this.textBoxCostOfTickets.Name = "textBoxCostOfTickets";
            this.textBoxCostOfTickets.Size = new System.Drawing.Size(160, 38);
            this.textBoxCostOfTickets.TabIndex = 2;
            // 
            // textBoxDiscAmount
            // 
            this.textBoxDiscAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscAmount.Location = new System.Drawing.Point(313, 253);
            this.textBoxDiscAmount.Name = "textBoxDiscAmount";
            this.textBoxDiscAmount.Size = new System.Drawing.Size(160, 38);
            this.textBoxDiscAmount.TabIndex = 3;
            // 
            // textBoxFinalCost
            // 
            this.textBoxFinalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFinalCost.Location = new System.Drawing.Point(313, 297);
            this.textBoxFinalCost.Name = "textBoxFinalCost";
            this.textBoxFinalCost.Size = new System.Drawing.Size(160, 38);
            this.textBoxFinalCost.TabIndex = 4;
            // 
            // numTickets
            // 
            this.numTickets.AutoSize = true;
            this.numTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTickets.Location = new System.Drawing.Point(19, 64);
            this.numTickets.Name = "numTickets";
            this.numTickets.Size = new System.Drawing.Size(243, 31);
            this.numTickets.TabIndex = 5;
            this.numTickets.Text = "Number of Tickets:";
            // 
            // discRate
            // 
            this.discRate.AutoSize = true;
            this.discRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discRate.Location = new System.Drawing.Point(68, 108);
            this.discRate.Name = "discRate";
            this.discRate.Size = new System.Drawing.Size(194, 31);
            this.discRate.TabIndex = 6;
            this.discRate.Text = "Discount Rate:";
            // 
            // costlabel
            // 
            this.costlabel.AutoSize = true;
            this.costlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costlabel.Location = new System.Drawing.Point(44, 211);
            this.costlabel.Name = "costlabel";
            this.costlabel.Size = new System.Drawing.Size(218, 31);
            this.costlabel.TabIndex = 7;
            this.costlabel.Text = "Costs of Tickets:";
            // 
            // discamountlabel
            // 
            this.discamountlabel.AutoSize = true;
            this.discamountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discamountlabel.Location = new System.Drawing.Point(26, 256);
            this.discamountlabel.Name = "discamountlabel";
            this.discamountlabel.Size = new System.Drawing.Size(236, 31);
            this.discamountlabel.TabIndex = 8;
            this.discamountlabel.Text = "Discount Amount: ";
            // 
            // finalcostlabel
            // 
            this.finalcostlabel.AutoSize = true;
            this.finalcostlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalcostlabel.Location = new System.Drawing.Point(117, 300);
            this.finalcostlabel.Name = "finalcostlabel";
            this.finalcostlabel.Size = new System.Drawing.Size(145, 31);
            this.finalcostlabel.TabIndex = 9;
            this.finalcostlabel.Text = "Final Cost:";
            // 
            // calculatebutton
            // 
            this.calculatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatebutton.Location = new System.Drawing.Point(159, 382);
            this.calculatebutton.Name = "calculatebutton";
            this.calculatebutton.Size = new System.Drawing.Size(271, 67);
            this.calculatebutton.TabIndex = 10;
            this.calculatebutton.Text = "Calculate Costs";
            this.calculatebutton.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 491);
            this.Controls.Add(this.calculatebutton);
            this.Controls.Add(this.finalcostlabel);
            this.Controls.Add(this.discamountlabel);
            this.Controls.Add(this.costlabel);
            this.Controls.Add(this.discRate);
            this.Controls.Add(this.numTickets);
            this.Controls.Add(this.textBoxFinalCost);
            this.Controls.Add(this.textBoxDiscAmount);
            this.Controls.Add(this.textBoxCostOfTickets);
            this.Controls.Add(this.textBoxDiscRate);
            this.Controls.Add(this.textBoxNumTickets);
            this.Name = "pictureBoxDisplay";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumTickets;
        private System.Windows.Forms.TextBox textBoxDiscRate;
        private System.Windows.Forms.TextBox textBoxCostOfTickets;
        private System.Windows.Forms.TextBox textBoxDiscAmount;
        private System.Windows.Forms.TextBox textBoxFinalCost;
        private System.Windows.Forms.Label numTickets;
        private System.Windows.Forms.Label discRate;
        private System.Windows.Forms.Label costlabel;
        private System.Windows.Forms.Label discamountlabel;
        private System.Windows.Forms.Label finalcostlabel;
        private System.Windows.Forms.Button calculatebutton;
    }
}

