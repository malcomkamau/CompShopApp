namespace CompShopApp
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
            this.dgvLaptops = new System.Windows.Forms.DataGridView();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtProcessor = new System.Windows.Forms.TextBox();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.txtHarddisk = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnOpenReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLaptops
            // 
            this.dgvLaptops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaptops.Location = new System.Drawing.Point(12, 12);
            this.dgvLaptops.Name = "dgvLaptops";
            this.dgvLaptops.RowHeadersWidth = 51;
            this.dgvLaptops.Size = new System.Drawing.Size(505, 363);
            this.dgvLaptops.TabIndex = 0;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(12, 397);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(186, 41);
            this.btnRetrieve.TabIndex = 1;
            this.btnRetrieve.Text = "Retrieve Laptops";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Processor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Memory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hard Disk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(699, 6);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(185, 22);
            this.txtBrand.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(699, 49);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(185, 22);
            this.txtModel.TabIndex = 9;
            // 
            // txtProcessor
            // 
            this.txtProcessor.Location = new System.Drawing.Point(699, 90);
            this.txtProcessor.Name = "txtProcessor";
            this.txtProcessor.Size = new System.Drawing.Size(185, 22);
            this.txtProcessor.TabIndex = 10;
            // 
            // txtMemory
            // 
            this.txtMemory.Location = new System.Drawing.Point(699, 129);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(185, 22);
            this.txtMemory.TabIndex = 11;
            // 
            // txtHarddisk
            // 
            this.txtHarddisk.Location = new System.Drawing.Point(699, 172);
            this.txtHarddisk.Name = "txtHarddisk";
            this.txtHarddisk.Size = new System.Drawing.Size(185, 22);
            this.txtHarddisk.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(699, 210);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(185, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(585, 255);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(188, 39);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Insert Laptop";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.Location = new System.Drawing.Point(331, 397);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(186, 41);
            this.btnOpenReport.TabIndex = 15;
            this.btnOpenReport.Text = "Open Report";
            this.btnOpenReport.UseVisualStyleBackColor = true;
            this.btnOpenReport.Click += new System.EventHandler(this.btnOpenReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.btnOpenReport);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtHarddisk);
            this.Controls.Add(this.txtMemory);
            this.Controls.Add(this.txtProcessor);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.dgvLaptops);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaptops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLaptops;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtProcessor;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TextBox txtHarddisk;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnOpenReport;
    }
}

