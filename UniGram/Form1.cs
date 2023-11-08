namespace UniGram
{
    public partial class Form1 : Form
    {
        public bool isOnDarkMode = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToggleTheme();
            ToggleTheme();
        }

        private void testButt_Click(object sender, EventArgs e)
        {
            ToggleTheme();
        }

        public void ToggleTheme()
        {
            BackColor = isOnDarkMode ? Color.White : Color.FromArgb(255, 32, 34, 37);
            testButt.BackColor = isOnDarkMode ? Color.FromArgb(255, 32, 34, 37) : Color.White;
            testButt.ForeColor = isOnDarkMode ? Color.White : Color.FromArgb(255, 32, 34, 37);

            isOnDarkMode = !isOnDarkMode;
        }
    }
}