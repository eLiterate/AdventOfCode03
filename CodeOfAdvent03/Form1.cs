namespace CodeOfAdvent03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] rucksacks = textBox1.Text.Split(System.Environment.NewLine);

            string UC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lc = "abcdefghijklmnopqrstuvwxyz";

            lc = " " + lc + UC;


            int total = 0;

            int group = 0;
            string[] elves = new string[3];

            int nElves = 0;
            int gTotal = 0;

            foreach(string rucksack in rucksacks)
            {
                elves[nElves++] = rucksack;
                if(nElves> 2) 
                {
                    for(int j = 0; j < 53; j++)
                    {
                        if (elves[0].Contains(lc[j]) && elves[1].Contains(lc[j]) && elves[2].Contains(lc[j]))
                        {
                            gTotal += j;
                        }
                    }
                    nElves = 0;
                }

                // Part 1;
                int l = rucksack.Length / 2;
                string comp1 = rucksack.Substring(0, l);
                string comp2 = rucksack.Substring(l);

                if(comp1.Length != comp2.Length)
                {
                    int jj = 0;
                }

                for(int i = 1;i<53;i++)
                {
                    if (comp1.Contains(lc[i]) && comp2.Contains(lc[i])) 
                    {
                        string str = lc[i].ToString();
                        total += i;
                        break;
                    }
                }
            }

            textBox2.Text = total.ToString();
            textBox3.Text = gTotal.ToString();
        }
    }
}