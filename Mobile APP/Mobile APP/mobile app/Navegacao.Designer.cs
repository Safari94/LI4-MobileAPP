namespace Mobile_APP
{
    partial class Navegacao
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
            this.map = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.MinimumSize = new System.Drawing.Size(20, 20);
            this.map.Name = "map";
            this.map.Size = new System.Drawing.Size(403, 315);
            this.map.TabIndex = 0;
            this.map.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Navegacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 315);
            this.Controls.Add(this.map);
            this.Name = "Navegacao";
            this.Text = "Navegacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser map;
    }
}