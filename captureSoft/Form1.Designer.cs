namespace captureSoft
{
    partial class ScreenCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenCap));
            this.snapBtn = new System.Windows.Forms.Button();
            this.recBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.fileDiagBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.screenShotBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // snapBtn
            // 
            this.snapBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.snapBtn.Location = new System.Drawing.Point(13, 33);
            this.snapBtn.Name = "snapBtn";
            this.snapBtn.Size = new System.Drawing.Size(97, 23);
            this.snapBtn.TabIndex = 0;
            this.snapBtn.Text = "Snapshot";
            this.snapBtn.UseVisualStyleBackColor = true;
            // 
            // recBtn
            // 
            this.recBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.recBtn.Location = new System.Drawing.Point(13, 62);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(97, 23);
            this.recBtn.TabIndex = 1;
            this.recBtn.Text = "Screen Record";
            this.recBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeBtn.Location = new System.Drawing.Point(13, 120);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 23);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // fileDiagBtn
            // 
            this.fileDiagBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fileDiagBtn.Location = new System.Drawing.Point(13, 91);
            this.fileDiagBtn.Name = "fileDiagBtn";
            this.fileDiagBtn.Size = new System.Drawing.Size(97, 23);
            this.fileDiagBtn.TabIndex = 3;
            this.fileDiagBtn.Text = "Select File";
            this.fileDiagBtn.UseVisualStyleBackColor = true;
            this.fileDiagBtn.Click += new System.EventHandler(this.fileDiagBtn_Click);
            // 
            // screenShotBtn
            // 
            this.screenShotBtn.Location = new System.Drawing.Point(13, 4);
            this.screenShotBtn.Name = "screenShotBtn";
            this.screenShotBtn.Size = new System.Drawing.Size(97, 23);
            this.screenShotBtn.TabIndex = 4;
            this.screenShotBtn.Text = "Screen Shot";
            this.screenShotBtn.UseVisualStyleBackColor = true;
            this.screenShotBtn.Click += new System.EventHandler(this.screenShotBtn_Click);
            // 
            // ScreenCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.closeBtn;
            this.ClientSize = new System.Drawing.Size(123, 146);
            this.Controls.Add(this.screenShotBtn);
            this.Controls.Add(this.fileDiagBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.recBtn);
            this.Controls.Add(this.snapBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenCap";
            this.Text = " ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button snapBtn;
        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button fileDiagBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button screenShotBtn;
    }
}

