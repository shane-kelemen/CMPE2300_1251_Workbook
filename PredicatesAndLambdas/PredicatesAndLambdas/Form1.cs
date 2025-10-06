using GDIDrawer;

namespace PredicatesAndLambdas
{
    public partial class Form1 : Form
    {
        static Random rng = new Random();
        static CDrawer canvas = new CDrawer();
		static int side = 100;

		List<int> myInts = new List<int>();
        List<Square> mySquares = new List<Square>();

        public static bool RemoveFromRight(Square obj)
        {
            if (obj == null) return true;

            return obj.TopLeft.X - obj.Side > canvas.ScaledWidth / 2;
        }

        static int SortDescending(int left, int right)
        {
            return right.CompareTo(left);
        }

        static bool RemoveEvens(int candidate)
        {
            return candidate % 2 == 0;
        }

        public Form1()
        {
            InitializeComponent();





            for (int i = 0; i < 50; ++i)
                myInts.Add(rng.Next(100));

            myInts.Sort(SortDescending);

            myInts.RemoveAll(RemoveEvens);

            mySquares.RemoveAll(RemoveFromRight);

            mySquares.Sort(delegate (Square left, Square right)
                                {
                                    if (left == null && right == null) return 0;
                                    if (left == null) return 1;
                                    if (right == null) return -1;

                                    return left.CompareTo(right) * -1;
                                });

            mySquares.Sort((left, right) => left.CompareTo(right) * -1);


			myIntsDisplay.Text = "";
            foreach(int i in myInts)
            {
                myIntsDisplay.Text += i + " ";
            }


			
		}
    }
}
