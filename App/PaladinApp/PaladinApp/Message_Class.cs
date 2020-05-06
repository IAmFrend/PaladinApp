using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace PaladinApp
{
    class Message_Class
    {
        public string ex = "None";
        public Message_Class(string Server,string Login, string Password, string MailFrom, string MailTo, string Subject, string Body, string AttachmentPath)
        {
            try
            {
                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress(MailFrom);
                // кому отправляем
                MailAddress to = new MailAddress(MailTo);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = Subject;
                // текст письма
                m.Body = "<h2>" + Body + "</h2>";
                // письмо представляет код html
                m.IsBodyHtml = true;
                //прикрепление файла
                if (AttachmentPath != "")
                    m.Attachments.Add(new Attachment(AttachmentPath));
                // адрес smtp-сервера и порт, с которого будет отправляться письмо
                SmtpClient smtp = new SmtpClient(Server);
                // логин и пароль
                smtp.Credentials = new NetworkCredential(Login, Password);
                smtp.EnableSsl = true;
                //Отправка
                smtp.Send(m);
                ex = "Письмо отправлено";
            }
            //catch (WebException we)
            //{
            //    //Ошибка при обащении к сети
            //    ex = "Отсутствует подключение к интернету";
            //}
            //catch (SmtpException se)
            //{
            //    //Ошибка при подключении Smtp
            //    ex = "Возможно ваши данные введены неверно";
            //}
            catch (Exception e)
            {
                //Любая другая ошибка
                ex = e.Message.ToString();
            }
        }
    }
}
