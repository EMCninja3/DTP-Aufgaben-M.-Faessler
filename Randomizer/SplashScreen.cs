namespace Randomizer
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void CmdGoToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeScreen homeScreen = new HomeScreen();
            homeScreen.ShowDialog();
            this.Close();
        }
    }
}