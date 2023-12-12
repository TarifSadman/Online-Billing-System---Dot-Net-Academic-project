namespace OnlineBillingSystem
{
    partial class Due_Payment
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
            this.label_AskingpaymentMethod_Consumer = new System.Windows.Forms.Label();
            this.Bkash = new System.Windows.Forms.Button();
            this.Nagad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_AskingpaymentMethod_Consumer
            // 
            this.label_AskingpaymentMethod_Consumer.AutoSize = true;
            this.label_AskingpaymentMethod_Consumer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AskingpaymentMethod_Consumer.Location = new System.Drawing.Point(175, 74);
            this.label_AskingpaymentMethod_Consumer.Name = "label_AskingpaymentMethod_Consumer";
            this.label_AskingpaymentMethod_Consumer.Size = new System.Drawing.Size(423, 29);
            this.label_AskingpaymentMethod_Consumer.TabIndex = 0;
            this.label_AskingpaymentMethod_Consumer.Tag = "";
            this.label_AskingpaymentMethod_Consumer.Text = "Select your preferred payment method";
            // 
            // Bkash
            // 
            this.Bkash.Location = new System.Drawing.Point(204, 183);
            this.Bkash.Name = "Bkash";
            this.Bkash.Size = new System.Drawing.Size(103, 33);
            this.Bkash.TabIndex = 1;
            this.Bkash.Text = "Bkash";
            this.Bkash.UseVisualStyleBackColor = true;
            // 
            // Nagad
            // 
            this.Nagad.Location = new System.Drawing.Point(467, 183);
            this.Nagad.Name = "Nagad";
            this.Nagad.Size = new System.Drawing.Size(103, 33);
            this.Nagad.TabIndex = 2;
            this.Nagad.Text = "Nagad";
            this.Nagad.UseVisualStyleBackColor = true;
            // 
            // Due_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nagad);
            this.Controls.Add(this.Bkash);
            this.Controls.Add(this.label_AskingpaymentMethod_Consumer);
            this.Name = "Due_Payment";
            this.Text = "Due_Payment";
            this.Load += new System.EventHandler(this.Due_Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AskingpaymentMethod_Consumer;
        private System.Windows.Forms.Button Bkash;
        private System.Windows.Forms.Button Nagad;
    }
}