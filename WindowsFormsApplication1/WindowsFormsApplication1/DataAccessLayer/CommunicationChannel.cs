using System.Text;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public static class CommunicationChannel
    {

        private static string _hostname;
        private static int _port;

        private static TcpClient _client;
        private static NetworkStream _stream;



        static CommunicationChannel()
        {

        }

        public static void StartCommunication() 
        {
             _client = new TcpClient(_hostname, _port);
             _stream = _client.GetStream();


        }
        public static void EndCommunication() {


            if (_stream == null)
                return;
            
            _stream.Close();

            if (_client == null)
                return;

            _client.Close(); }



        public static void SendMessage(string messageToSend)
        {
          
            if (_stream == null)
            {
                System.Windows.Forms.MessageBox.Show($"Debug testujemy na sucho wysyłanie wiadomości o wartości {messageToSend}");

                return;
            }
           

           var message = messageToSend;
          //  var hostname = "192.168.1.101";
            //int port = 8000;
            byte[] sendData = Encoding.ASCII.GetBytes(message);
            //var client = new TcpClient(hostname, port);


            /*
            var client = new TcpClient(_hostname, _port);
            NetworkStream stream = client.GetStream();
            */
                _stream.Write(sendData, 0, sendData.Length);
            /*
            stream.Close();
            client.Close();
            /*

            using (var client = new TcpClient(hostname, port))     
            using (NetworkStream stream = client.GetStream())
            {
                stream.Write(sendData, 0, sendData.Length);
            }


    */
        }


        public static void SetConnectionParameters(string hostname, int port)
        {
            _hostname = hostname;
            _port = port;
        }


    }
}
