namespace ASSIGNMENT2
{
    partial class lbWaterBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbWaterBill));
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnPay = new Button();
            lbTotal = new Label();
            lbWaterUsage = new Label();
            lbThisMonth = new Label();
            lbLastMonth = new Label();
            lbCustomerType = new Label();
            lbCustomerName = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnPay);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(lbWaterUsage);
            panel1.Controls.Add(lbThisMonth);
            panel1.Controls.Add(lbLastMonth);
            panel1.Controls.Add(lbCustomerType);
            panel1.Controls.Add(lbCustomerName);
            panel1.Controls.Add(label1);
            panel1.ImeMode = ImeMode.NoControl;
            panel1.Location = new Point(177, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 502);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(128, 365);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 13;
            label7.Text = "Total Cost :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(128, 315);
            label6.Name = "label6";
            label6.Size = new Size(155, 20);
            label6.TabIndex = 12;
            label6.Text = "Water consumption :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(128, 265);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 11;
            label5.Text = "This Month Water Usage :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 219);
            label4.Name = "label4";
            label4.Size = new Size(190, 20);
            label4.TabIndex = 10;
            label4.Text = "Last Month Water Usage :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 176);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 9;
            label3.Text = "Type Of Customer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 131);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 8;
            label2.Text = "Customer Name :";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(256, 420);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(89, 30);
            btnPay.TabIndex = 7;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += button1_Click;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(348, 365);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(50, 20);
            lbTotal.TabIndex = 6;
            lbTotal.Text = "label7";
            // 
            // lbWaterUsage
            // 
            lbWaterUsage.AutoSize = true;
            lbWaterUsage.Location = new Point(348, 315);
            lbWaterUsage.Name = "lbWaterUsage";
            lbWaterUsage.Size = new Size(50, 20);
            lbWaterUsage.TabIndex = 5;
            lbWaterUsage.Text = "label6";
            // 
            // lbThisMonth
            // 
            lbThisMonth.AutoSize = true;
            lbThisMonth.Location = new Point(348, 265);
            lbThisMonth.Name = "lbThisMonth";
            lbThisMonth.Size = new Size(50, 20);
            lbThisMonth.TabIndex = 4;
            lbThisMonth.Text = "label5";
            // 
            // lbLastMonth
            // 
            lbLastMonth.AutoSize = true;
            lbLastMonth.Location = new Point(348, 219);
            lbLastMonth.Name = "lbLastMonth";
            lbLastMonth.Size = new Size(50, 20);
            lbLastMonth.TabIndex = 3;
            lbLastMonth.Text = "label4";
            // 
            // lbCustomerType
            // 
            lbCustomerType.AutoSize = true;
            lbCustomerType.Location = new Point(348, 176);
            lbCustomerType.Name = "lbCustomerType";
            lbCustomerType.Size = new Size(50, 20);
            lbCustomerType.TabIndex = 2;
            lbCustomerType.Text = "label3";
            lbCustomerType.Click += label3_Click;
            // 
            // lbCustomerName
            // 
            lbCustomerName.AutoSize = true;
            lbCustomerName.Location = new Point(348, 131);
            lbCustomerName.Name = "lbCustomerName";
            lbCustomerName.Size = new Size(50, 20);
            lbCustomerName.TabIndex = 1;
            lbCustomerName.Text = "label2";
            lbCustomerName.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 35);
            label1.Name = "label1";
            label1.Size = new Size(180, 35);
            label1.TabIndex = 0;
            label1.Text = "Bill Water";
            // 
            // lbWaterBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(959, 504);
            Controls.Add(panel1);
            Name = "lbWaterBill";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lbTotal;
        private Label lbWaterUsage;
        private Label lbThisMonth;
        private Label lbLastMonth;
        private Label lbCustomerType;
        private Label lbCustomerName;
        private Button btnPay;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}