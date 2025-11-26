namespace NVI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<BaseClass> classes = new List<BaseClass>();

            classes.Add(new LeftClass());
			classes.Add(new RightClass());
			classes.Add(new LeftClass());
			classes.Add(new RightClass());
            classes.Add(new AnotherClass());

            label1.Text = "";
            foreach (BaseClass b in classes)
                label1.Text += b.EntryMethod();

		}
    }
}
