namespace IntroToProperties
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			_tbxVIN = new TextBox();
			_tbxModel = new TextBox();
			_txbMake = new TextBox();
			_txbColour = new TextBox();
			_txbMileage = new TextBox();
			_btnCreateCar = new Button();
			_lblCarSummary = new Label();
			_lblStatus = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(77, 41);
			label1.Name = "label1";
			label1.Size = new Size(26, 15);
			label1.TabIndex = 0;
			label1.Text = "VIN";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(77, 92);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 1;
			label2.Text = "Make";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(77, 144);
			label3.Name = "label3";
			label3.Size = new Size(41, 15);
			label3.TabIndex = 2;
			label3.Text = "Model";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(77, 207);
			label4.Name = "label4";
			label4.Size = new Size(43, 15);
			label4.TabIndex = 3;
			label4.Text = "Colour";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(77, 269);
			label5.Name = "label5";
			label5.Size = new Size(49, 15);
			label5.TabIndex = 4;
			label5.Text = "Mileage";
			// 
			// _tbxVIN
			// 
			_tbxVIN.Location = new Point(176, 38);
			_tbxVIN.Name = "_tbxVIN";
			_tbxVIN.Size = new Size(100, 23);
			_tbxVIN.TabIndex = 5;
			// 
			// _tbxModel
			// 
			_tbxModel.Location = new Point(176, 141);
			_tbxModel.Name = "_tbxModel";
			_tbxModel.Size = new Size(100, 23);
			_tbxModel.TabIndex = 6;
			// 
			// _txbMake
			// 
			_txbMake.Location = new Point(176, 89);
			_txbMake.Name = "_txbMake";
			_txbMake.Size = new Size(100, 23);
			_txbMake.TabIndex = 7;
			// 
			// _txbColour
			// 
			_txbColour.BackColor = Color.Black;
			_txbColour.Location = new Point(176, 204);
			_txbColour.Name = "_txbColour";
			_txbColour.ReadOnly = true;
			_txbColour.Size = new Size(100, 23);
			_txbColour.TabIndex = 8;
			// 
			// _txbMileage
			// 
			_txbMileage.Location = new Point(176, 266);
			_txbMileage.Name = "_txbMileage";
			_txbMileage.Size = new Size(100, 23);
			_txbMileage.TabIndex = 9;
			// 
			// _btnCreateCar
			// 
			_btnCreateCar.Location = new Point(104, 320);
			_btnCreateCar.Name = "_btnCreateCar";
			_btnCreateCar.Size = new Size(125, 36);
			_btnCreateCar.TabIndex = 10;
			_btnCreateCar.Text = "Create Car";
			_btnCreateCar.UseVisualStyleBackColor = true;
			// 
			// _lblCarSummary
			// 
			_lblCarSummary.BorderStyle = BorderStyle.Fixed3D;
			_lblCarSummary.Location = new Point(452, 72);
			_lblCarSummary.Name = "_lblCarSummary";
			_lblCarSummary.Size = new Size(238, 252);
			_lblCarSummary.TabIndex = 11;
			_lblCarSummary.Text = "label6";
			// 
			// _lblStatus
			// 
			_lblStatus.Location = new Point(185, 394);
			_lblStatus.Name = "_lblStatus";
			_lblStatus.Size = new Size(413, 21);
			_lblStatus.TabIndex = 12;
			_lblStatus.Text = "Enter Car Details!";
			_lblStatus.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(800, 450);
			Controls.Add(_lblStatus);
			Controls.Add(_lblCarSummary);
			Controls.Add(_btnCreateCar);
			Controls.Add(_txbMileage);
			Controls.Add(_txbColour);
			Controls.Add(_txbMake);
			Controls.Add(_tbxModel);
			Controls.Add(_tbxVIN);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox _tbxVIN;
		private TextBox _tbxModel;
		private TextBox _txbMake;
		private TextBox _txbColour;
		private TextBox _txbMileage;
		private Button _btnCreateCar;
		private Label _lblCarSummary;
		private Label _lblStatus;
	}
}
