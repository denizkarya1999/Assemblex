namespace binaryConvertor
{
    partial class HelpMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.understandButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(115, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(767, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "How to use Assemblex?";
            // 
            // l1
            // 
            this.l1.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l1.Location = new System.Drawing.Point(45, 197);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(920, 144);
            this.l1.TabIndex = 1;
            this.l1.Text = "#1 Select the way you want to convert your number (Ex. Binary -> Hexadecimal)";
            // 
            // l2
            // 
            this.l2.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l2.Location = new System.Drawing.Point(45, 362);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(920, 194);
            this.l2.TabIndex = 2;
            this.l2.Text = "#2 Add the number you want to convert into an appropriate label (Ex. Decimal)";
            // 
            // l3
            // 
            this.l3.Font = new System.Drawing.Font("Segoe UI", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.l3.Location = new System.Drawing.Point(45, 570);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(920, 144);
            this.l3.TabIndex = 3;
            this.l3.Text = "#3 Click \"Convert\" to convert your number to designated type (Ex. 0001 1010 -> 1A" +
    ")";
            // 
            // understandButton
            // 
            this.understandButton.Location = new System.Drawing.Point(352, 739);
            this.understandButton.Name = "understandButton";
            this.understandButton.Size = new System.Drawing.Size(287, 104);
            this.understandButton.TabIndex = 4;
            this.understandButton.Text = "I Understand!";
            this.understandButton.UseVisualStyleBackColor = true;
            this.understandButton.Click += new System.EventHandler(this.understandButton_Click);
            // 
            // HelpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(995, 896);
            this.Controls.Add(this.understandButton);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpMenu";
            this.ShowInTaskbar = false;
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public Label l1;
        public Label l2;
        public Label l3;
        private Button understandButton;
    }
}