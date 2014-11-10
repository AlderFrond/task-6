namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.newx = new System.Windows.Forms.Label();
            this.newy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(4, 3);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(14, 13);
            this.x.TabIndex = 0;
            this.x.Text = "X";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(45, 3);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(14, 13);
            this.y.TabIndex = 1;
            this.y.Text = "Y";
            // 
            // newx
            // 
            this.newx.AutoSize = true;
            this.newx.Location = new System.Drawing.Point(196, 3);
            this.newx.Name = "newx";
            this.newx.Size = new System.Drawing.Size(36, 13);
            this.newx.TabIndex = 2;
            this.newx.Text = "NewX";
            // 
            // newy
            // 
            this.newy.AutoSize = true;
            this.newy.Location = new System.Drawing.Point(237, 3);
            this.newy.Name = "newy";
            this.newy.Size = new System.Drawing.Size(36, 13);
            this.newy.TabIndex = 3;
            this.newy.Text = "NewY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.newy);
            this.Controls.Add(this.newx);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label newx;
        private System.Windows.Forms.Label newy;
    }
}

