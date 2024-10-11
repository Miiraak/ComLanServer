using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ComlanServer
{
    public partial class Main : Form
    {
        private static TcpListener? _listener;
        private static readonly List<TcpClient> _clients = [];
        private static readonly object _clientLock = new();

        public Main()
        {
            InitializeComponent();
        }

        private static void AcceptClients()
        {
            if (_listener == null)
            {
                throw new InvalidOperationException("Listener is not initialized.");
            }

            while (true)
            {
                TcpClient client = _listener.AcceptTcpClient();
                lock (_clientLock)
                {
                    _clients.Add(client);
                }

                Thread clientThread = new(() => HandleClient(client));
                clientThread.Start();
            }
        }

        private static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            int bytesRead;
            try
            {
                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    BroadcastMessage(message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la réception du message : " + ex.Message);
            }
            finally
            {
                lock (_clientLock)
                {
                    _clients.Remove(client);
                }
                client.Close();
            }
        }

        private static void BroadcastMessage(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            lock (_clientLock)
            {
                foreach (var client in _clients)
                {
                    try
                    {
                        NetworkStream stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de l'envoi du message : " + ex.Message);
                    }
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int port = 8888;
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            label.Text = $"Server listening on: {_listener.LocalEndpoint}";

            Thread acceptThread = new(AcceptClients);
            acceptThread.Start();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            _listener?.Stop();
            this.Close();
        }
    }
}
