namespace ASSIGNMENT2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            ptnCalculator = new Button();
            btnClear = new Button();
            cboTypeOfCustomer = new ComboBox();
            txtThisMonthWater = new TextBox();
            txtLastMonthWater = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtCustomerName = new TextBox();
            panel2 = new Panel();
            btnShowMenu = new Button();
            lvInvoice = new ListView();
            txtSearch = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            ToolStripMenuItem5 = new ToolStripMenuItem();
            ToolStripMenuItem6 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label1);
            panel1.Controls.Add(ptnCalculator);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(cboTypeOfCustomer);
            panel1.Controls.Add(txtThisMonthWater);
            panel1.Controls.Add(txtLastMonthWater);
            panel1.Controls.Add(txtNumberOfPeople);
            panel1.Controls.Add(txtCustomerName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 496);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(293, 29);
            label1.TabIndex = 7;
            label1.Text = "Customer Information";
            // 
            // ptnCalculator
            // 
            ptnCalculator.Location = new Point(200, 430);
            ptnCalculator.Name = "ptnCalculator";
            ptnCalculator.Size = new Size(84, 31);
            ptnCalculator.TabIndex = 6;
            ptnCalculator.Text = "Calculator";
            ptnCalculator.UseVisualStyleBackColor = true;
            ptnCalculator.Click += ptnCalculator_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(54, 430);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(83, 31);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cboTypeOfCustomer
            // 
            cboTypeOfCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cboTypeOfCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTypeOfCustomer.FormattingEnabled = true;
            cboTypeOfCustomer.Location = new Point(54, 190);
            cboTypeOfCustomer.Name = "cboTypeOfCustomer";
            cboTypeOfCustomer.Size = new Size(228, 28);
            cboTypeOfCustomer.TabIndex = 2;
            cboTypeOfCustomer.SelectedIndexChanged += cboTypeOfCustomer_SelectedIndexChanged;
            // 
            // txtThisMonthWater
            // 
            txtThisMonthWater.Location = new Point(54, 371);
            txtThisMonthWater.Name = "txtThisMonthWater";
            txtThisMonthWater.PlaceholderText = "This Month Water Meter";
            txtThisMonthWater.Size = new Size(230, 27);
            txtThisMonthWater.TabIndex = 5;
            txtThisMonthWater.TextAlign = HorizontalAlignment.Center;
            txtThisMonthWater.KeyPress += txtThisMonthWater_KeyPress;
            // 
            // txtLastMonthWater
            // 
            txtLastMonthWater.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtLastMonthWater.Location = new Point(54, 315);
            txtLastMonthWater.Name = "txtLastMonthWater";
            txtLastMonthWater.PlaceholderText = "Last Month Water Meter";
            txtLastMonthWater.Size = new Size(230, 27);
            txtLastMonthWater.TabIndex = 4;
            txtLastMonthWater.TextAlign = HorizontalAlignment.Center;
            txtLastMonthWater.TextChanged += txtLastMonthWater_TextChanged;
            txtLastMonthWater.KeyPress += txtLastMonthWater_KeyPress;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Location = new Point(54, 252);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.PlaceholderText = "Number Of People";
            txtNumberOfPeople.Size = new Size(228, 27);
            txtNumberOfPeople.TabIndex = 3;
            txtNumberOfPeople.TextAlign = HorizontalAlignment.Center;
            txtNumberOfPeople.KeyPress += txtNumberOfPeople_KeyPress;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCustomerName.Location = new Point(54, 135);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.Size = new Size(230, 27);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            txtCustomerName.TextChanged += txtCustomerName_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(btnShowMenu);
            panel2.Controls.Add(lvInvoice);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(346, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 496);
            panel2.TabIndex = 1;
            // 
            // btnShowMenu
            // 
            btnShowMenu.Location = new Point(38, 79);
            btnShowMenu.Name = "btnShowMenu";
            btnShowMenu.Size = new Size(73, 34);
            btnShowMenu.TabIndex = 9;
            btnShowMenu.Text = "Sort";
            btnShowMenu.UseVisualStyleBackColor = true;
            btnShowMenu.Click += btnShowMenu_Click;
            // 
            // lvInvoice
            // 
            lvInvoice.Location = new Point(38, 119);
            lvInvoice.Name = "lvInvoice";
            lvInvoice.Size = new Size(555, 337);
            lvInvoice.TabIndex = 3;
            lvInvoice.UseCompatibleStateImageBehavior = false;
            lvInvoice.SelectedIndexChanged += lvInvoice_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(38, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Customer Name";
            txtSearch.Size = new Size(403, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, ToolStripMenuItem5, ToolStripMenuItem6 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(164, 148);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(163, 24);
            toolStripMenuItem1.Text = "Water used ↓";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(163, 24);
            toolStripMenuItem2.Text = "Water used ↑";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(163, 24);
            toolStripMenuItem3.Text = "Cost ↓";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(163, 24);
            toolStripMenuItem4.Text = "Cost ↑";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // ToolStripMenuItem5
            // 
            ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            ToolStripMenuItem5.Size = new Size(163, 24);
            ToolStripMenuItem5.Text = "A - Z";
            ToolStripMenuItem5.Click += ToolStripMenuItem5_Click;
            // 
            // ToolStripMenuItem6
            // 
            ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            ToolStripMenuItem6.Size = new Size(163, 24);
            ToolStripMenuItem6.Text = "Z - A";
            ToolStripMenuItem6.Click += ToolStripMenuItem6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(985, 496);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "AquaPay ❤";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtThisMonthWater;
        private TextBox txtLastMonthWater;
        private TextBox txtNumberOfPeople;
        private TextBox txtCustomerName;
        private Button ptnCalculator;
        private Button btnClear;
        private Label label1;
        private Panel panel2;
        private TextBox txtSearch;
        private ListView lvInvoice;
        private Button btnShowMenu;
        public ComboBox cboTypeOfCustomer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem ToolStripMenuItem5;
        private ToolStripMenuItem ToolStripMenuItem6;
    }
}
