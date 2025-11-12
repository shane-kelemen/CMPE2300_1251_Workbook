namespace InheritanceFun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BaseClass b = new BaseClass(4);
            DerivedClass d = new DerivedClass(100);
            ThirdClass t = new ThirdClass();

   //         label1.Text += b.Show() + "\n";
			//label1.Text += d.Show() + "\n";
   //         label1.Text += t.Show();

            List<BaseClass> stuff = new List<BaseClass>();
            stuff.Add(b);
            stuff.Add(d);
            stuff.Add(t);

            foreach (BaseClass bc in stuff)
            {
                if (bc is ThirdClass)
                    label1.Text += (bc as ThirdClass)?.Show();
                else if (bc is DerivedClass)
                    label1.Text += (bc as DerivedClass)?.Show();
                else
                    label1.Text += bc.Show();

                    label1.Text += "\n";
            }
		}
    }

    class BaseClass
    {
        protected int value;
        protected static decimal number;

        public int Value
        { get { return value; } }

        static BaseClass()
        {
            number = 1000;
        }

        public BaseClass(int v)
        {
            value = v;
        }

        public BaseClass()
        {

        }
        
        public string Show()
        {
            return "Show in Base : " + Value.ToString();
        }

    }

    class DerivedClass : BaseClass
    {
        static DerivedClass()
        {
            number = 10000;
        }

        public DerivedClass() : base()
        {

        }

        public DerivedClass(int num) : base(num)
        {
            value = 6;
        }
        //public new string Show()
        //{
        //    string output = base.Show() + "\nShow in Derived : " + Value.ToString();

        //    return output;
        //}
    }

    class ThirdClass : DerivedClass
    {
        public ThirdClass() : base(20)
        {
            value = 200;
        }

        public new string Show()
        {
            string output = base.Show() + "\nShow in Third : " + Value;
            return output;
        }
    }









}
