namespace YNAB.Statistics
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
            this.btnSpendByPayee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpendByPayee
            // 
            this.btnSpendByPayee.Location = new System.Drawing.Point(12, 12);
            this.btnSpendByPayee.Name = "btnSpendByPayee";
            this.btnSpendByPayee.Size = new System.Drawing.Size(206, 23);
            this.btnSpendByPayee.TabIndex = 0;
            this.btnSpendByPayee.Text = "Generate spend per payee";
            this.btnSpendByPayee.UseVisualStyleBackColor = true;
            this.btnSpendByPayee.Click += new System.EventHandler(this.btnSpendByPayee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 409);
            this.Controls.Add(this.btnSpendByPayee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpendByPayee;
    }
}

