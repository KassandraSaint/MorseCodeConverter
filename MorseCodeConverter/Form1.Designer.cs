
namespace MorseCodeConverter
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.stringBox = new System.Windows.Forms.TextBox();
            this.codeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.stringBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.morseBox = new System.Windows.Forms.TextBox();
            this.convertedBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a String you want to convert to Morse Code:";
            // 
            // stringBox
            // 
            this.stringBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringBox.Location = new System.Drawing.Point(33, 86);
            this.stringBox.Name = "stringBox";
            this.stringBox.Size = new System.Drawing.Size(730, 43);
            this.stringBox.TabIndex = 1;
            // 
            // codeBtn
            // 
            this.codeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.codeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBtn.Location = new System.Drawing.Point(265, 155);
            this.codeBtn.Name = "codeBtn";
            this.codeBtn.Size = new System.Drawing.Size(245, 120);
            this.codeBtn.TabIndex = 2;
            this.codeBtn.Text = "Convert\r\nto\r\nMorse Code";
            this.codeBtn.UseVisualStyleBackColor = false;
            this.codeBtn.Click += new System.EventHandler(this.codeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Morse Code you want to convert to a String:";
            // 
            // codeBox
            // 
            this.codeBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeBox.Location = new System.Drawing.Point(33, 528);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(730, 43);
            this.codeBox.TabIndex = 5;
            // 
            // stringBtn
            // 
            this.stringBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.stringBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stringBtn.Location = new System.Drawing.Point(265, 602);
            this.stringBtn.Name = "stringBtn";
            this.stringBtn.Size = new System.Drawing.Size(245, 120);
            this.stringBtn.TabIndex = 6;
            this.stringBtn.Text = "Convert\r\nto\r\nString";
            this.stringBtn.UseVisualStyleBackColor = false;
            this.stringBtn.Click += new System.EventHandler(this.stringBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(287, 916);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(210, 70);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // morseBox
            // 
            this.morseBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.morseBox.Location = new System.Drawing.Point(33, 306);
            this.morseBox.Multiline = true;
            this.morseBox.Name = "morseBox";
            this.morseBox.ReadOnly = true;
            this.morseBox.Size = new System.Drawing.Size(730, 145);
            this.morseBox.TabIndex = 3;
            this.morseBox.TabStop = false;
            // 
            // convertedBox
            // 
            this.convertedBox.Font = new System.Drawing.Font("Microsoft YaHei", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertedBox.Location = new System.Drawing.Point(33, 748);
            this.convertedBox.Multiline = true;
            this.convertedBox.Name = "convertedBox";
            this.convertedBox.ReadOnly = true;
            this.convertedBox.Size = new System.Drawing.Size(730, 145);
            this.convertedBox.TabIndex = 7;
            this.convertedBox.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.codeBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CancelButton = this.exitBtn;
            this.ClientSize = new System.Drawing.Size(794, 998);
            this.Controls.Add(this.convertedBox);
            this.Controls.Add(this.morseBox);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.stringBtn);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codeBtn);
            this.Controls.Add(this.stringBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morse Code Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.Button codeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Button stringBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox morseBox;
        private System.Windows.Forms.TextBox convertedBox;
    }
}

