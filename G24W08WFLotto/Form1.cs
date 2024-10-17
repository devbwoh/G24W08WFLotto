namespace G24W08WFLotto {
    public partial class Form1 : Form {
        private const int LottoCount = 6;

        public Form1() {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            int[] num = new int[LottoCount];
            Random r = new Random();

            for (int i = 0; i < num.Length; i++) {
                int n = 0;
                do {
                    n = r.Next(1, 46);
                } while (num.Contains(n));
                //} while (Array.IndexOf(num, n) > -1);

                num[i] = n;
            }

            Array.Sort(num);

            Num1.Text = num[0].ToString();
            Num2.Text = num[1].ToString();
            Num3.Text = num[2].ToString();
            Num4.Text = num[3].ToString();
            Num5.Text = num[4].ToString();
            Num6.Text = num[5].ToString();
        }
    }
}
