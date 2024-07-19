using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using System.Net.Http;
using System.Net.Sockets;
using System.Net;

namespace ChatBotServer
{
    public partial class Form1 : Form
    {
        ITelegramBotClient botClient;
        CancellationTokenSource cts;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Suppress script errors
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://www.telegram.org/");
        }
        private async void btnStart_Click(object sender, EventArgs e)
        {
            botClient = new TelegramBotClient("7489992163:AAHDHtH9MYCVWXsf0idgCT-fnFYbstaN4pc");
            try
            {
                var me = await botClient.GetMeAsync();
                lblMesg.Text = "I am user" + me.Id + " and my name is " + me.FirstName;
            }
            catch (RequestException ex)
            {
                lblMesg.Text = "Error: " + ex.Message;
                if (ex.InnerException != null)
                {
                    lblMesg.Text += " Inner Exception: " + ex.InnerException.Message;
                }
                Console.WriteLine("Error: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                }
            }
            ReceiverOptions receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = new[] { UpdateType.Message }
            };

            cts = new CancellationTokenSource();
            botClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken: cts.Token
            );
        }

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text != null)
                {
                    lblMesg.Invoke((MethodInvoker)delegate {
                        // Running on the UI thread
                        lblMesg.Text = message.From.FirstName + ":" + message.Text;
                    });
                    await botClient.SendTextMessageAsync(
                        chatId: message.Chat,
                        text: "You said:\n" + message.Text
                    );
                }
            }
        }

        Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Handle errors
            return Task.CompletedTask;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop receiving updates
            cts.Cancel();
            lblMesg.Text = "";
        }
    }
}
