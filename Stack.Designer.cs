namespace binaryConvertor
{
    partial class Stack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stack));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.convertorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registersBox = new System.Windows.Forms.GroupBox();
            this.dxButton = new System.Windows.Forms.RadioButton();
            this.cxButton = new System.Windows.Forms.RadioButton();
            this.bxButton = new System.Windows.Forms.RadioButton();
            this.axButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.movButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.registerValuesBox = new System.Windows.Forms.GroupBox();
            this.dxValue = new System.Windows.Forms.TextBox();
            this.cxValue = new System.Windows.Forms.TextBox();
            this.bxValue = new System.Windows.Forms.TextBox();
            this.axValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pushButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stackBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.registersBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.registerValuesBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Help});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1626, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertorToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.toolStripButton1.Image = global::binaryConvertor.Properties.Resources.computer;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(66, 45);
            this.toolStripButton1.Text = "Assemblex";
            this.toolStripButton1.ToolTipText = "Try other programs created by Assemblex Team";
            // 
            // convertorToolStripMenuItem
            // 
            this.convertorToolStripMenuItem.Name = "convertorToolStripMenuItem";
            this.convertorToolStripMenuItem.Size = new System.Drawing.Size(316, 54);
            this.convertorToolStripMenuItem.Text = "Convertor";
            this.convertorToolStripMenuItem.Click += new System.EventHandler(this.convertorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(313, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(316, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Help
            // 
            this.Help.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(106, 45);
            this.Help.Text = "Help";
            this.Help.ToolTipText = "Get help to use Assemblex";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(416, 54);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(413, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(416, 54);
            this.aboutToolStripMenuItem.Text = "About Assemblex";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // registersBox
            // 
            this.registersBox.Controls.Add(this.dxButton);
            this.registersBox.Controls.Add(this.cxButton);
            this.registersBox.Controls.Add(this.bxButton);
            this.registersBox.Controls.Add(this.axButton);
            this.registersBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registersBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registersBox.Location = new System.Drawing.Point(28, 87);
            this.registersBox.Name = "registersBox";
            this.registersBox.Size = new System.Drawing.Size(320, 260);
            this.registersBox.TabIndex = 3;
            this.registersBox.TabStop = false;
            this.registersBox.Text = "Registers";
            // 
            // dxButton
            // 
            this.dxButton.AutoSize = true;
            this.dxButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dxButton.Location = new System.Drawing.Point(181, 160);
            this.dxButton.Name = "dxButton";
            this.dxButton.Size = new System.Drawing.Size(111, 58);
            this.dxButton.TabIndex = 6;
            this.dxButton.TabStop = true;
            this.dxButton.Text = "DX";
            this.dxButton.UseVisualStyleBackColor = true;
            // 
            // cxButton
            // 
            this.cxButton.AutoSize = true;
            this.cxButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cxButton.Location = new System.Drawing.Point(44, 160);
            this.cxButton.Name = "cxButton";
            this.cxButton.Size = new System.Drawing.Size(109, 58);
            this.cxButton.TabIndex = 5;
            this.cxButton.TabStop = true;
            this.cxButton.Text = "CX";
            this.cxButton.UseVisualStyleBackColor = true;
            // 
            // bxButton
            // 
            this.bxButton.AutoSize = true;
            this.bxButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bxButton.Location = new System.Drawing.Point(181, 81);
            this.bxButton.Name = "bxButton";
            this.bxButton.Size = new System.Drawing.Size(107, 58);
            this.bxButton.TabIndex = 4;
            this.bxButton.TabStop = true;
            this.bxButton.Text = "BX";
            this.bxButton.UseVisualStyleBackColor = true;
            // 
            // axButton
            // 
            this.axButton.AutoSize = true;
            this.axButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.axButton.Location = new System.Drawing.Point(43, 81);
            this.axButton.Name = "axButton";
            this.axButton.Size = new System.Drawing.Size(110, 58);
            this.axButton.TabIndex = 3;
            this.axButton.TabStop = true;
            this.axButton.Text = "AX";
            this.axButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valueBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(385, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 260);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Values";
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(37, 116);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(534, 61);
            this.valueBox.TabIndex = 0;
            this.valueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // movButton
            // 
            this.movButton.Location = new System.Drawing.Point(204, 409);
            this.movButton.Name = "movButton";
            this.movButton.Size = new System.Drawing.Size(167, 79);
            this.movButton.TabIndex = 5;
            this.movButton.Text = "mov";
            this.movButton.UseVisualStyleBackColor = true;
            this.movButton.Click += new System.EventHandler(this.movButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(411, 409);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(167, 79);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subButton
            // 
            this.subButton.Location = new System.Drawing.Point(620, 409);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(167, 79);
            this.subButton.TabIndex = 7;
            this.subButton.Text = "sub";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // registerValuesBox
            // 
            this.registerValuesBox.Controls.Add(this.dxValue);
            this.registerValuesBox.Controls.Add(this.cxValue);
            this.registerValuesBox.Controls.Add(this.bxValue);
            this.registerValuesBox.Controls.Add(this.axValue);
            this.registerValuesBox.Controls.Add(this.label4);
            this.registerValuesBox.Controls.Add(this.label3);
            this.registerValuesBox.Controls.Add(this.label2);
            this.registerValuesBox.Controls.Add(this.label1);
            this.registerValuesBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerValuesBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.registerValuesBox.Location = new System.Drawing.Point(1032, 87);
            this.registerValuesBox.Name = "registerValuesBox";
            this.registerValuesBox.Size = new System.Drawing.Size(562, 448);
            this.registerValuesBox.TabIndex = 8;
            this.registerValuesBox.TabStop = false;
            this.registerValuesBox.Text = "Register Values";
            // 
            // dxValue
            // 
            this.dxValue.Location = new System.Drawing.Point(160, 342);
            this.dxValue.Name = "dxValue";
            this.dxValue.ReadOnly = true;
            this.dxValue.Size = new System.Drawing.Size(352, 61);
            this.dxValue.TabIndex = 6;
            this.dxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cxValue
            // 
            this.cxValue.Location = new System.Drawing.Point(160, 254);
            this.cxValue.Name = "cxValue";
            this.cxValue.ReadOnly = true;
            this.cxValue.Size = new System.Drawing.Size(352, 61);
            this.cxValue.TabIndex = 5;
            this.cxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bxValue
            // 
            this.bxValue.Location = new System.Drawing.Point(160, 167);
            this.bxValue.Name = "bxValue";
            this.bxValue.ReadOnly = true;
            this.bxValue.Size = new System.Drawing.Size(352, 61);
            this.bxValue.TabIndex = 4;
            this.bxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axValue
            // 
            this.axValue.Location = new System.Drawing.Point(160, 72);
            this.axValue.Name = "axValue";
            this.axValue.ReadOnly = true;
            this.axValue.Size = new System.Drawing.Size(352, 61);
            this.axValue.TabIndex = 1;
            this.axValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "DX =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "CX =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "BX =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "AX =";
            // 
            // pushButton
            // 
            this.pushButton.BackColor = System.Drawing.Color.DarkGreen;
            this.pushButton.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pushButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pushButton.Location = new System.Drawing.Point(28, 555);
            this.pushButton.Name = "pushButton";
            this.pushButton.Size = new System.Drawing.Size(320, 208);
            this.pushButton.TabIndex = 9;
            this.pushButton.Text = "PUSH";
            this.pushButton.UseVisualStyleBackColor = false;
            this.pushButton.Click += new System.EventHandler(this.pushButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stackBox);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(385, 554);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1209, 209);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stack";
            // 
            // stackBox
            // 
            this.stackBox.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stackBox.Location = new System.Drawing.Point(29, 88);
            this.stackBox.Name = "stackBox";
            this.stackBox.ReadOnly = true;
            this.stackBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stackBox.Size = new System.Drawing.Size(1146, 78);
            this.stackBox.TabIndex = 8;
            this.stackBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Stack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1626, 816);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pushButton);
            this.Controls.Add(this.registerValuesBox);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.movButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.registersBox);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Stack";
            this.Text = "Assemblex - Stack Edition (16-Bit Only)";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.registersBox.ResumeLayout(false);
            this.registersBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.registerValuesBox.ResumeLayout(false);
            this.registerValuesBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripDropDownButton Help;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem convertorToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private GroupBox registersBox;
        private RadioButton dxButton;
        private RadioButton cxButton;
        private RadioButton bxButton;
        private RadioButton axButton;
        private GroupBox groupBox1;
        private TextBox valueBox;
        private Button movButton;
        private Button addButton;
        private Button subButton;
        private GroupBox registerValuesBox;
        private TextBox dxValue;
        private TextBox cxValue;
        private TextBox bxValue;
        private TextBox axValue;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button pushButton;
        private GroupBox groupBox2;
        private TextBox stackBox;
    }
}