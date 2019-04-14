namespace IgraSprirodoy
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Am = new System.Windows.Forms.TextBox();
            this.textBox_Pn = new System.Windows.Forms.TextBox();
            this.button_GenMatrix = new System.Windows.Forms.Button();
            this.textBox_Alpha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Methods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Am
            // 
            this.textBox_Am.Location = new System.Drawing.Point(129, 12);
            this.textBox_Am.Name = "textBox_Am";
            this.textBox_Am.Size = new System.Drawing.Size(100, 20);
            this.textBox_Am.TabIndex = 0;
            this.textBox_Am.Text = "10";
            this.textBox_Am.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Am.TextChanged += new System.EventHandler(this.TextBox_Am_TextChanged);
            // 
            // textBox_Pn
            // 
            this.textBox_Pn.Location = new System.Drawing.Point(129, 38);
            this.textBox_Pn.Name = "textBox_Pn";
            this.textBox_Pn.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pn.TabIndex = 1;
            this.textBox_Pn.Text = "4";
            this.textBox_Pn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_Pn.TextChanged += new System.EventHandler(this.TextBox_Pn_TextChanged);
            // 
            // button_GenMatrix
            // 
            this.button_GenMatrix.Location = new System.Drawing.Point(12, 9);
            this.button_GenMatrix.Name = "button_GenMatrix";
            this.button_GenMatrix.Size = new System.Drawing.Size(97, 49);
            this.button_GenMatrix.TabIndex = 2;
            this.button_GenMatrix.Text = "Сгенерировать матрицу";
            this.button_GenMatrix.UseVisualStyleBackColor = true;
            this.button_GenMatrix.Click += new System.EventHandler(this.Button_GenMatrix_Click);
            // 
            // textBox_Alpha
            // 
            this.textBox_Alpha.Location = new System.Drawing.Point(263, 12);
            this.textBox_Alpha.Name = "textBox_Alpha";
            this.textBox_Alpha.Size = new System.Drawing.Size(100, 20);
            this.textBox_Alpha.TabIndex = 3;
            this.textBox_Alpha.Text = "60";
            this.textBox_Alpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Am";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alpha";
            // 
            // Methods
            // 
            this.Methods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Methods.Location = new System.Drawing.Point(409, 10);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(115, 44);
            this.Methods.TabIndex = 7;
            this.Methods.Text = "Решение";
            this.Methods.UseVisualStyleBackColor = true;
            this.Methods.Click += new System.EventHandler(this.Methods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Methods);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Alpha);
            this.Controls.Add(this.button_GenMatrix);
            this.Controls.Add(this.textBox_Pn);
            this.Controls.Add(this.textBox_Am);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Am;
        private System.Windows.Forms.TextBox textBox_Pn;
        private System.Windows.Forms.Button button_GenMatrix;
        private System.Windows.Forms.TextBox textBox_Alpha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Methods;
    }
}

