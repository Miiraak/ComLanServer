using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ComlanServer
{
    public partial class Main : Form
    {
        /// <summary>
        /// the listener to accept clients
        /// </summary>
        private static TcpListener? _listener;
        private static readonly List<TcpClient> _clients = [];
        private static readonly object _clientLock = new();

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Accept clients and handle them
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
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

        /// <summary>
        /// Handle the client
        /// </summary>
        /// <param name="client"></param>
        private static void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[4096];

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
                MessageBox.Show("Error when handle client : " + ex.Message, "ComlanServer - Error");
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

        /// <summary>
        /// Broadcast the message to all clients
        /// </summary>
        /// <param name="message"></param>
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
                        MessageBox.Show("Erreur when broadcast the message : " + ex.Message, "ComlanServer - Error");
                    }
                }
            }
        }

        /// <summary>
        /// The start button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            int port = 8888;
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            label.Text = $"Server listening on: {_listener.LocalEndpoint}";

            Thread acceptThread = new(AcceptClients);
            acceptThread.Start();
        }

        /// <summary>
        /// The stop button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            _listener?.Stop();
            this.Close();
        }
    }
}
