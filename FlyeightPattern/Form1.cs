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
            comboBoxType.Items.Add("Рыцарь");
            comboBoxType.Items.Add("Лучник");
            comboBoxType.Items.Add("Ящер");
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                MessageBox.Show("Выберите изображение");
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
                    MessageBox.Show($"{fileName} загружен.", directoryPath, MessageBoxButtons.OK);
                }
            }
        }

        private void buttonAddAtr_Click(object sender, EventArgs e)
        {
            if (textBoxExp.Text == "" || textBoxLvl.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            CharacterAtribute charAtr1 = new CharacterAtribute(Convert.ToInt32(textBoxLvl.Text), Convert.ToInt32(textBoxExp.Text));
            MessageBox.Show($"Уровень: {charAtr1.Level}, опыт: {charAtr1.Experience}");
        }
    }
}