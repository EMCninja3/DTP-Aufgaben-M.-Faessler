namespace DatenstrukturenAlgorithmus
{
    public partial class Form1 : Form
    {
        public List<int> resultat = new List<int>();
        private int alterTeiler;
        private bool divided = false;
        public Form1()
        {
            InitializeComponent();
            //Funktioniert nicht!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        public void FaktorZerlegung(int zahl)
        {
            if(zahl < 2)
            {
                //resultat.Add(zahl);
                return;
            }
            int teiler = zahl / 2;
            while (zahl % teiler != 0)
            {
                teiler--;
            }
            divided = true;
            if (teiler == 1)
            {
                return;
            }
            alterTeiler = teiler;

            resultat.Add(teiler);

            FaktorZerlegung(zahl / teiler);

            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultat.Clear();
            alterTeiler = Convert.ToInt32(TxtZahl.Text);
            TxtResultat.Clear();
            FaktorZerlegung(alterTeiler);
            int i = 0; ;
            foreach (var item in resultat)
            {
                if (i!=0)
                {
                    TxtResultat.Text += " * " + item.ToString();
                }
                else
                {
                    TxtResultat.Text += item.ToString();
                }
                i++;
            }
        }
    }
}