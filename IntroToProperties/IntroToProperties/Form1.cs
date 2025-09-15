namespace IntroToProperties
{
    public partial class Form1 : Form
    {
        Car _car;

        public Form1()
        {
            InitializeComponent();

			_txbColour.Click += _txbColour_Click;
			_btnCreateCar.Click += _btnCreateCar_Click;
            Color c = Color.Yellow;
            System.Diagnostics.Trace.WriteLine(c.GetBrightness());
        }

		private void _btnCreateCar_Click(object? sender, EventArgs e)
		{
			try
            {
                _car = new Car(_tbxVIN.Text, _txbMake.Text,
                                _tbxModel.Text, _txbColour.BackColor);
                _car.Mileage = decimal.Parse(_txbMileage.Text);

                _lblCarSummary.Text = $"{_car.VIN}\n{_car.MAKE}\n"
                                + $"{_car.MODEL}\n{_car.Colour}\n" 
                                + $"{_car.Mileage}";
            }
            catch (ArgumentException ex)
            {
                _lblStatus.Text = ex.Message;
            }
            catch (Exception ex)
            {
                _lblStatus.Text = ex.Message;
            }
		}

		private void _txbColour_Click(object? sender, EventArgs e)
		{
            ColorDialog cdlgSelector = new ColorDialog();
            cdlgSelector.Color = _txbColour.BackColor;

            if (cdlgSelector.ShowDialog() == DialogResult.OK)
            {
                _txbColour.BackColor = cdlgSelector.Color;
            }
		}
	}
}
