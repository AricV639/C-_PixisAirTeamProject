namespace PixisAirProjectTeam3
{
    partial class flightCustomers
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
            this.btnShowCust = new System.Windows.Forms.Button();
            this.lblFlight = new System.Windows.Forms.Label();
            this.txtFlightNum = new System.Windows.Forms.TextBox();
            this.listBoxCust = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowCust
            // 
            this.btnShowCust.Location = new System.Drawing.Point(190, 176);
            this.btnShowCust.Name = "btnShowCust";
            this.btnShowCust.Size = new System.Drawing.Size(75, 42);
            this.btnShowCust.TabIndex = 0;
            this.btnShowCust.Text = "Show Customers";
            this.btnShowCust.UseVisualStyleBackColor = true;
            this.btnShowCust.Click += new System.EventHandler(this.btnShowCust_Click);
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Location = new System.Drawing.Point(315, 119);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(75, 13);
            this.lblFlight.TabIndex = 1;
            this.lblFlight.Text = "Flight Number:";
            // 
            // txtFlightNum
            // 
            this.txtFlightNum.Location = new System.Drawing.Point(305, 135);
            this.txtFlightNum.Name = "txtFlightNum";
            this.txtFlightNum.Size = new System.Drawing.Size(100, 20);
            this.txtFlightNum.TabIndex = 2;
            // 
            // listBoxCust
            // 
            this.listBoxCust.FormattingEnabled = true;
            this.listBoxCust.Location = new System.Drawing.Point(190, 257);
            this.listBoxCust.Name = "listBoxCust";
            this.listBoxCust.Size = new System.Drawing.Size(333, 160);
            this.listBoxCust.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(448, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // flightCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listBoxCust);
            this.Controls.Add(this.txtFlightNum);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.btnShowCust);
            this.Name = "flightCustomers";
            this.Text = "flightCustomers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowCust;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.TextBox txtFlightNum;
        private System.Windows.Forms.ListBox listBoxCust;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}