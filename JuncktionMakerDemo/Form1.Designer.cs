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
            this.typeSelectGroup = new System.Windows.Forms.GroupBox();
            this.symbolicDirRadio = new System.Windows.Forms.RadioButton();
            this.hardRadio = new System.Windows.Forms.RadioButton();
            this.junctionRadio = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.targetField = new System.Windows.Forms.TextBox();
            this.typeSelectGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceButtom
            // 
            this.sourceButtom.Location = new System.Drawing.Point(12, 123);
            this.sourceButtom.Name = "sourceButtom";
            this.sourceButtom.Size = new System.Drawing.Size(173, 27);
            this.sourceButtom.TabIndex = 0;
            this.sourceButtom.Text = "Souce";
            this.sourceButtom.UseVisualStyleBackColor = true;
            this.sourceButtom.Click += new System.EventHandler(this.sourceButtom_Click);
            // 
            // targetButton
            // 
            this.targetButton.Location = new System.Drawing.Point(12, 276);
            this.targetButton.Name = "targetButton";
            this.targetButton.Size = new System.Drawing.Size(173, 27);
            this.targetButton.TabIndex = 0;
            this.targetButton.Text = "Target";
            this.targetButton.UseVisualStyleBackColor = true;
            this.targetButton.Click += new System.EventHandler(this.targetButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(11, 432);
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
            this.sourceField.Location = new System.Drawing.Point(12, 156);
            this.sourceField.Multiline = true;
            this.sourceField.Name = "sourceField";
            this.sourceField.Size = new System.Drawing.Size(173, 105);
            this.sourceField.TabIndex = 1;
            // 
            // typeSelectGroup
            // 
            this.typeSelectGroup.Controls.Add(this.symbolicDirRadio);
            this.typeSelectGroup.Controls.Add(this.hardRadio);
            this.typeSelectGroup.Controls.Add(this.junctionRadio);
            this.typeSelectGroup.Location = new System.Drawing.Point(12, 12);
            this.typeSelectGroup.Name = "typeSelectGroup";
            this.typeSelectGroup.Size = new System.Drawing.Size(172, 105);
            this.typeSelectGroup.TabIndex = 2;
            this.typeSelectGroup.TabStop = false;
            this.typeSelectGroup.Text = "LinkType";
            // 
            // symbolicDirRadio
            // 
            this.symbolicDirRadio.AutoSize = true;
            this.symbolicDirRadio.Enabled = false;
            this.symbolicDirRadio.Location = new System.Drawing.Point(13, 72);
            this.symbolicDirRadio.Name = "symbolicDirRadio";
            this.symbolicDirRadio.Size = new System.Drawing.Size(98, 19);
            this.symbolicDirRadio.TabIndex = 0;
            this.symbolicDirRadio.TabStop = true;
            this.symbolicDirRadio.Text = "Directory Link";
            this.symbolicDirRadio.UseVisualStyleBackColor = true;
            // 
            // hardRadio
            // 
            this.hardRadio.AutoSize = true;
            this.hardRadio.Enabled = false;
            this.hardRadio.Location = new System.Drawing.Point(13, 47);
            this.hardRadio.Name = "hardRadio";
            this.hardRadio.Size = new System.Drawing.Size(76, 19);
            this.hardRadio.TabIndex = 0;
            this.hardRadio.TabStop = true;
            this.hardRadio.Text = "Hard Link";
            this.hardRadio.UseVisualStyleBackColor = true;
            // 
            // junctionRadio
            // 
            this.junctionRadio.AutoSize = true;
            this.junctionRadio.Location = new System.Drawing.Point(13, 22);
            this.junctionRadio.Name = "junctionRadio";
            this.junctionRadio.Size = new System.Drawing.Size(121, 19);
            this.junctionRadio.TabIndex = 0;
            this.junctionRadio.TabStop = true;
            this.junctionRadio.Text = "Directory Junction";
            this.junctionRadio.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(11, 465);
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
            this.targetField.Location = new System.Drawing.Point(12, 309);
            this.targetField.Multiline = true;
            this.targetField.Name = "targetField";
            this.targetField.Size = new System.Drawing.Size(173, 105);
            this.targetField.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 501);
            this.Controls.Add(this.typeSelectGroup);
            this.Controls.Add(this.targetField);
            this.Controls.Add(this.sourceField);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.targetButton);
            this.Controls.Add(this.sourceButtom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "JHS";
            this.typeSelectGroup.ResumeLayout(false);
            this.typeSelectGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button sourceButtom;
        private Button targetButton;
        private Button createButton;
        private TextBox sourceField;
        private GroupBox typeSelectGroup;
        private RadioButton hardRadio;
        private RadioButton junctionRadio;
        private Button clearButton;
        private TextBox targetField;
        private RadioButton symbolicDirRadio;
    }
}