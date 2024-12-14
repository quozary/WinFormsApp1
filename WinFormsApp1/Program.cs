using System;
using System.Windows.Forms;

namespace AutoRUApp
{
    static class Program
    {
        // Главный метод, точка входа в приложение
        [STAThread] // Атрибут для работы с COM и потоками Windows
        static void Main()
        {
            // Установка стилистики приложения
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск главной формы приложения
            Application.Run(new MainForm());
        }
    }
}
