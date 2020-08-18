using System;
using System.Windows.Forms;

namespace chatClient
{
    public partial class CryptographyForm : Form
    {
        public CryptographyForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            //Создание объекта, для работы с файлом
            INIManager manager = new INIManager(Environment.CurrentDirectory.ToString() + "\\settings.ini");

            if (IsBase64(TxtBoxKey.Text))
            {
                manager.WritePrivateString("CRYPT", "Key", TxtBoxKey.Text);
                DESCryptography.Key = Convert.FromBase64String(manager.GetPrivateString("CRYPT", "Key"));
            }
            else
            {
                MessageBox.Show("Неверный формат ключа!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (IsBase64(TxtBoxIv.Text))
            {
                manager.WritePrivateString("CRYPT", "Iv", TxtBoxIv.Text);
                DESCryptography.Iv = Convert.FromBase64String(manager.GetPrivateString("CRYPT", "Iv"));
            }
            else
            {
                MessageBox.Show("Неверный формат вектора!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            // если все правильно, то закрываем форму
            if (IsBase64(TxtBoxKey.Text))
                if (IsBase64(TxtBoxIv.Text))
                    this.Close();
        }

        private void Cryptography_Load(object sender, EventArgs e)
        {
            //Создание объекта, для работы с файлом
            INIManager manager = new INIManager(Environment.CurrentDirectory.ToString() + "\\settings.ini");
            //Получить значение по ключу Key из секции CRYPT
            TxtBoxKey.Text = manager.GetPrivateString("CRYPT", "Key");
            //Получить значение по ключу Iv из секции CRYPT
            TxtBoxIv.Text = manager.GetPrivateString("CRYPT", "Iv");
        }

        static bool IsBase64(string Base64String) // проверка на формат Base64
        {
            //Инициализируем новый экземпляр класса System.Text.RegularExpressions.Regex
            //для указанного регулярного выражения.
            System.Text.RegularExpressions.Regex IpMatch =
            new System.Text.RegularExpressions.Regex(@"^(?:[A-Za-z0-9+/]{4})*(?:[A-Za-z0-9+/]{2}==|[A-Za-z0-9+/]{3}=)?$");
            //Выполняем проверку обнаружено ли в указанной входной строке
            //соответствие регулярному выражению, заданному в
            //конструкторе System.Text.RegularExpressions.Regex.
            //если да то возвращаем true, если нет то false
            return IpMatch.IsMatch(Base64String);
        }
    }
}
