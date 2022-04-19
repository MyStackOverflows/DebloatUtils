using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Mail;

namespace DebloatUtils
{
    public partial class BugReportForm : Form
    {
        public BugReportForm()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name.Equals("CancelButton")) { this.Close(); }
            else if (button.Name.Equals("SendButton")) { SendBugReport(); }
        }

        private void SendBugReport()
        {
            string report = ReportTextBox.Text;
            string name = NameTextBox.Text;
            if (report.Equals("") || name.Equals("")) { MessageBox.Show("Please fill out both required fields."); return; }
            string address = "noreply.ungersoftwaresolutions@gmail.com";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(address);
                mail.To.Add(new MailAddress(address));
                mail.Subject = "Bug report from DebloatUtils.exe";
                mail.Body = $"{report}{Environment.NewLine}{Environment.NewLine}Bug report sent by {name}";

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;      // Port 465 theoretically works; but it is depreciated
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(address, "cuxbhermbqnqrclo");
                client.Send(mail);
                MessageBox.Show("Bug report sent successfully.");

                client.Dispose();
                mail.Dispose();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Mail sending unsuccessful.");
            }
        }
    }
}
