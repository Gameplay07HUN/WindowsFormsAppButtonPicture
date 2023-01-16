namespace WindowsFormsAppButtonPicture
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
            this.KepCuccPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // KepCuccPanel
            // 
            this.KepCuccPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KepCuccPanel.Location = new System.Drawing.Point(0, 0);
            this.KepCuccPanel.Name = "KepCuccPanel";
            this.KepCuccPanel.Size = new System.Drawing.Size(800, 450);
            this.KepCuccPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KepCuccPanel);
            this.Name = "Form1";
            this.Text = "Parancsgomb hátterének a megváltoztatása";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel KepCuccPanel;
    }
}

