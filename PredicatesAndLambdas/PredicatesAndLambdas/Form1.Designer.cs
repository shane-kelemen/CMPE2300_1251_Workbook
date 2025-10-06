namespace PredicatesAndLambdas
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
			myIntsDisplay = new Label();
			SuspendLayout();
			// 
			// myIntsDisplay
			// 
			myIntsDisplay.Location = new Point(78, 70);
			myIntsDisplay.Name = "myIntsDisplay";
			myIntsDisplay.Size = new Size(626, 273);
			myIntsDisplay.TabIndex = 0;
			myIntsDisplay.Text = "label1";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(myIntsDisplay);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Label myIntsDisplay;
	}
}
