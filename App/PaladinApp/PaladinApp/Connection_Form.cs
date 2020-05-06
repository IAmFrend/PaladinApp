using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.Sql;
using System.Data.SqlClient;
using PaladinApp;
using System.Threading;
using System.Diagnostics;


namespace PaladinApp
{
    public partial class Connection_Form : Form
    {
        public Connection_Form()
        {
            InitializeComponent();
        }

        private void Connection_Form_Load(object sender, EventArgs e)
        {
            //Получение данных о серверах
            Configuration_class configuration = new Configuration_class();
            configuration.Server_Collection += Configuration_Server_Collection;
            Thread threadServers = new Thread(configuration.SQL_Server_Enumenator);
            threadServers.Start();
        }
        /// <summary>
        /// Метод вызова доступных серверов
        /// </summary>
        /// <param name="obj"> Таблица серверов</param>
        private void Configuration_Server_Collection(DataTable obj)
        {
            //Сздание и запуск фонового потока
            Action action = () =>
            {
                foreach (DataRow r in obj.Rows)
                {
                    cbServer.Items.Add(string.Format(@"{0}\{1}", r[0], r[1]));
                }
                cbServer.Enabled = true;
                btChecked.Enabled = true;
            };
            Invoke(action);
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Создание списка БД сервера
        /// </summary>
        private void CbServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration_class configuration = new Configuration_class();
            configuration.ds = cbServer.SelectedItem.ToString();
            configuration.Conection_Checked += Configuration_Conection_Checked;
            Thread thread = new Thread(configuration.SQL_Data_Base_Checking);
            thread.Start();
        }

        //Действия после проверки соединения
        private void Configuration_Conection_Checked(bool obj)
        {
            switch (obj)
            {
                case true:
                    MessageBox.Show("Sukcess");
                    Action action = () =>
                    {
                        //Заполнение списка БД
                        Configuration_class configuration_call = new Configuration_class();
                        configuration_call.Data_Base_Collection += Configuration_Data_Base_Collection;
                        Thread threadBases = new Thread(configuration_call.SQL_Data_Base_Collection);
                        threadBases.Start();
                        btConnect.Enabled = true;
                    };
                    Invoke(action);
                    break;
                case false:
                    //ПОвторное сканирование
                    Configuration_class configuration = new Configuration_class();
                    configuration.Server_Collection += Configuration_Server_Collection;
                    Thread threadServers = new Thread(configuration.SQL_Server_Enumenator);
                    threadServers.Start();
                    break;
            }
        }

        //Заполнение спискка БД
        private void Configuration_Data_Base_Collection(DataTable obj)
        {
            Action action = () =>
            {
                foreach (DataRow r in obj.Rows)
                {
                    cbDatabase.Items.Add(r[0]);
                }
                cbDatabase.Enabled = true;
            };
            Invoke(action);
        }

        private void BtChecked_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection(string.Format("Data Source = {0}; Initial Catalog = {1}; Integrated Security = true;", cbServer.Text, cbDatabase.Text));
            try
            {
                sql.Open();
                btConnect.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Подключение не установлено!", "PaladinApp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.Close();
                MessageBox.Show("Подключение успешно!","PaladinApp",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtConnect_Click(object sender, EventArgs e)
        {
            switch (cbDatabase.Text == "")
            {
                case true:
                    MessageBox.Show("Выберите базу данных!", "Продажа товара", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbDatabase.Focus();
                    break;
                case false:
                    Configuration_class configuration = new Configuration_class();
                    configuration.SQL_Server_Configuration_Set(cbServer.Text, cbDatabase.Text);
                    Program.connect = true;
                    Application.Restart();
                    break;
            }
        }
    }
}
