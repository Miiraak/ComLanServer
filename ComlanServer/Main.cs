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
        private static readonly List<TcpClient> _clients = new();
        private static readonly object _clientLock = new();
        private static int numberUser = 0;
        private static int numberMessage = 0;

        public Main()
        {
            InitializeComponent();
            labelServerState.Text = "Stopped";
            labelServerIP.Text = "-.-.-.-";
            labelServerPort.Text = "-";
            labelUserConnected.Text = numberUser.ToString();
            labelMessageSend.Text = numberMessage.ToString();
            buttonStop.Enabled = false;
        }

        /// <summary>
        /// Accept clients and handle them
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        private void AcceptClients()
        {
            try
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

                    numberUser++;
                    labelUserConnected.Text = numberUser.ToString();

                    Thread clientThread = new(() => HandleClient(client));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when accept clients : " + ex.Message);
            }
        }

        /// <summary>
        /// Handle the client
        /// </summary>
        /// <param name="client"></param>
        private void HandleClient(TcpClient client)
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
                numberUser--;
                labelUserConnected.Text = numberUser.ToString();

                client.Close();
            }
        }

        /// <summary>
        /// Broadcast the message to all clients
        /// </summary>
        /// <param name="message"></param>
        private void BroadcastMessage(string message)
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

                numberMessage++;
                labelMessageSend.Text = Convert.ToString(numberMessage);
            }
        }

        /// <summary>
        /// The start button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            labelServerState.Text = "Setting up...";
            buttonStart.Enabled = false;

            int port = 8888;
            labelServerPort.Text = port.ToString();
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();

            string localIP = GetLocalIPAddress();
            labelServerIP.Text = localIP;

            Thread acceptThread = new(AcceptClients);
            acceptThread.Start();
            labelServerState.Text = "Running...";
            buttonStop.Enabled = true;
        }

        /// <summary>
        /// Get the local IP address used for communication within the local network
        /// </summary>
        /// <returns>Local IP address</returns>
        private string GetLocalIPAddress()
        {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect(IPAddress.Broadcast, 65530); // Use a known IP address (Google DNS) to determine the local IP
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint?.Address.ToString() ?? "No IPv4 address found";
            }
        }

        /// <summary>
        /// The stop button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            labelServerState.Text = "Stopped";
            labelServerIP.Text = "-.-.-.-";
            labelServerPort.Text = "-";
            numberUser = 0;
            labelUserConnected.Text = numberUser.ToString();
            numberMessage = 0;
            labelMessageSend.Text = numberMessage.ToString();

            if (_clients.Count != 0)
            {
                lock (_clientLock)
                {
                    foreach (var client in _clients)
                    {
                        client.Close();
                    }
                    _clients.Clear();
                }
            }
            _listener?.Stop();

            buttonStart.Enabled = true;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            Main.ActiveForm.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            _listener?.Stop();
            Application.Exit();
        }
    }
}
