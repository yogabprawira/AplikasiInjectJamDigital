namespace AplikasiInjectJamDigital
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.clockRTextBox = new System.Windows.Forms.RichTextBox();
            this.hexaRTextBox = new System.Windows.Forms.RichTextBox();
            this.hexaLabel = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.serialPortComboBox = new System.Windows.Forms.ComboBox();
            this.serialPortLabel = new System.Windows.Forms.Label();
            this.uploadButton = new System.Windows.Forms.Button();
            this.refreshPortButton = new System.Windows.Forms.Button();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.openPortButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clockRTextBox
            // 
            this.clockRTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockRTextBox.Location = new System.Drawing.Point(23, 52);
            this.clockRTextBox.Name = "clockRTextBox";
            this.clockRTextBox.Size = new System.Drawing.Size(423, 170);
            this.clockRTextBox.TabIndex = 0;
            this.clockRTextBox.Text = "";
            this.clockRTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clockRTextBox_MouseUp);
            // 
            // hexaRTextBox
            // 
            this.hexaRTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexaRTextBox.Location = new System.Drawing.Point(23, 270);
            this.hexaRTextBox.Name = "hexaRTextBox";
            this.hexaRTextBox.Size = new System.Drawing.Size(421, 170);
            this.hexaRTextBox.TabIndex = 1;
            this.hexaRTextBox.Text = "";
            this.hexaRTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.hexaRTextBox_MouseUp);
            // 
            // hexaLabel
            // 
            this.hexaLabel.AutoSize = true;
            this.hexaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexaLabel.Location = new System.Drawing.Point(20, 251);
            this.hexaLabel.Name = "hexaLabel";
            this.hexaLabel.Size = new System.Drawing.Size(40, 16);
            this.hexaLabel.TabIndex = 2;
            this.hexaLabel.Text = "Hexa";
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(20, 33);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(42, 16);
            this.clockLabel.TabIndex = 3;
            this.clockLabel.Text = "Clock";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(463, 52);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(116, 30);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // serialPortComboBox
            // 
            this.serialPortComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialPortComboBox.FormattingEnabled = true;
            this.serialPortComboBox.Location = new System.Drawing.Point(463, 207);
            this.serialPortComboBox.Name = "serialPortComboBox";
            this.serialPortComboBox.Size = new System.Drawing.Size(112, 24);
            this.serialPortComboBox.TabIndex = 5;
            this.serialPortComboBox.Tag = "";
            this.serialPortComboBox.Text = "Select Port";
            // 
            // serialPortLabel
            // 
            this.serialPortLabel.AutoSize = true;
            this.serialPortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialPortLabel.Location = new System.Drawing.Point(483, 188);
            this.serialPortLabel.Name = "serialPortLabel";
            this.serialPortLabel.Size = new System.Drawing.Size(70, 16);
            this.serialPortLabel.TabIndex = 6;
            this.serialPortLabel.Text = "Serial Port";
            // 
            // uploadButton
            // 
            this.uploadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadButton.Location = new System.Drawing.Point(463, 309);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(116, 30);
            this.uploadButton.TabIndex = 7;
            this.uploadButton.Text = "Upload";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // refreshPortButton
            // 
            this.refreshPortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshPortButton.Location = new System.Drawing.Point(463, 237);
            this.refreshPortButton.Name = "refreshPortButton";
            this.refreshPortButton.Size = new System.Drawing.Size(116, 30);
            this.refreshPortButton.TabIndex = 8;
            this.refreshPortButton.Text = "Refresh Port";
            this.refreshPortButton.UseVisualStyleBackColor = true;
            this.refreshPortButton.Click += new System.EventHandler(this.refreshPortButton_Click);
            // 
            // buttonClearData
            // 
            this.buttonClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearData.Location = new System.Drawing.Point(463, 88);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(116, 30);
            this.buttonClearData.TabIndex = 9;
            this.buttonClearData.Text = "Clear Data";
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // openPortButton
            // 
            this.openPortButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openPortButton.Location = new System.Drawing.Point(463, 273);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(116, 30);
            this.openPortButton.TabIndex = 10;
            this.openPortButton.Text = "Open Port";
            this.openPortButton.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 461);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.buttonClearData);
            this.Controls.Add(this.refreshPortButton);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.serialPortLabel);
            this.Controls.Add(this.serialPortComboBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.hexaLabel);
            this.Controls.Add(this.hexaRTextBox);
            this.Controls.Add(this.clockRTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(607, 500);
            this.MinimumSize = new System.Drawing.Size(607, 500);
            this.Name = "mainWindow";
            this.Text = "Aplikasi Inject Data Jam Digital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox clockRTextBox;
        private System.Windows.Forms.RichTextBox hexaRTextBox;
        private System.Windows.Forms.Label hexaLabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.ComboBox serialPortComboBox;
        private System.Windows.Forms.Label serialPortLabel;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.Button refreshPortButton;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Button openPortButton;
    }
}

