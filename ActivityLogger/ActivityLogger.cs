using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Xml;

namespace ActivityLogger
{
    public partial class ActivityLogger : Form
    {
        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();

        public ActivityLogger()
        {
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);
        }
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtCollectionBox.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 20, 20);
        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrintNote_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }

        }

        private void btnClearNote_Click(object sender, EventArgs e)
        {
            txtNoteBox.Clear();
        }

        private void btnEmailNote_Click(object sender, EventArgs e)
        {
            try
            {

                //Sending the email.
                //Now we must create a new Smtp client to send our email.

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);   //smtp.gmail.com // For Gmail
                                                                            //smtp.live.com // Windows live / Hotmail
                                                                            //smtp.mail.yahoo.com // Yahoo
                                                                            //smtp.aim.com // AIM
                                                                            //my.inbox.com // Inbox


                //Authentication.
                //This is where the valid email account comes into play. You must have a valid email account(with password) to give our program a place to send the mail from.

                NetworkCredential cred = new NetworkCredential("your gmail email ", "google less secure apps password");

                //To send an email we must first create a new mailMessage(an email) to send.
                MailMessage Msg = new MailMessage();

                // Sender e-mail address.
                Msg.From = new MailAddress("your gmail email address");//Nothing But Above Credentials or your credentials (*******@gmail.com)

                // Recipient e-mail address.
                Msg.To.Add("email you sending to");

                // Assign the subject of our message.
                Msg.Subject = "Msg from ActivityLogger";

                // Create the content(body) of our message.
                Msg.Body = txtCollectionBox.Text;

                // Send our account login details to the client.
                client.Credentials = cred;

                //Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
                client.EnableSsl = true;

                // Send our email.
                client.Send(Msg);

                lblSentConfirmation.Visible = true;
            }
            catch
            {
                // If Mail Doesnt Send Error Mesage Will Be Displayed
                MessageBox.Show("ERROR");;
            }
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (txtNoteBox.Text == "")

            {
                MessageBox.Show("Please Add a Note First before clicking Add button");
                this.lblQuestion.ForeColor = Color.Red; 
            }

            else if (txtCollectionBox.Text.Contains(txtNoteBox.Text)==true)//no duplication solution here

            {
                MessageBox.Show("This note and or activity has been logged already.");
            }

            else

            {
                txtCollectionBox.AppendText(DateTime.Now.ToString() + System.Environment.NewLine);
                txtCollectionBox.AppendText("[*] " + txtNoteBox.Text + "." + System.Environment.NewLine);
                txtNoteBox.Clear();
                
            }
        }

        private void btnCopyNotes_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCollectionBox.Text);

        }
    }
}
