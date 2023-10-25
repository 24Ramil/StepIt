using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Login_Registration.Wpf
{
    using System.Net;
    using System.Net.Mail;
    internal class Smtp_Client
    {
        public static void SendPassword(string userEmail, string userLogin) 
        {
            string userPassword = JsonUser.JsonDesirialization(userLogin);


            MailAddress fromAddress = new MailAddress("ramilteymurov264@gmail.com", "Spam");
            MailAddress toAddress = new MailAddress(userEmail, userLogin);
            MailMessage message = new MailMessage(fromAddress, toAddress);
            message.Subject = "Восстановление Пароля";
            message.Body = "Ваш пароль: " + userPassword;
            message.IsBodyHtml = true;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAddress.Address, "yyxj zcjc lzcs jnov");

            smtpClient.Send(message);

        }

    }
}
