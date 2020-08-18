using System;
using System.Windows.Forms;

namespace chatClient
{
    static class Program
    {
        public static ChatForm Chf; // переменная для хранения ссылки на главную форму
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChatForm());
        }
    }
}
