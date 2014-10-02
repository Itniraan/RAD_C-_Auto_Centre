namespace AutoCentre
{
    partial class autoCentreForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.accessoriesGroupBox = new System.Windows.Forms.GroupBox();
            this.stereoSystemCheckBox = new System.Windows.Forms.CheckBox();
            this.leatherInteriorCheckBox = new System.Windows.Forms.CheckBox();
            this.computerNavigationCheckBox = new System.Windows.Forms.CheckBox();
            this.exteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.customizedDetailingRadioButton = new System.Windows.Forms.RadioButton();
            this.peralizedRadioButton = new System.Windows.Forms.RadioButton();
            this.standardRadioButton = new System.Windows.Forms.RadioButton();
            this.carSalesPriceLabel = new System.Windows.Forms.Label();
            this.accessoriesFinishLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.carSalesPriceTextBox = new System.Windows.Forms.TextBox();
            this.accessoriesFinishTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.tradeInAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.amountDueTextBox = new System.Windows.Forms.TextBox();
            this.accessoriesGroupBox.SuspendLayout();
            this.exteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(308, 419);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(413, 419);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(518, 419);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(243, 37);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(152, 24);
            this.titleLabel.TabIndex = 19;
            this.titleLabel.Text = "C# Auto Centre";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.authorLabel.Location = new System.Drawing.Point(512, 455);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(114, 17);
            this.authorLabel.TabIndex = 20;
            this.authorLabel.Text = "Blake Murdock";
            // 
            // accessoriesGroupBox
            // 
            this.accessoriesGroupBox.Controls.Add(this.stereoSystemCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.leatherInteriorCheckBox);
            this.accessoriesGroupBox.Controls.Add(this.computerNavigationCheckBox);
            this.accessoriesGroupBox.Location = new System.Drawing.Point(12, 80);
            this.accessoriesGroupBox.Name = "accessoriesGroupBox";
            this.accessoriesGroupBox.Size = new System.Drawing.Size(200, 143);
            this.accessoriesGroupBox.TabIndex = 0;
            this.accessoriesGroupBox.TabStop = false;
            this.accessoriesGroupBox.Text = "Accessories";
            // 
            // stereoSystemCheckBox
            // 
            this.stereoSystemCheckBox.AutoSize = true;
            this.stereoSystemCheckBox.Location = new System.Drawing.Point(6, 28);
            this.stereoSystemCheckBox.Name = "stereoSystemCheckBox";
            this.stereoSystemCheckBox.Size = new System.Drawing.Size(94, 17);
            this.stereoSystemCheckBox.TabIndex = 0;
            this.stereoSystemCheckBox.Text = "&Stereo System";
            this.stereoSystemCheckBox.UseVisualStyleBackColor = true;
            // 
            // leatherInteriorCheckBox
            // 
            this.leatherInteriorCheckBox.AutoSize = true;
            this.leatherInteriorCheckBox.Location = new System.Drawing.Point(6, 66);
            this.leatherInteriorCheckBox.Name = "leatherInteriorCheckBox";
            this.leatherInteriorCheckBox.Size = new System.Drawing.Size(97, 17);
            this.leatherInteriorCheckBox.TabIndex = 1;
            this.leatherInteriorCheckBox.Text = "Leather &Interior";
            this.leatherInteriorCheckBox.UseVisualStyleBackColor = true;
            // 
            // computerNavigationCheckBox
            // 
            this.computerNavigationCheckBox.AutoSize = true;
            this.computerNavigationCheckBox.Location = new System.Drawing.Point(6, 104);
            this.computerNavigationCheckBox.Name = "computerNavigationCheckBox";
            this.computerNavigationCheckBox.Size = new System.Drawing.Size(125, 17);
            this.computerNavigationCheckBox.TabIndex = 2;
            this.computerNavigationCheckBox.Text = "Computer &Navigation";
            this.computerNavigationCheckBox.UseVisualStyleBackColor = true;
            // 
            // exteriorFinishGroupBox
            // 
            this.exteriorFinishGroupBox.Controls.Add(this.customizedDetailingRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.peralizedRadioButton);
            this.exteriorFinishGroupBox.Controls.Add(this.standardRadioButton);
            this.exteriorFinishGroupBox.Location = new System.Drawing.Point(12, 242);
            this.exteriorFinishGroupBox.Name = "exteriorFinishGroupBox";
            this.exteriorFinishGroupBox.Size = new System.Drawing.Size(200, 154);
            this.exteriorFinishGroupBox.TabIndex = 1;
            this.exteriorFinishGroupBox.TabStop = false;
            this.exteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // customizedDetailingRadioButton
            // 
            this.customizedDetailingRadioButton.AutoSize = true;
            this.customizedDetailingRadioButton.Location = new System.Drawing.Point(6, 117);
            this.customizedDetailingRadioButton.Name = "customizedDetailingRadioButton";
            this.customizedDetailingRadioButton.Size = new System.Drawing.Size(123, 17);
            this.customizedDetailingRadioButton.TabIndex = 2;
            this.customizedDetailingRadioButton.TabStop = true;
            this.customizedDetailingRadioButton.Text = "Customized &Detailing";
            this.customizedDetailingRadioButton.UseVisualStyleBackColor = true;
            // 
            // peralizedRadioButton
            // 
            this.peralizedRadioButton.AutoSize = true;
            this.peralizedRadioButton.Location = new System.Drawing.Point(6, 74);
            this.peralizedRadioButton.Name = "peralizedRadioButton";
            this.peralizedRadioButton.Size = new System.Drawing.Size(68, 17);
            this.peralizedRadioButton.TabIndex = 1;
            this.peralizedRadioButton.TabStop = true;
            this.peralizedRadioButton.Text = "&Pearlized";
            this.peralizedRadioButton.UseVisualStyleBackColor = true;
            // 
            // standardRadioButton
            // 
            this.standardRadioButton.AutoSize = true;
            this.standardRadioButton.Location = new System.Drawing.Point(6, 31);
            this.standardRadioButton.Name = "standardRadioButton";
            this.standardRadioButton.Size = new System.Drawing.Size(68, 17);
            this.standardRadioButton.TabIndex = 0;
            this.standardRadioButton.TabStop = true;
            this.standardRadioButton.Text = "S&tandard";
            this.standardRadioButton.UseVisualStyleBackColor = true;
            // 
            // carSalesPriceLabel
            // 
            this.carSalesPriceLabel.AutoSize = true;
            this.carSalesPriceLabel.Location = new System.Drawing.Point(368, 93);
            this.carSalesPriceLabel.Name = "carSalesPriceLabel";
            this.carSalesPriceLabel.Size = new System.Drawing.Size(82, 13);
            this.carSalesPriceLabel.TabIndex = 2;
            this.carSalesPriceLabel.Text = "C&ar Sales Price:";
            // 
            // accessoriesFinishLabel
            // 
            this.accessoriesFinishLabel.AutoSize = true;
            this.accessoriesFinishLabel.Location = new System.Drawing.Point(348, 139);
            this.accessoriesFinishLabel.Name = "accessoriesFinishLabel";
            this.accessoriesFinishLabel.Size = new System.Drawing.Size(106, 13);
            this.accessoriesFinishLabel.TabIndex = 9;
            this.accessoriesFinishLabel.Text = "Accessories && Finish:";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Location = new System.Drawing.Point(401, 185);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(49, 13);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "Subtotal:";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(364, 231);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(86, 13);
            this.salesTaxLabel.TabIndex = 13;
            this.salesTaxLabel.Text = "Sales Tax (15%):";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(416, 277);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 15;
            this.totalLabel.Text = "Total:";
            // 
            // tradeInAllowanceLabel
            // 
            this.tradeInAllowanceLabel.AutoSize = true;
            this.tradeInAllowanceLabel.Location = new System.Drawing.Point(348, 323);
            this.tradeInAllowanceLabel.Name = "tradeInAllowanceLabel";
            this.tradeInAllowanceLabel.Size = new System.Drawing.Size(102, 13);
            this.tradeInAllowanceLabel.TabIndex = 4;
            this.tradeInAllowanceLabel.Text = "T&rade-In Allowance:";
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(381, 369);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(69, 13);
            this.amountDueLabel.TabIndex = 17;
            this.amountDueLabel.Text = "Amount Due:";
            // 
            // carSalesPriceTextBox
            // 
            this.carSalesPriceTextBox.Location = new System.Drawing.Point(471, 90);
            this.carSalesPriceTextBox.Name = "carSalesPriceTextBox";
            this.carSalesPriceTextBox.Size = new System.Drawing.Size(155, 20);
            this.carSalesPriceTextBox.TabIndex = 3;
            // 
            // accessoriesFinishTextBox
            // 
            this.accessoriesFinishTextBox.Location = new System.Drawing.Point(471, 136);
            this.accessoriesFinishTextBox.Name = "accessoriesFinishTextBox";
            this.accessoriesFinishTextBox.ReadOnly = true;
            this.accessoriesFinishTextBox.Size = new System.Drawing.Size(155, 20);
            this.accessoriesFinishTextBox.TabIndex = 10;
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.Location = new System.Drawing.Point(471, 182);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.ReadOnly = true;
            this.subtotalTextBox.Size = new System.Drawing.Size(155, 20);
            this.subtotalTextBox.TabIndex = 12;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Location = new System.Drawing.Point(471, 228);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(155, 20);
            this.salesTaxTextBox.TabIndex = 14;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(471, 274);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(155, 20);
            this.totalTextBox.TabIndex = 16;
            // 
            // tradeInAllowanceTextBox
            // 
            this.tradeInAllowanceTextBox.Location = new System.Drawing.Point(471, 320);
            this.tradeInAllowanceTextBox.Name = "tradeInAllowanceTextBox";
            this.tradeInAllowanceTextBox.Size = new System.Drawing.Size(155, 20);
            this.tradeInAllowanceTextBox.TabIndex = 5;
            // 
            // amountDueTextBox
            // 
            this.amountDueTextBox.Location = new System.Drawing.Point(471, 366);
            this.amountDueTextBox.Name = "amountDueTextBox";
            this.amountDueTextBox.ReadOnly = true;
            this.amountDueTextBox.Size = new System.Drawing.Size(155, 20);
            this.amountDueTextBox.TabIndex = 18;
            // 
            // autoCentreForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(638, 481);
            this.Controls.Add(this.amountDueTextBox);
            this.Controls.Add(this.tradeInAllowanceTextBox);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.salesTaxTextBox);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(this.accessoriesFinishTextBox);
            this.Controls.Add(this.carSalesPriceTextBox);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.tradeInAllowanceLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesTaxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.accessoriesFinishLabel);
            this.Controls.Add(this.carSalesPriceLabel);
            this.Controls.Add(this.exteriorFinishGroupBox);
            this.Controls.Add(this.accessoriesGroupBox);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "autoCentreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Centre";
            this.Load += new System.EventHandler(this.autoCentreForm_Load);
            this.accessoriesGroupBox.ResumeLayout(false);
            this.accessoriesGroupBox.PerformLayout();
            this.exteriorFinishGroupBox.ResumeLayout(false);
            this.exteriorFinishGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.GroupBox accessoriesGroupBox;
        private System.Windows.Forms.CheckBox stereoSystemCheckBox;
        private System.Windows.Forms.CheckBox leatherInteriorCheckBox;
        private System.Windows.Forms.CheckBox computerNavigationCheckBox;
        private System.Windows.Forms.GroupBox exteriorFinishGroupBox;
        private System.Windows.Forms.RadioButton customizedDetailingRadioButton;
        private System.Windows.Forms.RadioButton peralizedRadioButton;
        private System.Windows.Forms.RadioButton standardRadioButton;
        private System.Windows.Forms.Label carSalesPriceLabel;
        private System.Windows.Forms.Label accessoriesFinishLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tradeInAllowanceLabel;
        private System.Windows.Forms.Label amountDueLabel;
        private System.Windows.Forms.TextBox carSalesPriceTextBox;
        private System.Windows.Forms.TextBox accessoriesFinishTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox tradeInAllowanceTextBox;
        private System.Windows.Forms.TextBox amountDueTextBox;
    }
}

