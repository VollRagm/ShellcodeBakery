
namespace ShellcodeBakery
{
    partial class MainForm
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
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.Assemble32Btn = new System.Windows.Forms.Button();
            this.BeautifyCb = new System.Windows.Forms.CheckBox();
            this.AnnotateInstructionsCb = new System.Windows.Forms.CheckBox();
            this.AnnotateOffsetsCb = new System.Windows.Forms.CheckBox();
            this.Assemble64Btn = new System.Windows.Forms.Button();
            this.LanguageSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.InputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTextBox.ForeColor = System.Drawing.Color.White;
            this.InputTextBox.Location = new System.Drawing.Point(12, 28);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(350, 445);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "";
            this.InputTextBox.WordWrap = false;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputTextBox.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.OutputTextBox.ForeColor = System.Drawing.Color.White;
            this.OutputTextBox.Location = new System.Drawing.Point(461, 37);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(529, 441);
            this.OutputTextBox.TabIndex = 0;
            this.OutputTextBox.Text = "";
            this.OutputTextBox.WordWrap = false;
            // 
            // Assemble32Btn
            // 
            this.Assemble32Btn.Location = new System.Drawing.Point(368, 224);
            this.Assemble32Btn.Name = "Assemble32Btn";
            this.Assemble32Btn.Size = new System.Drawing.Size(88, 23);
            this.Assemble32Btn.TabIndex = 1;
            this.Assemble32Btn.Text = "Assemble x32";
            this.Assemble32Btn.UseVisualStyleBackColor = true;
            this.Assemble32Btn.Click += new System.EventHandler(this.Assemble32Btn_Click);
            // 
            // BeautifyCb
            // 
            this.BeautifyCb.AutoSize = true;
            this.BeautifyCb.ForeColor = System.Drawing.Color.White;
            this.BeautifyCb.Location = new System.Drawing.Point(602, 12);
            this.BeautifyCb.Name = "BeautifyCb";
            this.BeautifyCb.Size = new System.Drawing.Size(64, 17);
            this.BeautifyCb.TabIndex = 2;
            this.BeautifyCb.Text = "Beautify";
            this.BeautifyCb.UseVisualStyleBackColor = true;
            // 
            // AnnotateInstructionsCb
            // 
            this.AnnotateInstructionsCb.AutoSize = true;
            this.AnnotateInstructionsCb.ForeColor = System.Drawing.Color.White;
            this.AnnotateInstructionsCb.Location = new System.Drawing.Point(682, 12);
            this.AnnotateInstructionsCb.Name = "AnnotateInstructionsCb";
            this.AnnotateInstructionsCb.Size = new System.Drawing.Size(126, 17);
            this.AnnotateInstructionsCb.TabIndex = 2;
            this.AnnotateInstructionsCb.Text = "Annotate Instructions";
            this.AnnotateInstructionsCb.UseVisualStyleBackColor = true;
            // 
            // AnnotateOffsetsCb
            // 
            this.AnnotateOffsetsCb.AutoSize = true;
            this.AnnotateOffsetsCb.ForeColor = System.Drawing.Color.White;
            this.AnnotateOffsetsCb.Location = new System.Drawing.Point(807, 12);
            this.AnnotateOffsetsCb.Name = "AnnotateOffsetsCb";
            this.AnnotateOffsetsCb.Size = new System.Drawing.Size(105, 17);
            this.AnnotateOffsetsCb.TabIndex = 2;
            this.AnnotateOffsetsCb.Text = "Annotate Offsets";
            this.AnnotateOffsetsCb.UseVisualStyleBackColor = true;
            // 
            // Assemble64Btn
            // 
            this.Assemble64Btn.Location = new System.Drawing.Point(368, 253);
            this.Assemble64Btn.Name = "Assemble64Btn";
            this.Assemble64Btn.Size = new System.Drawing.Size(88, 23);
            this.Assemble64Btn.TabIndex = 1;
            this.Assemble64Btn.Text = "Assemble x64";
            this.Assemble64Btn.UseVisualStyleBackColor = true;
            this.Assemble64Btn.Click += new System.EventHandler(this.Assemble64Btn_Click);
            // 
            // LanguageSelection
            // 
            this.LanguageSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageSelection.FormattingEnabled = true;
            this.LanguageSelection.Items.AddRange(new object[] {
            "C/C++",
            "C#"});
            this.LanguageSelection.Location = new System.Drawing.Point(461, 10);
            this.LanguageSelection.Name = "LanguageSelection";
            this.LanguageSelection.Size = new System.Drawing.Size(121, 21);
            this.LanguageSelection.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ASM:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1002, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LanguageSelection);
            this.Controls.Add(this.AnnotateOffsetsCb);
            this.Controls.Add(this.AnnotateInstructionsCb);
            this.Controls.Add(this.BeautifyCb);
            this.Controls.Add(this.Assemble64Btn);
            this.Controls.Add(this.Assemble32Btn);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "ShellcodeBakery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button Assemble32Btn;
        private System.Windows.Forms.CheckBox BeautifyCb;
        private System.Windows.Forms.CheckBox AnnotateInstructionsCb;
        private System.Windows.Forms.CheckBox AnnotateOffsetsCb;
        private System.Windows.Forms.Button Assemble64Btn;
        private System.Windows.Forms.ComboBox LanguageSelection;
        private System.Windows.Forms.Label label1;
    }
}

