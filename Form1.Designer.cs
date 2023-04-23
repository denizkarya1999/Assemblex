namespace binaryConvertor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.stackCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DecimalBox = new System.Windows.Forms.TextBox();
            this.HexadecimalBox = new System.Windows.Forms.TextBox();
            this.binaryBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.GroupBox();
            this.decimalToBinary = new System.Windows.Forms.RadioButton();
            this.hexadecimalToBinary = new System.Windows.Forms.RadioButton();
            this.BintoDec = new System.Windows.Forms.RadioButton();
            this.BintoHex = new System.Windows.Forms.RadioButton();
            this.HexToDec = new System.Windows.Forms.RadioButton();
            this.DectoHex = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1450, 52);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stackCalculatorToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::binaryConvertor.Properties.Resources.computer;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(66, 45);
            this.toolStripDropDownButton2.Text = "Assemblex";
            this.toolStripDropDownButton2.ToolTipText = "Try other programs created by Assemblex Team";
            // 
            // stackCalculatorToolStripMenuItem
            // 
            this.stackCalculatorToolStripMenuItem.Name = "stackCalculatorToolStripMenuItem";
            this.stackCalculatorToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.stackCalculatorToolStripMenuItem.Text = "Stack Calculator";
            this.stackCalculatorToolStripMenuItem.Click += new System.EventHandler(this.stackCalculatorToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(106, 45);
            this.toolStripDropDownButton1.Text = "Help";
            this.toolStripDropDownButton1.ToolTipText = "Get help to use Assemblex";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(445, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.aboutToolStripMenuItem.Text = "About Assemblex";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(317, 69);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(205, 65);
            this.label.TabIndex = 1;
            this.label.Text = "Decimal";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(259, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hexadecimal";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(331, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 65);
            this.label2.TabIndex = 3;
            this.label2.Text = "Binary";
            // 
            // DecimalBox
            // 
            this.DecimalBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DecimalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecimalBox.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalBox.Location = new System.Drawing.Point(52, 149);
            this.DecimalBox.Name = "DecimalBox";
            this.DecimalBox.Size = new System.Drawing.Size(755, 78);
            this.DecimalBox.TabIndex = 4;
            this.DecimalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HexadecimalBox
            // 
            this.HexadecimalBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HexadecimalBox.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexadecimalBox.Location = new System.Drawing.Point(52, 363);
            this.HexadecimalBox.Name = "HexadecimalBox";
            this.HexadecimalBox.Size = new System.Drawing.Size(755, 78);
            this.HexadecimalBox.TabIndex = 5;
            this.HexadecimalBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // binaryBox
            // 
            this.binaryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.binaryBox.Font = new System.Drawing.Font("Segoe UI", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.binaryBox.Location = new System.Drawing.Point(52, 559);
            this.binaryBox.Name = "binaryBox";
            this.binaryBox.Size = new System.Drawing.Size(755, 78);
            this.binaryBox.TabIndex = 6;
            this.binaryBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CalculateButton.Location = new System.Drawing.Point(966, 572);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(320, 104);
            this.CalculateButton.TabIndex = 7;
            this.CalculateButton.Text = "Convert";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.decimalToBinary);
            this.Options.Controls.Add(this.hexadecimalToBinary);
            this.Options.Controls.Add(this.BintoDec);
            this.Options.Controls.Add(this.BintoHex);
            this.Options.Controls.Add(this.HexToDec);
            this.Options.Controls.Add(this.DectoHex);
            this.Options.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Options.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Options.Location = new System.Drawing.Point(865, 69);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(519, 472);
            this.Options.TabIndex = 12;
            this.Options.TabStop = false;
            this.Options.Text = "Options";
            // 
            // decimalToBinary
            // 
            this.decimalToBinary.AutoSize = true;
            this.decimalToBinary.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.decimalToBinary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decimalToBinary.Location = new System.Drawing.Point(35, 126);
            this.decimalToBinary.Name = "decimalToBinary";
            this.decimalToBinary.Size = new System.Drawing.Size(351, 54);
            this.decimalToBinary.TabIndex = 17;
            this.decimalToBinary.TabStop = true;
            this.decimalToBinary.Text = "Decimal -> Binary";
            this.decimalToBinary.UseVisualStyleBackColor = true;
            // 
            // hexadecimalToBinary
            // 
            this.hexadecimalToBinary.AutoSize = true;
            this.hexadecimalToBinary.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hexadecimalToBinary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hexadecimalToBinary.Location = new System.Drawing.Point(35, 256);
            this.hexadecimalToBinary.Name = "hexadecimalToBinary";
            this.hexadecimalToBinary.Size = new System.Drawing.Size(428, 54);
            this.hexadecimalToBinary.TabIndex = 16;
            this.hexadecimalToBinary.TabStop = true;
            this.hexadecimalToBinary.Text = "Hexadecimal -> Binary";
            this.hexadecimalToBinary.UseVisualStyleBackColor = true;
            // 
            // BintoDec
            // 
            this.BintoDec.AutoSize = true;
            this.BintoDec.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BintoDec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BintoDec.Location = new System.Drawing.Point(34, 389);
            this.BintoDec.Name = "BintoDec";
            this.BintoDec.Size = new System.Drawing.Size(351, 54);
            this.BintoDec.TabIndex = 15;
            this.BintoDec.TabStop = true;
            this.BintoDec.Text = "Binary -> Decimal";
            this.BintoDec.UseVisualStyleBackColor = true;
            // 
            // BintoHex
            // 
            this.BintoHex.AutoSize = true;
            this.BintoHex.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BintoHex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BintoHex.Location = new System.Drawing.Point(34, 321);
            this.BintoHex.Name = "BintoHex";
            this.BintoHex.Size = new System.Drawing.Size(428, 54);
            this.BintoHex.TabIndex = 14;
            this.BintoHex.TabStop = true;
            this.BintoHex.Text = "Binary -> Hexadecimal";
            this.BintoHex.UseVisualStyleBackColor = true;
            // 
            // HexToDec
            // 
            this.HexToDec.AutoSize = true;
            this.HexToDec.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HexToDec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HexToDec.Location = new System.Drawing.Point(35, 191);
            this.HexToDec.Name = "HexToDec";
            this.HexToDec.Size = new System.Drawing.Size(458, 54);
            this.HexToDec.TabIndex = 13;
            this.HexToDec.TabStop = true;
            this.HexToDec.Text = "Hexadecimal -> Decimal";
            this.HexToDec.UseVisualStyleBackColor = true;
            // 
            // DectoHex
            // 
            this.DectoHex.AutoSize = true;
            this.DectoHex.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DectoHex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DectoHex.Location = new System.Drawing.Point(37, 60);
            this.DectoHex.Name = "DectoHex";
            this.DectoHex.Size = new System.Drawing.Size(458, 54);
            this.DectoHex.TabIndex = 12;
            this.DectoHex.TabStop = true;
            this.DectoHex.Text = "Decimal -> Hexadecimal";
            this.DectoHex.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 6.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1381, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "This is a student project created for CIS 375. There might be some bugs in this p" +
    "rogram as project was built in a short amount of time .";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(445, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1450, 758);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.binaryBox);
            this.Controls.Add(this.HexadecimalBox);
            this.Controls.Add(this.DecimalBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Assemblex - Convertor Edition (16-Bit Only)";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private Label label;
        private Label label1;
        private Label label2;
        private TextBox DecimalBox;
        private TextBox HexadecimalBox;
        private TextBox binaryBox;
        private Button CalculateButton;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private GroupBox Options;
        private RadioButton BintoDec;
        private RadioButton BintoHex;
        private RadioButton HexToDec;
        private RadioButton DectoHex;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Label label3;
        private RadioButton decimalToBinary;
        private RadioButton hexadecimalToBinary;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem stackCalculatorToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}