namespace PixisAirProjectTeam3
{
    partial class CountriesAM
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
            this.addBttn = new System.Windows.Forms.Button();
            this.txtCountryCode = new System.Windows.Forms.TextBox();
            this.txtCountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cntryCode = new System.Windows.Forms.Label();
            this.cntryName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisplayListBox
            // 
            this.DisplayListBox.FormattingEnabled = true;
            this.DisplayListBox.Location = new System.Drawing.Point(103, 36);
            this.DisplayListBox.Name = "DisplayListBox";
            this.DisplayListBox.Size = new System.Drawing.Size(289, 303);
            this.DisplayListBox.TabIndex = 0;
            // 
            // loadBttn
            // 
            this.loadBttn.Location = new System.Drawing.Point(221, 365);
            this.loadBttn.Name = "loadBttn";
            this.loadBttn.Size = new System.Drawing.Size(75, 23);
            this.loadBttn.TabIndex = 1;
            this.loadBttn.Text = "Load";
            this.loadBttn.UseVisualStyleBackColor = true;
            this.loadBttn.Click += new System.EventHandler(this.loadBttn_Click);
            // 
            // addBttn
            // 
            this.addBttn.Location = new System.Drawing.Point(457, 365);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(75, 23);
            this.addBttn.TabIndex = 2;
            this.addBttn.Text = "Add";
            this.addBttn.UseVisualStyleBackColor = true;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // txtCountryCode
            // 
            this.txtCountryCode.Location = new System.Drawing.Point(557, 105);
            this.txtCountryCode.Name = "txtCountryCode";
            this.txtCountryCode.Size = new System.Drawing.Size(100, 20);
            this.txtCountryCode.TabIndex = 3;
            // 
            // txtCountryName
            // 
            this.txtCountryName.Location = new System.Drawing.Point(557, 182);
            this.txtCountryName.Name = "txtCountryName";
            this.txtCountryName.Size = new System.Drawing.Size(100, 20);
            this.txtCountryName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add to Table Below";
            // 
            // cntryCode
            // 
            this.cntryCode.AutoSize = true;
            this.cntryCode.Location = new System.Drawing.Point(568, 89);
            this.cntryCode.Name = "cntryCode";
            this.cntryCode.Size = new System.Drawing.Size(71, 13);
            this.cntryCode.TabIndex = 6;
            this.cntryCode.Text = "Country Code";
            // 
            // cntryName
            // 
            this.cntryName.AutoSize = true;
            this.cntryName.Location = new System.Drawing.Point(568, 166);
            this.cntryName.Name = "cntryName";
            this.cntryName.Size = new System.Drawing.Size(74, 13);
            this.cntryName.TabIndex = 7;
            this.cntryName.Text = "Country Name";
            // 
            // CountriesAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cntryName);
            this.Controls.Add(this.cntryCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCountryName);
            this.Controls.Add(this.txtCountryCode);
            this.Controls.Add(this.addBttn);
            this.Controls.Add(this.loadBttn);
            this.Controls.Add(this.DisplayListBox);
            this.Name = "CountriesAM";
            this.Text = "CountriesAM";
            this.Load += new System.EventHandler(this.CountriesAM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DisplayListBox;
        private System.Windows.Forms.Button loadBttn;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.TextBox txtCountryCode;
        private System.Windows.Forms.TextBox txtCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cntryCode;
        private System.Windows.Forms.Label cntryName;
    }
}