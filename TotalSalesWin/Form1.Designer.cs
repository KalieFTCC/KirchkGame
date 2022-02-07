namespace TotalSalesWin
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
            this.totalSalesArray = new System.Windows.Forms.ListBox();
            this.totalSumOfSales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // totalSalesArray
            // 
            this.totalSalesArray.FormattingEnabled = true;
            this.totalSalesArray.Location = new System.Drawing.Point(155, 75);
            this.totalSalesArray.Name = "totalSalesArray";
            this.totalSalesArray.Size = new System.Drawing.Size(603, 355);
            this.totalSalesArray.TabIndex = 0;
            // 
            // totalSumOfSales
            // 
            this.totalSumOfSales.AutoSize = true;
            this.totalSumOfSales.Location = new System.Drawing.Point(389, 466);
            this.totalSumOfSales.Name = "totalSumOfSales";
            this.totalSumOfSales.Size = new System.Drawing.Size(31, 13);
            this.totalSumOfSales.TabIndex = 1;
            this.totalSumOfSales.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 587);
            this.Controls.Add(this.totalSumOfSales);
            this.Controls.Add(this.totalSalesArray);
            this.Name = "Form1";
            this.Text = "totalSales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox totalSalesArray;
        private System.Windows.Forms.Label totalSumOfSales;
    }
}

