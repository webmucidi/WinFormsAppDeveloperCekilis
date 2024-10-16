namespace WinFormsAppHaliSaha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKatil_Click(object sender, EventArgs e)
        {
            List<string> katilimcilar = new List<string> { "Tolga",
            "Batuhan","Kevser","Sude","Büþra","Enes"};

            for(int i = 0; i <katilimcilar.Count ; i++)
            {
                listBoxKatilanlar.Items.Add(katilimcilar[i]);
            }
        }
    }
}
