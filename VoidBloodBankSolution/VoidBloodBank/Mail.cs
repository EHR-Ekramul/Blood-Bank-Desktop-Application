using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace VoidBloodBank
{
    internal static class Mail
    {
        public static void SendOTP(string receiverMail, out string otp, out string error)
        {
            int randomNumber = new Random().Next(100000, 999999);
            try
            {
                string senderMail = "voidtech313@gmail.com";
                string senderPassword = "";//App password

                MailMessage message = new MailMessage
                {
                    From = new MailAddress(senderMail),
                    Subject = "VOID Blood Bank OTP"
                };
                message.To.Add(new MailAddress(receiverMail));
                message.Body = @"<html><body><p><strong>VOID-" + randomNumber + " is your VOID Blood Bank Verification Code.</strong></p><p><em>If this is not you, please contact <a href=" + "\"mailto: voidtect313 @gmail.com\">voidtect313@gmail.com</a>.</em></p></body></html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(senderMail,senderPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);
                error = "";
                otp = randomNumber.ToString();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                otp = "";
            }
        }
    }
}
