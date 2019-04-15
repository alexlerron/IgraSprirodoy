namespace IgraSprirodoy
{
    partial class Form_Reshenie
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelReshenieValda = new System.Windows.Forms.Panel();
            this.label_Valda = new System.Windows.Forms.Label();
            this.PanelReshenieSevidza = new System.Windows.Forms.Panel();
            this.label_Sevidza = new System.Windows.Forms.Label();
            this.PanelReshenieJuvica = new System.Windows.Forms.Panel();
            this.label_Gurvica = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelReshenieValda.SuspendLayout();
            this.PanelReshenieSevidza.SuspendLayout();
            this.PanelReshenieJuvica.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.PanelReshenieValda);
            this.flowLayoutPanel1.Controls.Add(this.PanelReshenieSevidza);
            this.flowLayoutPanel1.Controls.Add(this.PanelReshenieJuvica);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 15);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1035, 524);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowLayoutPanel1_Paint);
            // 
            // PanelReshenieValda
            // 
            this.PanelReshenieValda.AutoSize = true;
            this.PanelReshenieValda.Controls.Add(this.label_Valda);
            this.PanelReshenieValda.Location = new System.Drawing.Point(4, 4);
            this.PanelReshenieValda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelReshenieValda.Name = "PanelReshenieValda";
            this.PanelReshenieValda.Size = new System.Drawing.Size(153, 32);
            this.PanelReshenieValda.TabIndex = 0;
            // 
            // label_Valda
            // 
            this.label_Valda.AutoSize = true;
            this.label_Valda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Valda.Location = new System.Drawing.Point(4, 7);
            this.label_Valda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Valda.Name = "label_Valda";
            this.label_Valda.Size = new System.Drawing.Size(145, 25);
            this.label_Valda.TabIndex = 1;
            this.label_Valda.Text = "Метод Вальда";
            // 
            // PanelReshenieSevidza
            // 
            this.PanelReshenieSevidza.AutoSize = true;
            this.PanelReshenieSevidza.Controls.Add(this.label_Sevidza);
            this.PanelReshenieSevidza.Location = new System.Drawing.Point(4, 44);
            this.PanelReshenieSevidza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelReshenieSevidza.Name = "PanelReshenieSevidza";
            this.PanelReshenieSevidza.Size = new System.Drawing.Size(172, 30);
            this.PanelReshenieSevidza.TabIndex = 1;
            // 
            // label_Sevidza
            // 
            this.label_Sevidza.AutoSize = true;
            this.label_Sevidza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sevidza.Location = new System.Drawing.Point(5, 5);
            this.label_Sevidza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Sevidza.Name = "label_Sevidza";
            this.label_Sevidza.Size = new System.Drawing.Size(163, 25);
            this.label_Sevidza.TabIndex = 0;
            this.label_Sevidza.Text = "Метод Сэвиджа";
            // 
            // PanelReshenieJuvica
            // 
            this.PanelReshenieJuvica.AutoSize = true;
            this.PanelReshenieJuvica.Controls.Add(this.label_Gurvica);
            this.PanelReshenieJuvica.Location = new System.Drawing.Point(4, 82);
            this.PanelReshenieJuvica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelReshenieJuvica.Name = "PanelReshenieJuvica";
            this.PanelReshenieJuvica.Size = new System.Drawing.Size(169, 30);
            this.PanelReshenieJuvica.TabIndex = 2;
            // 
            // label_Gurvica
            // 
            this.label_Gurvica.AutoSize = true;
            this.label_Gurvica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Gurvica.Location = new System.Drawing.Point(11, 5);
            this.label_Gurvica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Gurvica.Name = "label_Gurvica";
            this.label_Gurvica.Size = new System.Drawing.Size(154, 25);
            this.label_Gurvica.TabIndex = 0;
            this.label_Gurvica.Text = "Метод Гурвица";
            // 
            // Form_Reshenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Reshenie";
            this.Text = "Form_Reshenie";
            this.Load += new System.EventHandler(this.Form_Reshenie_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.PanelReshenieValda.ResumeLayout(false);
            this.PanelReshenieValda.PerformLayout();
            this.PanelReshenieSevidza.ResumeLayout(false);
            this.PanelReshenieSevidza.PerformLayout();
            this.PanelReshenieJuvica.ResumeLayout(false);
            this.PanelReshenieJuvica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelReshenieValda;
        private System.Windows.Forms.Label label_Valda;
        private System.Windows.Forms.Panel PanelReshenieSevidza;
        private System.Windows.Forms.Label label_Sevidza;
        private System.Windows.Forms.Panel PanelReshenieJuvica;
        private System.Windows.Forms.Label label_Gurvica;
    }
}