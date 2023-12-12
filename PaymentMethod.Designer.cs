namespace OnlineBillingSystem
{
    partial class PaymentMethod
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
            this.BKashbttn = new System.Windows.Forms.Button();
            this.Nagadbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BKashbttn
            // 
            this.BKashbttn.Location = new System.Drawing.Point(320, 91);
            this.BKashbttn.Name = "BKashbttn";
            this.BKashbttn.Size = new System.Drawing.Size(116, 33);
            this.BKashbttn.TabIndex = 0;
            this.BKashbttn.Text = "BKash";
            this.BKashbttn.UseVisualStyleBackColor = true;
            this.BKashbttn.Click += new System.EventHandler(this.BKashbttn_Click);
            // 
            // Nagadbttn
            // 
            this.Nagadbttn.Location = new System.Drawing.Point(320, 211);
            this.Nagadbttn.Name = "Nagadbttn";
            this.Nagadbttn.Size = new System.Drawing.Size(116, 33);
            this.Nagadbttn.TabIndex = 1;
            this.Nagadbttn.Text = "Nagad";
            this.Nagadbttn.UseVisualStyleBackColor = true;
            this.Nagadbttn.Click += new System.EventHandler(this.Nagadbttn_Click);
            // 
            // PaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nagadbttn);
            this.Controls.Add(this.BKashbttn);
            this.Name = "PaymentMethod";
            this.Text = "PaymentMethod";
            this.Load += new System.EventHandler(this.PaymentMethod_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BKashbttn;
        private System.Windows.Forms.Button Nagadbttn;
    }
}