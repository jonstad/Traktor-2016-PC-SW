namespace WindowsFormsApplication1
{
    partial class TraktorG
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flashArrow2 = new WindowsFormsApplication1.FlashArrow();
            this.flashArrow1 = new WindowsFormsApplication1.FlashArrow();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            this.toolTip1.Tag = "";
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flashArrow2
            // 
            this.flashArrow2.BackColor = System.Drawing.Color.Transparent;
            this.flashArrow2.color1 = System.Drawing.Color.Gray;
            this.flashArrow2.color2 = System.Drawing.Color.Blue;
            this.flashArrow2.Location = new System.Drawing.Point(145, 25);
            this.flashArrow2.Name = "flashArrow2";
            this.flashArrow2.Size = new System.Drawing.Size(63, 31);
            this.flashArrow2.TabIndex = 1;
            // 
            // flashArrow1
            // 
            this.flashArrow1.BackColor = System.Drawing.Color.Transparent;
            this.flashArrow1.color1 = System.Drawing.Color.Gray;
            this.flashArrow1.color2 = System.Drawing.Color.Blue;
            this.flashArrow1.Location = new System.Drawing.Point(31, 24);
            this.flashArrow1.Name = "flashArrow1";
            this.flashArrow1.Size = new System.Drawing.Size(63, 31);
            this.flashArrow1.TabIndex = 0;
            // 
            // TraktorG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flashArrow2);
            this.Controls.Add(this.flashArrow1);
            this.DoubleBuffered = true;
            this.Name = "TraktorG";
            this.Size = new System.Drawing.Size(310, 265);
            this.Load += new System.EventHandler(this.TraktorG_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TraktorG_MouseMove);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TraktorG_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private FlashArrow flashArrow1;
        private FlashArrow flashArrow2;
    }
}
