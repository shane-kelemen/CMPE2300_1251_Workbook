namespace IntroToProperties
{
    public partial class Form1 : Form
    {
        static Random rng = new Random();
        Car _car;

        public Form1()
        {
            InitializeComponent();

			_txbColour.Click += _txbColour_Click;
			_btnCreateCar.Click += _btnCreateCar_Click;
            Color c = Color.Yellow;
            System.Diagnostics.Trace.WriteLine(c.GetBrightness());

           
            List<Car> cars = new List<Car>();
            string[] makes = { "Dodge", "Chrysler", "Jeep"};
            Color[] known = { Color.Red, Color.Blue, Color.Green };
            for (int i = 0; i < 100; ++i)
            {
                cars.Add(new Car(makes[rng.Next(3)], known[rng.Next(3)]));
            }

            Car equalityCompare = new Car("Jeep", Color.Blue);
            int count = 0;
            foreach (Car car in cars)
            {
                if (car.Equals(equalityCompare))
                    ++count;
            }

            Text = $"There were {count} Blue Jeeps in the cars List";

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
