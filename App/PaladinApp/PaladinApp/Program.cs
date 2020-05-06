using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PaladinApp
{
    static class Program
    {
        //переменная учётной записи
        public static string intID;
        //переменная адреса отправки
        public static string strMail = "michaellvovthefrend@gmail.com";
        //Наличие подключения к БД
        public static bool connect = false;
        //Класс виртуального интерфейса приложения
        private static Mutex instanse;
        //Название приложения
        private const string app_Name = "PaladinApp";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Проверка запущенного приложения
            bool Create_App;
            instanse = new Mutex(true, app_Name, out Create_App);
            if (Create_App)
            {
                //Проект в системе на запущен
                try
                {
                    //Проверка подключения
                    Configuration_class configuration = new Configuration_class();
                    configuration.SQL_Server_Configuration_Get();
                    Configuration_class.connection.Open();
                    connect = true;
                }
                catch
                {
                    //Загрузка резервной формы
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Connection_Form connection = new Connection_Form();
                    connection.ShowDialog();
                }
                finally
                {
                    Configuration_class.connection.Close();
                    //Проверка подключения
                    switch (connect)
                    {
                        //Подключение не установлено
                        case false:
                            MessageBox.Show("Ошибка подключения к источнику данных", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(0);
                            break;
                        //Подключение установлено
                        case true:
                            try
                            {
                                Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                Application.Run(new Loading());
                            }
                            catch
                            {

                            }
                            break;
                    }
                }
            }
            else
            {

            }
        }
    }
}
