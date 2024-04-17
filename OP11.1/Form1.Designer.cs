namespace ScrollbarCalculation
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scrollBar1 = new System.Windows.Forms.HScrollBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // scrollBar1
            // 
            this.scrollBar1.Location = new System.Drawing.Point(31, 41);
            this.scrollBar1.Maximum = 100;
            this.scrollBar1.Minimum = 1;
            this.scrollBar1.Name = "scrollBar1";
            this.scrollBar1.Size = new System.Drawing.Size(314, 21);
            this.scrollBar1.TabIndex = 0;
            this.scrollBar1.Value = 1;
            this.scrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar1_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(314, 50);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 153);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.scrollBar1);
            this.Name = "Form1";
            this.Text = "Scrollbar Calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar scrollBar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
