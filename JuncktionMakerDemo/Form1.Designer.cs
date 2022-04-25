namespace JuncktionMakerDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sourceButtom = new System.Windows.Forms.Button();
            this.targetButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.sourceField = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.targetField = new System.Windows.Forms.TextBox();
            this.modeSelect = new System.Windows.Forms.ComboBox();
            this.linkType = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // sourceButtom
            // 
            this.sourceButtom.Location = new System.Drawing.Point(10, 92);
            this.sourceButtom.Name = "sourceButtom";
            this.sourceButtom.Size = new System.Drawing.Size(173, 27);
            this.sourceButtom.TabIndex = 0;
            this.sourceButtom.Text = "Souce";
            this.sourceButtom.UseVisualStyleBackColor = true;
            this.sourceButtom.Click += new System.EventHandler(this.sourceButtom_Click);
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(10, 245);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(173, 27);
            this.targetButton.TabIndex = 0;
            this.targetButton.Text = "Target";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(9, 401);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(173, 27);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // sourceField
            // 
            this.sourceField.Enabled = false;
            this.sourceField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sourceField.Location = new System.Drawing.Point(10, 125);
            this.sourceField.Multiline = true;
            this.sourceField.Name = "sourceField";
            this.sourceField.Size = new System.Drawing.Size(173, 105);
            this.sourceField.TabIndex = 1;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(9, 434);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(173, 27);
            this.clearButton.TabIndex = 0;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // targetField
            // 
            this.targetField.Enabled = false;
            this.targetField.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.targetField.Location = new System.Drawing.Point(10, 278);
            this.targetField.Multiline = true;
            this.targetField.Name = "targetField";
            this.targetField.Size = new System.Drawing.Size(173, 105);
            this.targetField.TabIndex = 1;
            // 
            // modeSelect
            // 
            this.modeSelect.FormattingEnabled = true;
            this.modeSelect.Location = new System.Drawing.Point(8, 53);
            this.modeSelect.Name = "modeSelect";
            this.modeSelect.Size = new System.Drawing.Size(174, 23);
            this.modeSelect.TabIndex = 3;
            this.modeSelect.SelectedIndexChanged += new System.EventHandler(this.modeSelect_SelectedIndexChanged);
            // 
            // linkType
            // 
            this.linkType.AutoSize = true;
            this.linkType.Location = new System.Drawing.Point(7, 34);
            this.linkType.Name = "linkType";
            this.linkType.Size = new System.Drawing.Size(56, 15);
            this.linkType.TabIndex = 4;
            this.linkType.Text = "Link Type";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(192, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 472);
            this.Controls.Add(this.linkType);
            this.Controls.Add(this.modeSelect);
            this.Controls.Add(this.targetField);
            this.Controls.Add(this.sourceField);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.sourceButtom);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JHS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sourceButtom;
        private Button targetButton;
        private Button createButton;
        private TextBox sourceField;
        private Button clearButton;
        private TextBox targetField;
        private ComboBox modeSelect;
        private Label linkType;
        private MenuStrip menuStrip;
    }
}