namespace PixisAirProjectTeam3
{
    partial class ReshistAM
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
            this.DisplayListBox = new System.Windows.Forms.ListBox();
            this.loadBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(158, 34);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(522, 290);
            this.DisplayListBox.TabIndex = 0;
            // 
            // loadBttn
            // 
            this.loadBttn.Location = new System.Drawing.Point(395, 358);
            this.loadBttn.Name = "loadBttn";
            this.loadBttn.Size = new System.Drawing.Size(75, 23);
            this.loadBttn.TabIndex = 1;
            this.loadBttn.Text = "Load";
            this.loadBttn.UseVisualStyleBackColor = true;
            // 
            // ReshistAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadBttn);
            this.Controls.Add(this.DisplayListBox);
            this.Name = "ReshistAM";
            this.Text = "ReshistAM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Button loadBttn;
    }
}