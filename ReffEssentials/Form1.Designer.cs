namespace ReffEssentials
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
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.btLoad = new System.Windows.Forms.Button();
            this.lbPlayer1V = new System.Windows.Forms.Label();
            this.lbPlayer2V = new System.Windows.Forms.Label();
            this.btPlayer1Add = new System.Windows.Forms.Button();
            this.btPlayer1Remove = new System.Windows.Forms.Button();
            this.btPlayer2Remove = new System.Windows.Forms.Button();
            this.btPlayer2Add = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.btCopy = new System.Windows.Forms.Button();
            this.lbCopied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.Location = new System.Drawing.Point(30, 31);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(85, 13);
            this.lbPlayer1.TabIndex = 0;
            this.lbPlayer1.Text = "Gracz 1/Team 1";
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.Location = new System.Drawing.Point(264, 31);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(85, 13);
            this.lbPlayer2.TabIndex = 1;
            this.lbPlayer2.Text = "Gracz 2/Team 2";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(15, 50);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(115, 20);
            this.tbPlayer1.TabIndex = 2;
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(250, 50);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(115, 20);
            this.tbPlayer2.TabIndex = 3;
            // 
            // btLoad
            // 
            this.btLoad.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btLoad.Location = new System.Drawing.Point(150, 50);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 4;
            this.btLoad.Text = "Załaduj";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // lbPlayer1V
            // 
            this.lbPlayer1V.AutoSize = true;
            this.lbPlayer1V.Location = new System.Drawing.Point(20, 94);
            this.lbPlayer1V.Name = "lbPlayer1V";
            this.lbPlayer1V.Size = new System.Drawing.Size(0, 13);
            this.lbPlayer1V.TabIndex = 5;
            this.lbPlayer1V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPlayer2V
            // 
            this.lbPlayer2V.AutoSize = true;
            this.lbPlayer2V.Location = new System.Drawing.Point(257, 94);
            this.lbPlayer2V.Name = "lbPlayer2V";
            this.lbPlayer2V.Size = new System.Drawing.Size(0, 13);
            this.lbPlayer2V.TabIndex = 6;
            this.lbPlayer2V.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPlayer1Add
            // 
            this.btPlayer1Add.Location = new System.Drawing.Point(43, 113);
            this.btPlayer1Add.Name = "btPlayer1Add";
            this.btPlayer1Add.Size = new System.Drawing.Size(50, 23);
            this.btPlayer1Add.TabIndex = 7;
            this.btPlayer1Add.Text = "+";
            this.btPlayer1Add.UseVisualStyleBackColor = true;
            this.btPlayer1Add.Click += new System.EventHandler(this.btPlayer1Add_Click);
            // 
            // btPlayer1Remove
            // 
            this.btPlayer1Remove.Location = new System.Drawing.Point(43, 142);
            this.btPlayer1Remove.Name = "btPlayer1Remove";
            this.btPlayer1Remove.Size = new System.Drawing.Size(50, 23);
            this.btPlayer1Remove.TabIndex = 8;
            this.btPlayer1Remove.Text = "-";
            this.btPlayer1Remove.UseVisualStyleBackColor = true;
            this.btPlayer1Remove.Click += new System.EventHandler(this.btPlayer1Remove_Click);
            // 
            // btPlayer2Remove
            // 
            this.btPlayer2Remove.Location = new System.Drawing.Point(277, 142);
            this.btPlayer2Remove.Name = "btPlayer2Remove";
            this.btPlayer2Remove.Size = new System.Drawing.Size(50, 23);
            this.btPlayer2Remove.TabIndex = 10;
            this.btPlayer2Remove.Text = "-";
            this.btPlayer2Remove.UseVisualStyleBackColor = true;
            this.btPlayer2Remove.Click += new System.EventHandler(this.btPlayer2Remove_Click);
            // 
            // btPlayer2Add
            // 
            this.btPlayer2Add.Location = new System.Drawing.Point(277, 113);
            this.btPlayer2Add.Name = "btPlayer2Add";
            this.btPlayer2Add.Size = new System.Drawing.Size(50, 23);
            this.btPlayer2Add.TabIndex = 9;
            this.btPlayer2Add.Text = "+";
            this.btPlayer2Add.UseVisualStyleBackColor = true;
            this.btPlayer2Add.Click += new System.EventHandler(this.btPlayer2Add_Click);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(40, 232);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 11;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(33, 276);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(75, 23);
            this.btCopy.TabIndex = 12;
            this.btCopy.Text = "Kopiuj";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // lbCopied
            // 
            this.lbCopied.AutoSize = true;
            this.lbCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCopied.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbCopied.Location = new System.Drawing.Point(145, 281);
            this.lbCopied.Name = "lbCopied";
            this.lbCopied.Size = new System.Drawing.Size(80, 13);
            this.lbCopied.TabIndex = 13;
            this.lbCopied.Text = "Skopiowano!";
            this.lbCopied.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCopied.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.lbCopied);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btPlayer2Remove);
            this.Controls.Add(this.btPlayer2Add);
            this.Controls.Add(this.btPlayer1Remove);
            this.Controls.Add(this.btPlayer1Add);
            this.Controls.Add(this.lbPlayer2V);
            this.Controls.Add(this.lbPlayer1V);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Name = "Form1";
            this.Text = "Reff Essentials v1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Label lbPlayer1V;
        private System.Windows.Forms.Label lbPlayer2V;
        private System.Windows.Forms.Button btPlayer1Add;
        private System.Windows.Forms.Button btPlayer1Remove;
        private System.Windows.Forms.Button btPlayer2Remove;
        private System.Windows.Forms.Button btPlayer2Add;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.Label lbCopied;
    }
}

