namespace compressToOneFile.UI
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
            this.compressBtn = new System.Windows.Forms.Button();
            this.sourceTxt = new System.Windows.Forms.TextBox();
            this.instructions = new System.Windows.Forms.Label();
            this.desinationTxt = new System.Windows.Forms.TextBox();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.desinationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // compressBtn
            // 
            this.compressBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.compressBtn.Location = new System.Drawing.Point(348, 313);
            this.compressBtn.Name = "compressBtn";
            this.compressBtn.Size = new System.Drawing.Size(89, 35);
            this.compressBtn.TabIndex = 0;
            this.compressBtn.Text = "Compress";
            this.compressBtn.UseVisualStyleBackColor = false;
            this.compressBtn.Click += new System.EventHandler(this.compressBtn_Click);
            // 
            // sourceTxt
            // 
            this.sourceTxt.Location = new System.Drawing.Point(308, 145);
            this.sourceTxt.Name = "sourceTxt";
            this.sourceTxt.Size = new System.Drawing.Size(180, 22);
            this.sourceTxt.TabIndex = 1;
            // 
            // instructions
            // 
            this.instructions.AutoSize = true;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.SystemColors.GrayText;
            this.instructions.Location = new System.Drawing.Point(158, 25);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(527, 29);
            this.instructions.TabIndex = 2;
            this.instructions.Text = "Please fill in path of folder you want to compress";
            // 
            // desinationTxt
            // 
            this.desinationTxt.Location = new System.Drawing.Point(308, 235);
            this.desinationTxt.Name = "desinationTxt";
            this.desinationTxt.Size = new System.Drawing.Size(180, 22);
            this.desinationTxt.TabIndex = 3;
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(360, 104);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(77, 16);
            this.sourceLbl.TabIndex = 4;
            this.sourceLbl.Text = "source path";
            // 
            // desinationLbl
            // 
            this.desinationLbl.AutoSize = true;
            this.desinationLbl.Location = new System.Drawing.Point(345, 199);
            this.desinationLbl.Name = "desinationLbl";
            this.desinationLbl.Size = new System.Drawing.Size(98, 16);
            this.desinationLbl.TabIndex = 5;
            this.desinationLbl.Text = "desination path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desinationLbl);
            this.Controls.Add(this.sourceLbl);
            this.Controls.Add(this.desinationTxt);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.sourceTxt);
            this.Controls.Add(this.compressBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compressBtn;
        private System.Windows.Forms.TextBox sourceTxt;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.TextBox desinationTxt;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.Label desinationLbl;
    }
}

