using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography;

namespace chatClient
{
    public partial class ChatForm : Form
    {
        // объявляем делегат, через который будет вызываться метод добавления нового сообщения 
        private delegate void printer(string data);
        // ещё один делегат, через который будем очищать чат и список онлайн пользователей
        private delegate void cleaner(); 
        //Создаем делегаты
        printer Printer;
        printer PrinterOnlineUsers;
        cleaner Cleaner;
        cleaner CleanerOnlineUsers;
        private Socket _serverSocket; // создаем сокет
        private Thread _clientThread;  // создаем поток в котором будем запускать прослушивание
        public static string _serverIp { get; set; } // IP 
        public static int _serverPort { get; set; } // порт
        public static bool _connection { get; set; } = false; // флаг установленно ли подключение к серверу
        public static bool _authoriz { get; set; } = false; // флаг авторизации

        public ChatForm() // Действия при запуске формы
        {
            Program.Chf = this; // передаем ссылку на форму
            InitializeComponent();
        }

        private void Connection() // подключение к серверу
        {
            // создаем экземпляры делегатов
            Printer = new printer(Print);
            PrinterOnlineUsers = new printer(PrintOnlineUsers);
            Cleaner = new cleaner(ClearChat);
            CleanerOnlineUsers = new cleaner(ClearOnlineUsers);
            _connection = Connect(); // конектимся к серверу
            _clientThread = new Thread(Listner) // запускаем прослушиваение в потоке
            {
                IsBackground = true // делаем поток фоновым
            }; 
            _clientThread.Start(); // запускаем поток
        }

        private void Listner() // слушаем сообщения с сервера
        {
            try
            {
                while (_serverSocket.Connected) // если сокет подключен к удаленному узлу, то считываем данные
                {
                    byte[] buffer = new byte[65536];  // создаем буфер для приема сообщений
                    int bytesRec = _serverSocket.Receive(buffer);  // принимаем данные
                    Array.Resize(ref buffer, bytesRec); // обрезаем массив байтов по длине полученного сообщения
                    buffer = DESCryptography.Decrypt(buffer, DESCryptography.Key, DESCryptography.Iv); // расшифровываем сообщение
                    string data = Encoding.UTF8.GetString(buffer); // преобразуем массив байтов в текст
                    HandleCommand(data); // передаем сообщение в обработчик команд
                }
            }
            catch(Exception)
            {
                ClearChat(); // очищаем окно чата
                ClearOnlineUsers(); // очищаем список онлайн пользователей
                Print($"Вы были отключены от сервера!");

                // Возвращаем все элементы формы в начальное положеие
                if (menuStrip.InvokeRequired)
                    TxtBoxUserName.Invoke(new Action(() => регистрацияToolStripMenuItem.Enabled = true));
                else
                    регистрацияToolStripMenuItem.Enabled = true;

                if (TxtBoxUserName.InvokeRequired)
                    TxtBoxUserName.Invoke(new Action(() => TxtBoxUserName.Enabled = true));
                else
                    TxtBoxUserName.Enabled = true;

                if (TxtBoxUserPassword.InvokeRequired)
                    TxtBoxUserPassword.Invoke(new Action(() => TxtBoxUserPassword.Enabled = true));
                else
                    TxtBoxUserPassword.Enabled = true;

                if (BtnEnterChat.InvokeRequired)
                    BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Enabled = true));
                else
                    BtnEnterChat.Enabled = true;

                if (BtnChatSend.InvokeRequired)
                    BtnChatSend.Invoke(new Action(() => BtnChatSend.Enabled = false));
                else
                    BtnChatSend.Enabled = false;

                if (TxtBoxChatMsg.InvokeRequired)
                    TxtBoxChatMsg.Invoke(new Action(() => TxtBoxChatMsg.Enabled = false));
                else
                    TxtBoxChatMsg.Enabled = false;

                if (BtnEnterChat.InvokeRequired)
                    BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Text = "Войти"));
                else
                    BtnEnterChat.Text = "Войти";
            }
        }

        private void HandleCommand(string data) // обработчик команд с сервера
        {
            if (data.Contains("#updatechat"))  
            {
                UpdateChat(data);  
                return;
            }
            else if (data.Contains("#history&"))
            {
                GetHistory(data); 
                return;
            }
            else if (data.Contains("#getonline&"))
            {
                GetOnline(data); // отображает список пользователей онлайн
                return;
            }
            else if (data.Contains("#auth&"))
            {
                if (menuStrip.InvokeRequired)
                    TxtBoxUserName.Invoke(new Action(() => регистрацияToolStripMenuItem.Enabled = false));
                else
                    регистрацияToolStripMenuItem.Enabled = false;
                _authoriz = true;
                return;
            }
            else if (data.Contains("#alreadyauth&"))
            {
                MessageBox.Show("Пользователь с этого аккаунта уже авторизирован!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (data.Contains("#badauth&"))
            {
                MessageBox.Show("Неверное имя пользователя или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (data.Contains("#badreg&"))
            {
                MessageBox.Show("Такое имя уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (data.Contains("#regandauth&"))
            {
                AuthSucsess();
                MessageBox.Show("Вы успешно зарегистрированны и авторизированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (data.Contains("#regoff&"))
            {
                MessageBox.Show("Регистрация на сервере выключена, обратитесь к администатору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool Connect() // подключение к серверу
        {
            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(_serverIp), _serverPort); 
                _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
                _serverSocket.Connect(ipEndPoint); // соединяемся с сервером
                return true;
            }
            catch
            {
                MessageBox.Show("Сервер недоступен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ClearChat() // очистка чата
        {
            // InvokeRequired возвращает значение, указывающее, следует ли вызывающему оператору обращаться к методу invoke во время вызовов метода из элемента управления, так как вызывающий оператор находится не в том потоке, в котором был создан элемент управления.
            if (this.InvokeRequired)    
            {
                this.Invoke(Cleaner);
                return;
            }
            TxtBoxChat.Clear();
        }

        private void ClearOnlineUsers() // очистка списка пользователей
        {
            if (this.InvokeRequired)    
            {
                this.Invoke(CleanerOnlineUsers);
                return;
            }
            TxtBoxOnline.Clear();
        }

        private void UpdateChat(string data)  // метод добавляет в чат принятое с сервера сообщение
        {
            string[] messages = data.Split('&')[1].Split('|'); // разбиваем строку на подстроки и занасим их в массив messages
            int countMessages = messages.Length; // вычисляем количество элементов массива

            if (countMessages == 0) return; // если массив пустой, то выходим из метода
   
                    Print($"[{messages[0].Split('~')[0]}]{messages[0].Split('~')[1]}"); // выводим сообщение в окно чата


        }

        private void GetHistory(string data)  // метод добавляет в чат историю сообщений с сервера
        {
            ClearChat();
            string[] messages = data.Split('&')[1].Split('|'); // разбиваем строку на подстроки и занасим их в массив messages
            int countMessages = messages.Length; // вычисляем количество элементов массива

            if (countMessages == 0) return; // если массив пустой, то выходим из метода

            for(int i = 0; i < countMessages; i++) // выводим сообщения в окно чата
            {
                try
                {
                    if (string.IsNullOrEmpty(messages[i])) continue; // если строка пустая то не выполняем метод print, последняя строка всегда будет пустой т.к. | стоит в конце и Split определит в конце пустую строку
                    Print($"[{messages[i].Split('~')[0]}]{messages[i].Split('~')[1]}"); // выводим сообщение в окно чата
                }
                catch { continue; } 
            }
        }

        private void GetOnline(string data)  // выводит список онлайн пользователей
        {
            ClearOnlineUsers();
            //данные в data имеют вид: #getonline&ИмяПользователя|ИмяПользователя|
            string[] users = data.Split('&')[1].Split('|'); // разбиваем строку на подстроки и занасим их в массив messages
            int countUsers = users.Length; // вычисляем количество пользователей

            if (countUsers == 0) return; // если массив пустой, то выходим из метода

            for (int i = 0; i < countUsers; i++) // выводим сообщения в окно чата
            {
                try
                {
                    if (string.IsNullOrEmpty(users[i])) continue; // если строка пустая то не выполняем метод print, последняя строка всегда будет пустой т.к. | стоит в конце и Split определит в конце пустую строку
                    PrintOnlineUsers($"{users[i]}"); // выводим сообщение в окно чата
                }
                catch { continue; }
            }
        }

        public void Send(string data) // отправляет данные на сервер
        {
            try
            {
                byte[] buff = DESCryptography.Encrypt(data, DESCryptography.Key, DESCryptography.Iv); // шифруем сообщение
                int bytesSend = _serverSocket.Send(buff); // передаем массив байтов в сокет
            }
            catch
            {
                Print( "Нет подключения к серверу...");
            }
        }

        private void Print(string msg) // добавление сообщения в чат
        {
            if (this.InvokeRequired)
            {
                this.Invoke(Printer, msg);
                return;
            }
            if (TxtBoxChat.Text.Length == 0) // Если в chatBox'е пусто, то
                TxtBoxChat.AppendText(msg); // выводим сообщение в chatBox
            else 
                TxtBoxChat.AppendText(Environment.NewLine + msg); // добавляем сообщение с новой строки
        }

        private void PrintOnlineUsers(string msg) // выводит список онлайн пользователей
        {
            if (this.InvokeRequired)
            {
                this.Invoke(PrinterOnlineUsers, msg);
                return;
            }
            if (TxtBoxOnline.Text.Length == 0) 
                TxtBoxOnline.AppendText(msg); 
            else
                TxtBoxOnline.AppendText(Environment.NewLine + msg); 
        }

        public string GetHashString(string s) // создание хэша MD5 из строки
        {
            //переводим строку в байт-массим  
            byte[] bytes = Encoding.Unicode.GetBytes(s);

            //создаем объект для получения средст шифрования  
            MD5CryptoServiceProvider CSP =
                new MD5CryptoServiceProvider();

            //вычисляем хеш-представление в байтах  
            byte[] byteHash = CSP.ComputeHash(bytes);

            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }

        private void EnterChat_Click(object sender, EventArgs e) // Кнопка войти в чат
        {
            if (!_connection) // если подключениек не активно то пытаемся подкючится к серверу
            {
                if (TxtBoxUserName.Text != String.Empty && TxtBoxUserPassword.Text != String.Empty)
                {
                    ChatInAsync();
                }
                else
                {
                    MessageBox.Show("Поля имя пользоватяля и пароль не могут быть пустыми!", "Ошибка", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                ChatLogOff(); // отключаемся от сервера
            }
        }

        private async void ChatInAsync() // метод асинхронно вызывающий метод ChatIn
        {
            await Task.Run(() => ChatIn());
        }

        private void ChatIn() // Авторизация в чате
        {
                if (BtnEnterChat.InvokeRequired)
                    BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Enabled = false));
                else
                    BtnEnterChat.Enabled = false;
                Connection();
                Stopwatch timeConnect = new Stopwatch();
                timeConnect.Start();
                while (timeConnect.Elapsed < TimeSpan.FromSeconds(5)) // в течении 5 секунд проверяем установленно ли подключение к серверу
                {
                    if (_connection) // как только подключение будет установленно отправляем данные пользователя на сервер
                    {
                        ClearChat();
                        string Name = TxtBoxUserName.Text; 
                        string Password = GetHashString(TxtBoxUserPassword.Text);
                        Send($"#authoriz&{Name}~{Password}");
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        while (time.Elapsed < TimeSpan.FromSeconds(5)) 
                        {
                            if (_authoriz)
                            {
                                AuthSucsess();
                                MessageBox.Show("Вы авторизированы!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                            }
                        }
                    time.Stop();
                    if (!_authoriz)
                    {
                        ChatLogOff();
                    }
                        break;
                    }
                }
                timeConnect.Stop(); // останавливаем таймер
                if (!_connection)
                {
                    if (BtnEnterChat.InvokeRequired)
                        BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Enabled = true));
                    else
                        BtnEnterChat.Enabled = true;
                }
        }

        private void AuthSucsess() 
        {
            // Активируем видимость элеменов чата и отключаем видимость элементов регистрации в чате

            if (TxtBoxChatMsg.InvokeRequired)
                TxtBoxChatMsg.Invoke(new Action(() => TxtBoxChatMsg.Enabled = true));
            else
                TxtBoxChatMsg.Enabled = true;

            if (BtnChatSend.InvokeRequired)
                BtnChatSend.Invoke(new Action(() => BtnChatSend.Enabled = true));
            else
                BtnChatSend.Enabled = true;

            if (TxtBoxUserPassword.InvokeRequired)
                TxtBoxUserPassword.Invoke(new Action(() => TxtBoxUserPassword.Enabled = false));
            else
                TxtBoxUserPassword.Enabled = false;

            if (TxtBoxUserName.InvokeRequired)
                TxtBoxUserName.Invoke(new Action(() => TxtBoxUserName.Enabled = false));
            else
                TxtBoxUserName.Enabled = false;

            if (TxtBoxChatMsg.InvokeRequired)
                TxtBoxChatMsg.Invoke(new Action(() => TxtBoxChatMsg.Focus()));
            else
                TxtBoxChatMsg.Focus();

            if (BtnEnterChat.InvokeRequired)
                BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Enabled = true));
            else
                BtnEnterChat.Enabled = true;

            if (BtnEnterChat.InvokeRequired)
                BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Text = "Выйти"));
            else
                BtnEnterChat.Text = "Выйти";

           
        }

        private void ChatLogOff() // выйти из чата
        {

            if (BtnChatSend.InvokeRequired)
                BtnChatSend.Invoke(new Action(() => BtnChatSend.Enabled = false));
            else
                BtnChatSend.Enabled = false;

            if (TxtBoxChatMsg.InvokeRequired)
                TxtBoxChatMsg.Invoke(new Action(() => TxtBoxChatMsg.Enabled = false));
            else
                TxtBoxChatMsg.Enabled = false;

            if (BtnEnterChat.InvokeRequired)
                BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Enabled = true));
            else
                BtnEnterChat.Enabled = true;

            if (BtnEnterChat.InvokeRequired)
                BtnEnterChat.Invoke(new Action(() => BtnEnterChat.Text = "Войти"));
            else
                BtnEnterChat.Text = "Войти";

            if (menuStrip.InvokeRequired)
                TxtBoxUserName.Invoke(new Action(() => регистрацияToolStripMenuItem.Enabled = false));
            else
                регистрацияToolStripMenuItem.Enabled = false;

            _authoriz = false;
            _connection = false;
            ClearChat(); // очищаем чат
            ClearOnlineUsers(); // очищаем список онлайн пользователей
            EndSession(); // отключаемся от сервера
        }

        private void EndSession() // отключится от сервера
        {
            try
            {
                _serverSocket.Close(); // закрываем сокет и освобождаем все связанные ресурсы
                try
                {
                    _clientThread.Abort(); // Вызывает исключение ThreadAbortException в вызвавшем его потоке для того, чтобы начать процесс завершения потока. 
                }
                catch
                {
                    // ---
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"{exp.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Chat_send_Click(object sender, EventArgs e) // Кнопка отправки сообщения
        {
            SendMessage();
        }

        private void SendMessage() // Формирование и отправление сообщения 
        {
            try
            {
                string data = TxtBoxChatMsg.Text;  // заносим текст сообщения в переменнцю data
                if (string.IsNullOrEmpty(data)) return; // если сообщение пустое, то выходим из метода
                Send("#newmsg&" + data); // отправляем сообщение
                TxtBoxChatMsg.Text = string.Empty;
                TxtBoxChatMsg.Focus();
            }
            catch
            {
                MessageBox.Show("Ошибка при отправке сообщения!", "Ошибка", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void ChatBox_KeyDown(object sender, KeyEventArgs e) // отправка сообщения при нажатии Enter
        {
            if (e.KeyData == Keys.Enter)
            {
                SendMessage();
            }
        }

        private void Chat_msg_KeyDown(object sender, KeyEventArgs e) // отправка сообщения при нажатии Enter
        {
            if (e.KeyData == Keys.Enter)
            {
                SendMessage();
            }
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(796, 600);
            GetKeyIv();
            TxtBoxUserName.Select();
            //Создание объекта, для работы с файлом
            INIManager manager = new INIManager(Environment.CurrentDirectory.ToString() + "\\settings.ini");
            _serverIp = manager.GetPrivateString("SERVER", "IP");
            _serverPort = int.Parse(manager.GetPrivateString("SERVER", "Port"));
        }

        private void Chat_msg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Запрещаем ввод символа переноса при нажатии Enter
            if (e.KeyChar == 13)
                e.Handled = true;
        }

        private void IPПортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerSettingsForm formServer = new ServerSettingsForm();
            formServer.ShowDialog();
        }

        private void KeyIvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CryptographyForm formCrypt = new CryptographyForm();
            formCrypt.ShowDialog();
        }

        private void входРегистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!_connection)
            {
                Connection();
            }
            RegInAsync();
        }

        private static void GetKeyIv()
        {
                //Создание объекта, для работы с файлом
                INIManager manager = new INIManager(Environment.CurrentDirectory.ToString() + "\\settings.ini");
                DESCryptography.Key = Convert.FromBase64String(manager.GetPrivateString("CRYPT", "Key"));    
                DESCryptography.Iv = Convert.FromBase64String(manager.GetPrivateString("CRYPT", "Iv"));      
        }

        private async void RegInAsync()
        {
            await Task.Run(() => RegAction());
        }
        private void RegAction()
        {
            Stopwatch timeConnect = new Stopwatch();
            timeConnect.Start();
            // в течении 5 секунд проверяем установленно ли подключение к серверу
            while (timeConnect.Elapsed < TimeSpan.FromSeconds(5)) 
            {
                // как только подключение будет установленно отправляем данные пользователя на сервер
                if (_connection) 
                {
                    RegistrationForm formReg = new RegistrationForm();
                    formReg.ShowDialog();
                    break;
                }
            }
            timeConnect.Stop(); // останавливаем таймер
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            {
                AboutProgrammForm formAbout = new AboutProgrammForm();
                formAbout.ShowDialog();
            }
        }

    }
}
