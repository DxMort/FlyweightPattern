namespace FlyeightPattern
{
    public partial class Form1 : Form
    {
        private CharacterFabric _characterFactory;
        private string filePath = "";
        public Form1()
        {
            InitializeComponent();
            _characterFactory = new CharacterFabric();
            comboBoxType.Items.Add("Ðûöàðü");
            comboBoxType.Items.Add("Ëó÷íèê");
            comboBoxType.Items.Add("ßùåð");
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                MessageBox.Show("Âûáåðèòå èçîáðàæåíèå");
                return;
            }
            if (textBoxName.Text == "" || comboBoxType.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            var character1 = _characterFactory.CreateCharacter(textBoxName.Text, comboBoxType.Text, filePath);


            pictureBoxImg.Image = Image.FromFile(filePath);
            filePath = "";
            labelReturn.Text = character1.Display();
        }

        private void buttonSetPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var directoryPath = System.IO.Path.GetDirectoryName(filePath);
                    var fileName = System.IO.Path.GetFileName(filePath);
                    MessageBox.Show($"{fileName} çàãðóæåí.", directoryPath, MessageBoxButtons.OK);
                }
            }
        }

        private void buttonAddAtr_Click(object sender, EventArgs e)
        {
            if (textBoxExp.Text == "" || textBoxLvl.Text == "")
            {
                MessageBox.Show("Çàïîëíèòå âñå ïîëÿ");
                return;
            }
            CharacterAtribute charAtr1 = new CharacterAtribute(Convert.ToInt32(textBoxLvl.Text), Convert.ToInt32(textBoxExp.Text));
            MessageBox.Show($"Óðîâåíü: {charAtr1.Level}, îïûò: {charAtr1.Experience}");
        }
    }
}
