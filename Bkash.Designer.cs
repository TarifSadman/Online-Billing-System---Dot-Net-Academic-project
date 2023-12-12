using System;

namespace OnlineBillingSystem
{
    partial class Bkash
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
            this.BKashnumberlbl = new System.Windows.Forms.Label();
            this.BKashreferencelbl = new System.Windows.Forms.Label();
            this.BkashNumbertxtbox = new System.Windows.Forms.TextBox();
            this.BKashreferencetxtbox = new System.Windows.Forms.TextBox();
            this.BKashCnfrmbttn = new System.Windows.Forms.Button();
            this.BKashamountlbl = new System.Windows.Forms.Label();
            this.Bkashamounttxtbox = new System.Windows.Forms.TextBox();
            this.BKashpinlbl = new System.Windows.Forms.Label();
            this.BKashPinbtxtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BKashnumberlbl
            // 
            this.BKashnumberlbl.AutoSize = true;
            this.BKashnumberlbl.Location = new System.Drawing.Point(189, 92);
            this.BKashnumberlbl.Name = "BKashnumberlbl";
            this.BKashnumberlbl.Size = new System.Drawing.Size(105, 17);
            this.BKashnumberlbl.TabIndex = 0;
            this.BKashnumberlbl.Text = "BKash number:";
            // 
            // BKashreferencelbl
            // 
            this.BKashreferencelbl.AutoSize = true;
            this.BKashreferencelbl.Location = new System.Drawing.Point(141, 271);
            this.BKashreferencelbl.Name = "BKashreferencelbl";
            this.BKashreferencelbl.Size = new System.Drawing.Size(153, 17);
            this.BKashreferencelbl.TabIndex = 1;
            this.BKashreferencelbl.Text = "Reference(Username):";
            // 
            // BkashNumbertxtbox
            // 
            this.BkashNumbertxtbox.Location = new System.Drawing.Point(328, 92);
            this.BkashNumbertxtbox.Name = "BkashNumbertxtbox";
            this.BkashNumbertxtbox.Size = new System.Drawing.Size(181, 22);
            this.BkashNumbertxtbox.TabIndex = 2;
            // 
            // BKashreferencetxtbox
            // 
            this.BKashreferencetxtbox.Location = new System.Drawing.Point(328, 268);
            this.BKashreferencetxtbox.Name = "BKashreferencetxtbox";
            this.BKashreferencetxtbox.Size = new System.Drawing.Size(181, 22);
            this.BKashreferencetxtbox.TabIndex = 3;
            // 
            // BKashCnfrmbttn
            // 
            this.BKashCnfrmbttn.Location = new System.Drawing.Point(416, 338);
            this.BKashCnfrmbttn.Name = "BKashCnfrmbttn";
            this.BKashCnfrmbttn.Size = new System.Drawing.Size(93, 28);
            this.BKashCnfrmbttn.TabIndex = 4;
            this.BKashCnfrmbttn.Text = "Confirm";
            this.BKashCnfrmbttn.UseVisualStyleBackColor = true;
            this.BKashCnfrmbttn.Click += new System.EventHandler(this.BKashCnfrmbttn_Click);
            // 
            // BKashamountlbl
            // 
            this.BKashamountlbl.AutoSize = true;
            this.BKashamountlbl.Location = new System.Drawing.Point(234, 151);
            this.BKashamountlbl.Name = "BKashamountlbl";
            this.BKashamountlbl.Size = new System.Drawing.Size(60, 17);
            this.BKashamountlbl.TabIndex = 5;
            this.BKashamountlbl.Text = "Amount:";
            this.BKashamountlbl.Click += new System.EventHandler(this.BKashAmountbttn_Click);
            // 
            // Bkashamounttxtbox
            // 
            this.Bkashamounttxtbox.Location = new System.Drawing.Point(328, 151);
            this.Bkashamounttxtbox.Name = "Bkashamounttxtbox";
            this.Bkashamounttxtbox.Size = new System.Drawing.Size(181, 22);
            this.Bkashamounttxtbox.TabIndex = 6;
            // 
            // BKashpinlbl
            // 
            this.BKashpinlbl.AutoSize = true;
            this.BKashpinlbl.Location = new System.Drawing.Point(215, 214);
            this.BKashpinlbl.Name = "BKashpinlbl";
            this.BKashpinlbl.Size = new System.Drawing.Size(79, 17);
            this.BKashpinlbl.TabIndex = 7;
            this.BKashpinlbl.Text = "BKash PIN:";
            // 
            // BKashPinbtxtbox
            // 
            this.BKashPinbtxtbox.Location = new System.Drawing.Point(328, 214);
            this.BKashPinbtxtbox.Name = "BKashPinbtxtbox";
            this.BKashPinbtxtbox.Size = new System.Drawing.Size(181, 22);
            this.BKashPinbtxtbox.TabIndex = 8;
            // 
            // Bkash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BKashPinbtxtbox);
            this.Controls.Add(this.BKashpinlbl);
            this.Controls.Add(this.Bkashamounttxtbox);
            this.Controls.Add(this.BKashamountlbl);
            this.Controls.Add(this.BKashCnfrmbttn);
            this.Controls.Add(this.BKashreferencetxtbox);
            this.Controls.Add(this.BkashNumbertxtbox);
            this.Controls.Add(this.BKashreferencelbl);
            this.Controls.Add(this.BKashnumberlbl);
            this.Name = "Bkash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bkash";
            this.Load += new System.EventHandler(this.Bkash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BKashCnfrmbttn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label BKashnumberlbl;
        private System.Windows.Forms.Label BKashreferencelbl;
        private System.Windows.Forms.TextBox BkashNumbertxtbox;
        private System.Windows.Forms.TextBox BKashreferencetxtbox;
        private System.Windows.Forms.Button BKashCnfrmbttn;
        private System.Windows.Forms.Label BKashamountlbl;
        private System.Windows.Forms.TextBox Bkashamounttxtbox;
        private System.Windows.Forms.Label BKashpinlbl;
        private System.Windows.Forms.TextBox BKashPinbtxtbox;
    }
}