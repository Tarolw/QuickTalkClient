using System;
using System.Windows.Forms;

namespace chatClient
{
    public partial class ServerSettingsForm : Form
    {
        public ServerSettingsForm()
        {
            InitializeComponent();
        }

        private void ServerSettings_Load(object sender, EventArgs e)
        {
                //Создание объекта, для работы с файлом
                INIManager manager = new INIManager(Environment.CurrentDirectory.ToString() + "\\settings.ini");
                //Получить значение по ключу IP из секции SERVER
                TxtBoxIP.Text = manager.GetPrivateString("SERVER", "IP");
                //Получить значение по ключу Port из секции SERVER
                TxtBoxPort.Text = manager.GetPrivateString("SERVER", "Port");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (!ChatForm._connection) {
                //Создание объекта, для работы с файлом
                INIManager manager = new INIManager(Environment.CurrentDirectory.ToString() + "\\settings.ini");

                if (IsIpAddress(TxtBoxIP.Text))
                {
                    //Записать значение по ключу IP в секции SERVER
                    manager.WritePrivateString("SERVER", "IP", TxtBoxIP.Text);
                    ChatForm._serverIp = TxtBoxIP.Text;
                }
                else
                {
                    MessageBox.Show("Неверный формат IP адреса!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (int.Parse(TxtBoxPort.Text) > 0 && int.Parse(TxtBoxPort.Text) < 65535)
                {
                    //Записать значение по ключу Port в секции SERVER
                    manager.WritePrivateString("SERVER", "Port", TxtBoxPort.Text);
                    ChatForm._serverPort = Convert.ToInt32(TxtBoxPort.Text);
                }
                else
                {
                    MessageBox.Show("Неверный формат порта!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (IsIpAddress(TxtBoxIP.Text))
                    if (int.Parse(TxtBoxPort.Text) > 0 && int.Parse(TxtBoxPort.Text) < 65535)
                        this.Close();
            }
            else
            {
                MessageBox.Show("Нельзя изменить IP/Порт при активном подключении к серверу!", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        static bool IsIpAddress(string Address)
        {
            //Инициализируем новый экземпляр класса System.Text.RegularExpressions.Regex
            //для указанного регулярного выражения.
            System.Text.RegularExpressions.Regex IpMatch =
            new System.Text.RegularExpressions.Regex(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$");
            //Выполняем проверку обнаружено ли в указанной входной строке
            //соответствие регулярному выражению, заданному в
            //конструкторе System.Text.RegularExpressions.Regex.
            //если да то возвращаем true, если нет то false
            return IpMatch.IsMatch(Address);
        }

        private void TxtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
