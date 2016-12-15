namespace TaxCalculator
{
    partial class TaxCalc
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
            this.InputNumBox = new System.Windows.Forms.TextBox();
            this.Button_Compute_Tax = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTaxRt = new System.Windows.Forms.Label();
            this.taxRtNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputNumBox
            // 
            this.InputNumBox.Location = new System.Drawing.Point(132, 65);
            this.InputNumBox.Name = "InputNumBox";
            this.InputNumBox.Size = new System.Drawing.Size(119, 20);
            this.InputNumBox.TabIndex = 3;
            this.InputNumBox.TextChanged += new System.EventHandler(this.InputNumBox_TextChanged);
            this.InputNumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Price_Key_Press);
            // 
            // Button_Compute_Tax
            // 
            this.Button_Compute_Tax.Location = new System.Drawing.Point(288, 224);
            this.Button_Compute_Tax.Name = "Button_Compute_Tax";
            this.Button_Compute_Tax.Size = new System.Drawing.Size(60, 25);
            this.Button_Compute_Tax.TabIndex = 4;
            this.Button_Compute_Tax.Text = "Calculate";
            this.Button_Compute_Tax.UseVisualStyleBackColor = true;
            this.Button_Compute_Tax.Click += new System.EventHandler(this.onclick_ComputeTax);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(77, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(235, 32);
            this.headerLabel.TabIndex = 5;
            this.headerLabel.Text = "Tax Calculator";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(133, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(80, 65);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 23);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price";
            this.labelPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(73, 111);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 25);
            this.labelTotal.TabIndex = 8;
            this.labelTotal.Text = "Total";
            // 
            // labelTaxRt
            // 
            this.labelTaxRt.AutoSize = true;
            this.labelTaxRt.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaxRt.Location = new System.Drawing.Point(12, 199);
            this.labelTaxRt.Name = "labelTaxRt";
            this.labelTaxRt.Size = new System.Drawing.Size(76, 23);
            this.labelTaxRt.TabIndex = 9;
            this.labelTaxRt.Text = "Tax Rate";
            // 
            // taxRtNum
            // 
            this.taxRtNum.AutoSize = true;
            this.taxRtNum.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxRtNum.Location = new System.Drawing.Point(106, 197);
            this.taxRtNum.Name = "taxRtNum";
            this.taxRtNum.Size = new System.Drawing.Size(54, 25);
            this.taxRtNum.TabIndex = 10;
            this.taxRtNum.Text = "7.5%";
            // 
            // TaxCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(386, 288);
            this.Controls.Add(this.taxRtNum);
            this.Controls.Add(this.labelTaxRt);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.Button_Compute_Tax);
            this.Controls.Add(this.InputNumBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "TaxCalc";
            this.Text = "Tax Calculator";
            this.Load += new System.EventHandler(this.TaxCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNumBox;
        private System.Windows.Forms.Button Button_Compute_Tax;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTaxRt;
        private System.Windows.Forms.Label taxRtNum;

    }
}

