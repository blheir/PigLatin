namespace PigLatin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oinkButton_Click(object sender, EventArgs e)
        {
            string word = userWord.Text;
            string pigLatin = word.Substring(1) + word[0] + "ay";
            if (word.Length > 1)
            {
                pigWord.Text = pigLatin;
            }
            else
            {
                pigWord.Text = "Error: Please enter a word.";
            }
        }
    }
}
