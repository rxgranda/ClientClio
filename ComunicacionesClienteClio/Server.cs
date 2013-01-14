using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.IO;

namespace CommunicationsClioLibrary
{
    public class AsynchronousSocketListener
    {
        // Thread signal.
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        private static Caller caller;

        public AsynchronousSocketListener(Caller o)
        {
            caller = o;
        }

        public  void StartListening(int port)
        {
            // 
            // Data buffer for incoming data.
            byte[] bytes = new Byte[1024];

            // Establish the local endpoint for the socket.
            // The DNS name of the computer
            // running the listener is "host.contoso.com".
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            // Byte[] dir = new Byte[] { 127, 0, 0, 1 };
            IPHostEntry host;
            IPAddress localIP = null;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip;
                }
            }
            //IPAddress ipAddress = new IPAddress(dir);
            IPEndPoint localEndPoint = new IPEndPoint(localIP, port);

            // Create a TCP/IP socket.
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);

            // Bind the socket to the local endpoint and listen for incoming connections.
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(100);

                while (true)
                {
                    // Set the event to nonsignaled state.
                    allDone.Reset();

                    // Start an asynchronous socket to listen for connections.
                    Console.WriteLine("Waiting for a connection...");
                    listener.BeginAccept(
                        new AsyncCallback(AcceptCallback),
                        listener);

                    // Wait until a connection is made before continuing.
                    allDone.WaitOne();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();

        }

        public void AcceptCallback(IAsyncResult ar)
        {
            // Signal the main thread to continue.
            allDone.Set();

            // Get the socket that handles the client request.
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.
            StateObject state = new StateObject();
            state.workSocket = handler;
            handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }

        public  void ReadCallback(IAsyncResult ar)
        {
            String content = String.Empty;

            // Retrieve the state object and the handler socket
            // from the asynchronous state object.
            StateObject state = (StateObject)ar.AsyncState;
            Socket handler = state.workSocket;

            // Read data from the client socket. 
            int bytesRead = handler.EndReceive(ar);

            if (bytesRead > 0)
            {
                // There  might be more data, so store the data received so far.
                state.sb.Append(Encoding.ASCII.GetString(
                    state.buffer, 0, bytesRead));

                // Check for end-of-file tag. If it is not there, read 
                // more data.
                content = state.sb.ToString();
                if (content.IndexOf("<EOF>") > -1)
                {
                    // All the data has been read from the 
                    // client. Display it on the console.
                    Console.WriteLine("Read {0} bytes from socket. \n Data : {1}",
                        content.Length, content);
                    // Echo the data back to the client.
                  
                   String flag  = content.Substring(0, 6);                   

                    if (flag.Equals("pcinfo")) {
                        String info = caller.InfoPC();
                        Send(handler, info);
                    }else if (flag.Equals("captpa")){
                        byte[] imagen = caller.Imagen();
                        Send(handler, imagen);
                    }else if (flag.Equals("apagpc")){
                        ThreadStart param = delegate { caller.ApagarPC(); };
                        Thread serverThread = new Thread(param);
                        serverThread.Start();
                        while (!serverThread.IsAlive) ;                              
                        Send(handler, "exito");
                    } else if (flag.Equals("echopc")){                                                      
                        Send(handler, "echo");
                    }else {
                        ThreadStart param = delegate { caller.Mensaje(content.Substring(0,content.Length-7)); };
                        Thread serverThread = new Thread(param);
                        serverThread.Start();
                        while (!serverThread.IsAlive) ;                        
                        Send(handler, "exito");
                    }
                                       
                    
                }
                else
                {
                    // Not all data received. Get more.
                    handler.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                    new AsyncCallback(ReadCallback), state);
                }
            }
        }

        private  void Send(Socket handler, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        private void Send(Socket handler, byte [] data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = data;

            // Begin sending the data to the remote device.
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }


        private  void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = handler.EndSend(ar);
                Console.WriteLine("Sent {0} bytes to client.", bytesSent);

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


      
    }
}