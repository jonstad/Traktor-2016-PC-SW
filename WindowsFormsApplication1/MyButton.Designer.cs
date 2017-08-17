namespace WindowsFormsApplication1
{
    partial class MyButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MyButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Name = "MyButton";
            this.Load += new System.EventHandler(this.MyButton_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyButton_MouseMove);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyButton_MouseClick);
            this.MouseHover += new System.EventHandler(this.MyButton_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

    }
}
