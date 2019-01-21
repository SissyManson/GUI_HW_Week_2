namespace ConfigureMyAuto
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.radbtnFORD = new System.Windows.Forms.RadioButton();
            this.radbtnBMW = new System.Windows.Forms.RadioButton();
            this.radbtnDODGE = new System.Windows.Forms.RadioButton();
            this.lblChooseCar = new System.Windows.Forms.Label();
            this.grbExtraAdds = new System.Windows.Forms.GroupBox();
            this.chbABS = new System.Windows.Forms.CheckBox();
            this.chbFogLights = new System.Windows.Forms.CheckBox();
            this.chbChains = new System.Windows.Forms.CheckBox();
            this.grbPayment = new System.Windows.Forms.GroupBox();
            this.rbCREDITcard = new System.Windows.Forms.RadioButton();
            this.rbCASH = new System.Windows.Forms.RadioButton();
            this.rbCHEQUE = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.pbCars = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbExtraAdds.SuspendLayout();
            this.grbPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).BeginInit();
            this.SuspendLayout();
            // 
            // radbtnFORD
            // 
            this.radbtnFORD.AutoSize = true;
            this.radbtnFORD.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.radbtnFORD.ForeColor = System.Drawing.Color.DarkGreen;
            this.radbtnFORD.Location = new System.Drawing.Point(488, 58);
            this.radbtnFORD.Name = "radbtnFORD";
            this.radbtnFORD.Size = new System.Drawing.Size(164, 23);
            this.radbtnFORD.TabIndex = 1;
            this.radbtnFORD.TabStop = true;
            this.radbtnFORD.Text = "Ford Mustang 1969";
            this.radbtnFORD.UseVisualStyleBackColor = true;
            this.radbtnFORD.CheckedChanged += new System.EventHandler(this.radbtnFORD_CheckedChanged);
            // 
            // radbtnBMW
            // 
            this.radbtnBMW.AutoSize = true;
            this.radbtnBMW.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.radbtnBMW.ForeColor = System.Drawing.Color.DarkGreen;
            this.radbtnBMW.Location = new System.Drawing.Point(488, 85);
            this.radbtnBMW.Name = "radbtnBMW";
            this.radbtnBMW.Size = new System.Drawing.Size(144, 23);
            this.radbtnBMW.TabIndex = 2;
            this.radbtnBMW.TabStop = true;
            this.radbtnBMW.Text = "BMW M5 (E39)";
            this.radbtnBMW.UseVisualStyleBackColor = true;
            this.radbtnBMW.CheckedChanged += new System.EventHandler(this.radbtnBMW_CheckedChanged);
            // 
            // radbtnDODGE
            // 
            this.radbtnDODGE.AutoSize = true;
            this.radbtnDODGE.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.radbtnDODGE.ForeColor = System.Drawing.Color.DarkGreen;
            this.radbtnDODGE.Location = new System.Drawing.Point(488, 112);
            this.radbtnDODGE.Name = "radbtnDODGE";
            this.radbtnDODGE.Size = new System.Drawing.Size(177, 23);
            this.radbtnDODGE.TabIndex = 3;
            this.radbtnDODGE.TabStop = true;
            this.radbtnDODGE.Text = "1970 Dodge Charger ";
            this.radbtnDODGE.UseVisualStyleBackColor = true;
            this.radbtnDODGE.CheckedChanged += new System.EventHandler(this.radbtnDODGE_CheckedChanged);
            // 
            // lblChooseCar
            // 
            this.lblChooseCar.AutoSize = true;
            this.lblChooseCar.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblChooseCar.Location = new System.Drawing.Point(485, 23);
            this.lblChooseCar.Name = "lblChooseCar";
            this.lblChooseCar.Size = new System.Drawing.Size(176, 23);
            this.lblChooseCar.TabIndex = 4;
            this.lblChooseCar.Text = "Choose Your Car:";
            // 
            // grbExtraAdds
            // 
            this.grbExtraAdds.Controls.Add(this.chbABS);
            this.grbExtraAdds.Controls.Add(this.chbFogLights);
            this.grbExtraAdds.Controls.Add(this.chbChains);
            this.grbExtraAdds.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbExtraAdds.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grbExtraAdds.Location = new System.Drawing.Point(489, 155);
            this.grbExtraAdds.Margin = new System.Windows.Forms.Padding(5);
            this.grbExtraAdds.Name = "grbExtraAdds";
            this.grbExtraAdds.Size = new System.Drawing.Size(200, 129);
            this.grbExtraAdds.TabIndex = 5;
            this.grbExtraAdds.TabStop = false;
            this.grbExtraAdds.Text = "Extra Adds:";
            // 
            // chbABS
            // 
            this.chbABS.AutoSize = true;
            this.chbABS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbABS.ForeColor = System.Drawing.Color.DarkGreen;
            this.chbABS.Location = new System.Drawing.Point(6, 39);
            this.chbABS.Name = "chbABS";
            this.chbABS.Size = new System.Drawing.Size(62, 23);
            this.chbABS.TabIndex = 6;
            this.chbABS.Text = "ABS";
            this.chbABS.UseVisualStyleBackColor = true;
            // 
            // chbFogLights
            // 
            this.chbFogLights.AutoSize = true;
            this.chbFogLights.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFogLights.ForeColor = System.Drawing.Color.DarkGreen;
            this.chbFogLights.Location = new System.Drawing.Point(6, 66);
            this.chbFogLights.Name = "chbFogLights";
            this.chbFogLights.Size = new System.Drawing.Size(161, 23);
            this.chbFogLights.TabIndex = 7;
            this.chbFogLights.Text = "Extra lights for fog";
            this.chbFogLights.UseVisualStyleBackColor = true;
            // 
            // chbChains
            // 
            this.chbChains.AutoSize = true;
            this.chbChains.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbChains.ForeColor = System.Drawing.Color.DarkGreen;
            this.chbChains.Location = new System.Drawing.Point(6, 93);
            this.chbChains.Name = "chbChains";
            this.chbChains.Size = new System.Drawing.Size(77, 23);
            this.chbChains.TabIndex = 8;
            this.chbChains.Text = "Chains";
            this.chbChains.UseVisualStyleBackColor = true;
            // 
            // grbPayment
            // 
            this.grbPayment.Controls.Add(this.rbCREDITcard);
            this.grbPayment.Controls.Add(this.rbCASH);
            this.grbPayment.Controls.Add(this.rbCHEQUE);
            this.grbPayment.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPayment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.grbPayment.Location = new System.Drawing.Point(488, 294);
            this.grbPayment.Margin = new System.Windows.Forms.Padding(5);
            this.grbPayment.Name = "grbPayment";
            this.grbPayment.Size = new System.Drawing.Size(200, 128);
            this.grbPayment.TabIndex = 6;
            this.grbPayment.TabStop = false;
            this.grbPayment.Text = "Payment:";
            // 
            // rbCREDITcard
            // 
            this.rbCREDITcard.AutoSize = true;
            this.rbCREDITcard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCREDITcard.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbCREDITcard.Location = new System.Drawing.Point(6, 64);
            this.rbCREDITcard.Name = "rbCREDITcard";
            this.rbCREDITcard.Size = new System.Drawing.Size(109, 23);
            this.rbCREDITcard.TabIndex = 8;
            this.rbCREDITcard.TabStop = true;
            this.rbCREDITcard.Text = "Credit Card";
            this.rbCREDITcard.UseVisualStyleBackColor = true;
            // 
            // rbCASH
            // 
            this.rbCASH.AutoSize = true;
            this.rbCASH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCASH.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbCASH.Location = new System.Drawing.Point(6, 91);
            this.rbCASH.Name = "rbCASH";
            this.rbCASH.Size = new System.Drawing.Size(63, 23);
            this.rbCASH.TabIndex = 9;
            this.rbCASH.TabStop = true;
            this.rbCASH.Text = "Cash";
            this.rbCASH.UseVisualStyleBackColor = true;
            // 
            // rbCHEQUE
            // 
            this.rbCHEQUE.AutoSize = true;
            this.rbCHEQUE.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCHEQUE.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbCHEQUE.Location = new System.Drawing.Point(6, 37);
            this.rbCHEQUE.Name = "rbCHEQUE";
            this.rbCHEQUE.Size = new System.Drawing.Size(81, 23);
            this.rbCHEQUE.TabIndex = 7;
            this.rbCHEQUE.TabStop = true;
            this.rbCHEQUE.Text = "Cheque";
            this.rbCHEQUE.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPrice.Location = new System.Drawing.Point(245, 294);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(24, 28);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.MintCream;
            this.btnCalculate.Location = new System.Drawing.Point(12, 282);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 40);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.MintCream;
            this.btnReset.Location = new System.Drawing.Point(12, 329);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 40);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.MintCream;
            this.btnExit.Location = new System.Drawing.Point(12, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDiscount.Location = new System.Drawing.Point(289, 341);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(32, 28);
            this.lblDiscount.TabIndex = 12;
            this.lblDiscount.Text = "%";
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.AutoSize = true;
            this.LblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.ForeColor = System.Drawing.Color.DarkBlue;
            this.LblTotalPrice.Location = new System.Drawing.Point(148, 389);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(130, 28);
            this.LblTotalPrice.TabIndex = 13;
            this.LblTotalPrice.Text = "Total Price:";
            // 
            // pbCars
            // 
            this.pbCars.Image = global::ConfigureMyAuto.Properties.Resources.question_mark_460868_960_720;
            this.pbCars.Location = new System.Drawing.Point(12, 12);
            this.pbCars.Name = "pbCars";
            this.pbCars.Size = new System.Drawing.Size(434, 260);
            this.pbCars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCars.TabIndex = 0;
            this.pbCars.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(148, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Price: $";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(148, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Discount: %";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(704, 436);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTotalPrice);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.grbPayment);
            this.Controls.Add(this.grbExtraAdds);
            this.Controls.Add(this.lblChooseCar);
            this.Controls.Add(this.radbtnDODGE);
            this.Controls.Add(this.radbtnBMW);
            this.Controls.Add(this.radbtnFORD);
            this.Controls.Add(this.pbCars);
            this.ForeColor = System.Drawing.Color.Green;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Configure Your Own Auto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grbExtraAdds.ResumeLayout(false);
            this.grbExtraAdds.PerformLayout();
            this.grbPayment.ResumeLayout(false);
            this.grbPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCars;
        private System.Windows.Forms.RadioButton radbtnFORD;
        private System.Windows.Forms.RadioButton radbtnBMW;
        private System.Windows.Forms.RadioButton radbtnDODGE;
        private System.Windows.Forms.Label lblChooseCar;
        private System.Windows.Forms.GroupBox grbExtraAdds;
        private System.Windows.Forms.CheckBox chbABS;
        private System.Windows.Forms.CheckBox chbFogLights;
        private System.Windows.Forms.CheckBox chbChains;
        private System.Windows.Forms.GroupBox grbPayment;
        private System.Windows.Forms.RadioButton rbCREDITcard;
        private System.Windows.Forms.RadioButton rbCASH;
        private System.Windows.Forms.RadioButton rbCHEQUE;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

