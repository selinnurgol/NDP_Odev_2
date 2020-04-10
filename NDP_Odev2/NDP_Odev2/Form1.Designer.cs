namespace NDP_Odev2
{
    partial class AnaPanel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.xLabel = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.arkadasButton = new System.Windows.Forms.Button();
            this.sonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(34, 50);
            this.xLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 20);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "X:";
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(85, 48);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(209, 26);
            this.xTextBox.TabIndex = 1;
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(85, 94);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(209, 26);
            this.yTextBox.TabIndex = 3;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(34, 96);
            this.yLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(24, 20);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y:";
            // 
            // arkadasButton
            // 
            this.arkadasButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.arkadasButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.arkadasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arkadasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arkadasButton.ForeColor = System.Drawing.SystemColors.Control;
            this.arkadasButton.Location = new System.Drawing.Point(38, 146);
            this.arkadasButton.Name = "arkadasButton";
            this.arkadasButton.Size = new System.Drawing.Size(102, 32);
            this.arkadasButton.TabIndex = 4;
            this.arkadasButton.Text = "ARKADAŞ MI?";
            this.arkadasButton.UseVisualStyleBackColor = false;
            this.arkadasButton.Click += new System.EventHandler(this.arkadasButton_Click);
            // 
            // sonButton
            // 
            this.sonButton.BackColor = System.Drawing.Color.Crimson;
            this.sonButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonButton.ForeColor = System.Drawing.SystemColors.Control;
            this.sonButton.Location = new System.Drawing.Point(192, 146);
            this.sonButton.Name = "sonButton";
            this.sonButton.Size = new System.Drawing.Size(102, 32);
            this.sonButton.TabIndex = 5;
            this.sonButton.Text = "SON";
            this.sonButton.UseVisualStyleBackColor = false;
            this.sonButton.Click += new System.EventHandler(this.sonButton_Click);
            // 
            // AnaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(346, 211);
            this.Controls.Add(this.sonButton);
            this.Controls.Add(this.arkadasButton);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.xLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arkadaş Sayılar";
            this.Load += new System.EventHandler(this.AnaPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Button arkadasButton;
        private System.Windows.Forms.Button sonButton;
    }
}

