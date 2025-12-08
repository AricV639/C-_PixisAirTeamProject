namespace PixisAirProjectTeam3
{
    partial class AddCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCarId = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the Add Car page!";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(519, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 69);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(519, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 69);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Location = new System.Drawing.Point(327, 77);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(62, 13);
            this.lblCarId.TabIndex = 5;
            this.lblCarId.Text = "Add Car ID:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(327, 163);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(78, 13);
            this.lblMake.TabIndex = 6;
            this.lblMake.Text = "Add Car Make:";
            // 
            // txtCarId
            // 
            this.txtCarId.Location = new System.Drawing.Point(322, 93);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(100, 20);
            this.txtCarId.TabIndex = 7;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(322, 179);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 8;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(322, 269);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 9;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(327, 253);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(80, 13);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Add Car Model:";
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtCarId);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblCarId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Name = "AddCar";
            this.Text = "AddCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
    }
}