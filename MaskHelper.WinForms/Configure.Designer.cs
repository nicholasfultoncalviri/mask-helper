namespace MaskHelper.WinForms
{
    partial class Configure
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
            this.selectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filePathDisplay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastMaskIdInput = new System.Windows.Forms.NumericUpDown();
            this.generateButton = new System.Windows.Forms.Button();
            this.progressSpinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lastMaskIdInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectButton.Location = new System.Drawing.Point(25, 65);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(112, 35);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "File";
            // 
            // filePathDisplay
            // 
            this.filePathDisplay.AutoSize = true;
            this.filePathDisplay.Location = new System.Drawing.Point(153, 70);
            this.filePathDisplay.Name = "filePathDisplay";
            this.filePathDisplay.Size = new System.Drawing.Size(112, 25);
            this.filePathDisplay.TabIndex = 3;
            this.filePathDisplay.Text = "Select a file...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Mask ID";
            // 
            // lastMaskIdInput
            // 
            this.lastMaskIdInput.Location = new System.Drawing.Point(25, 165);
            this.lastMaskIdInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lastMaskIdInput.Name = "lastMaskIdInput";
            this.lastMaskIdInput.Size = new System.Drawing.Size(180, 31);
            this.lastMaskIdInput.TabIndex = 5;
            this.lastMaskIdInput.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(25, 224);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 34);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // progressSpinner
            // 
            this.progressSpinner.Location = new System.Drawing.Point(165, 218);
            this.progressSpinner.Name = "progressSpinner";
            this.progressSpinner.Size = new System.Drawing.Size(40, 40);
            this.progressSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.progressSpinner.TabIndex = 7;
            this.progressSpinner.TabStop = false;
            this.progressSpinner.Visible = false;
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 283);
            this.Controls.Add(this.progressSpinner);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.lastMaskIdInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filePathDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectButton);
            this.Name = "Configure";
            this.Text = "Mask Generator";
            ((System.ComponentModel.ISupportInitialize)(this.lastMaskIdInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectButton;
        private Label label1;
        private Label filePathDisplay;
        private Label label3;
        private NumericUpDown lastMaskIdInput;
        private Button generateButton;
        private PictureBox progressSpinner;
    }
}