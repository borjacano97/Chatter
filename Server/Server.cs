using System.Net;
using System.Net.Sockets;

namespace Chatter
{
	public class Server
	{
		private class Client
		{
			public TcpClient TcpClient { get; set;}
			public string Name { get; set;}
		}

		private bool _running = false;
		private TcpListener _listener;
		private List<Client> _clients;

		static void Main(string[] args)
		{
			Server server = new Server();
			server.Start();
		}

		private Server() 
		{
			_clients = new List<Client>();
			_listener = new TcpListener(IPAddress.Any, 5000);
			_running = false;
		}

		private void Start()
		{
			_listener.Start();
			Task.Run(ListenForConnections);
		}

		private void Stop()
		{

		}

		private async Task ListenForConnections()
		{
			_running = true;
			while (_running) 
			{
				TcpClient client = await _listener.AcceptTcpClientAsync();
				_=Task.Run(() => HandleClient(client));
			}
		}

		private void HandleClient(TcpClient client)
		{
			
		}
	}
}