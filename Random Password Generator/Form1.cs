namespace Random_Password_Generator
{
    public partial class Form1 : Form
    {
        int currentLength = 0;
        Random character = new Random();

        public string passwordGenerator(int passwordlength)
        {
            string allCharacters = "ABCDEFGHIJKLMNOPRSTUWXYZabcdefghijklmnoprstuwxyz1234567890!@#$%^&*()_+-=";
            string randomPassword = "";

            for(int i = 0; i < passwordlength; i++)
            {
                randomPassword = string.Concat(randomPassword, allCharacters[character.Next(0,71)]);
            }

            return randomPassword;
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordLabel.Text);

        }

        private void LengthSlide_Scroll(object sender, EventArgs e)
        {
            PasswordLengthLabel.Text = "Password Length: " + LengthSlide.Value;
            currentLength = LengthSlide.Value;
            PasswordLabel.Text = passwordGenerator(LengthSlide.Value);
        }


    }
}