namespace Perimeter_Calculator
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShort = new System.Windows.Forms.TextBox();
            this.rbArea = new System.Windows.Forms.RadioButton();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPerimeter = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Short Side";
            // 
            // txtShort
            // 
            this.txtShort.Location = new System.Drawing.Point(139, 49);
            this.txtShort.Name = "txtShort";
            this.txtShort.Size = new System.Drawing.Size(115, 22);
            this.txtShort.TabIndex = 2;
            // 
            // rbArea
            // 
            this.rbArea.AutoSize = true;
            this.rbArea.Location = new System.Drawing.Point(330, 52);
            this.rbArea.Name = "rbArea";
            this.rbArea.Size = new System.Drawing.Size(57, 20);
            this.rbArea.TabIndex = 3;
            this.rbArea.TabStop = true;
            this.rbArea.Text = "Area";
            this.rbArea.UseVisualStyleBackColor = true;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(139, 97);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(115, 22);
            this.txtLong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Long Side";
            // 
            // rbPerimeter
            // 
            this.rbPerimeter.AutoSize = true;
            this.rbPerimeter.Location = new System.Drawing.Point(330, 100);
            this.rbPerimeter.Name = "rbPerimeter";
            this.rbPerimeter.Size = new System.Drawing.Size(86, 20);
            this.rbPerimeter.TabIndex = 6;
            this.rbPerimeter.TabStop = true;
            this.rbPerimeter.Text = "Perimeter";
            this.rbPerimeter.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(47, 202);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(54, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 304);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.rbPerimeter);
            this.Controls.Add(this.txtLong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbArea);
            this.Controls.Add(this.txtShort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Perimeter Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShort;
        private System.Windows.Forms.RadioButton rbArea;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPerimeter;
        private System.Windows.Forms.Label lblResult;
    }
}

