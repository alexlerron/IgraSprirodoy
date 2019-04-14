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
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelReshenieValda.SuspendLayout();
            this.PanelReshenieSevidza.SuspendLayout();
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
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // PanelReshenieValda
            // 
            this.PanelReshenieValda.AutoSize = true;
            this.PanelReshenieValda.Controls.Add(this.label_Valda);
            this.PanelReshenieValda.Location = new System.Drawing.Point(3, 3);
            this.PanelReshenieValda.Name = "PanelReshenieValda";
            this.PanelReshenieValda.Size = new System.Drawing.Size(129, 26);
            this.PanelReshenieValda.TabIndex = 0;
            // 
            // label_Valda
            // 
            this.label_Valda.AutoSize = true;
            this.label_Valda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Valda.Location = new System.Drawing.Point(3, 6);
            this.label_Valda.Name = "label_Valda";
            this.label_Valda.Size = new System.Drawing.Size(123, 20);
            this.label_Valda.TabIndex = 1;
            this.label_Valda.Text = "Метод Вальда";
            // 
            // PanelReshenieSevidza
            // 
            this.PanelReshenieSevidza.AutoSize = true;
            this.PanelReshenieSevidza.Controls.Add(this.label_Sevidza);
            this.PanelReshenieSevidza.Location = new System.Drawing.Point(3, 35);
            this.PanelReshenieSevidza.Name = "PanelReshenieSevidza";
            this.PanelReshenieSevidza.Size = new System.Drawing.Size(140, 24);
            this.PanelReshenieSevidza.TabIndex = 1;
            // 
            // label_Sevidza
            // 
            this.label_Sevidza.AutoSize = true;
            this.label_Sevidza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sevidza.Location = new System.Drawing.Point(4, 4);
            this.label_Sevidza.Name = "label_Sevidza";
            this.label_Sevidza.Size = new System.Drawing.Size(133, 20);
            this.label_Sevidza.TabIndex = 0;
            this.label_Sevidza.Text = "Метод Сэвиджа";
            // 
            // Form_Reshenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form_Reshenie";
            this.Text = "Form_Reshenie";
            this.Load += new System.EventHandler(this.Form_Reshenie_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.PanelReshenieValda.ResumeLayout(false);
            this.PanelReshenieValda.PerformLayout();
            this.PanelReshenieSevidza.ResumeLayout(false);
            this.PanelReshenieSevidza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel PanelReshenieValda;
        private System.Windows.Forms.Label label_Valda;
        private System.Windows.Forms.Panel PanelReshenieSevidza;
        private System.Windows.Forms.Label label_Sevidza;
    }
}