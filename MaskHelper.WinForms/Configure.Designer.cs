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
            this.folderPathDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectFolderButton = new System.Windows.Forms.Button();
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
            this.filePathDisplay.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Mask ID";
            // 
            // lastMaskIdInput
            // 
            this.lastMaskIdInput.Location = new System.Drawing.Point(25, 250);
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
            this.generateButton.Location = new System.Drawing.Point(25, 309);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 34);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // progressSpinner
            // 
            this.progressSpinner.Image = global::MaskHelper.WinForms.Properties.Resources.spinner;
            this.progressSpinner.Location = new System.Drawing.Point(165, 303);
            this.progressSpinner.Name = "progressSpinner";
            this.progressSpinner.Size = new System.Drawing.Size(40, 40);
            this.progressSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.progressSpinner.TabIndex = 7;
            this.progressSpinner.TabStop = false;
            this.progressSpinner.Visible = false;
            // 
            // folderPathDisplay
            // 
            this.folderPathDisplay.AutoSize = true;
            this.folderPathDisplay.Location = new System.Drawing.Point(153, 162);
            this.folderPathDisplay.Name = "folderPathDisplay";
            this.folderPathDisplay.Size = new System.Drawing.Size(136, 25);
            this.folderPathDisplay.TabIndex = 10;
            this.folderPathDisplay.Text = "Select a folder...";
            this.folderPathDisplay.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output Folder";
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectFolderButton.Location = new System.Drawing.Point(25, 157);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(112, 35);
            this.selectFolderButton.TabIndex = 8;
            this.selectFolderButton.Text = "Select";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 370);
            this.Controls.Add(this.folderPathDisplay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectFolderButton);
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
        private Label folderPathDisplay;
        private Label label4;
        private Button selectFolderButton;
    }
}