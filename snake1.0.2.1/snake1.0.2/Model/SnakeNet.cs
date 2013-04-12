using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace snake1._0._2.Model
{
    class SnakeNet
    {
        private SnakeNetPacket snakeNetPacket;          
        private Byte[] myBuff;                        

        private Delegate theDelegate;                   
        private delegate void snakeNetDelegate();      
        private snakeNetDelegate theSnakeNetDelegate;     

        private Boolean mustContinue;
        private Boolean iamTheServer;                      

        private System.Net.Sockets.UdpClient socket; 
        private IPEndPoint theEndP;            

        private String serverIP;



        public SnakeNetPacket SnakeNetPacket
        {
            get { return this.snakeNetPacket; }
        }

        public Delegate TheDelegate
        {
            get{return this.theDelegate;}
        }

        public Boolean IamTheServer
        {
            get { return this.iamTheServer; }
        }

        public String ServerIP
        {
            set { this.serverIP = value; }
        }

        public IPEndPoint TheEndP
        {
            get { return theEndP; }
            set { this.theEndP = value; }
        }


        public SnakeNet(ref SnakeNetPacket snakeNetPacket, Boolean iamTheServer, Boolean toSend, Delegate theDelegate)
        {
            this.snakeNetPacket = snakeNetPacket;
            this.iamTheServer = iamTheServer;
            this.serverIP = "";
            this.mustContinue = true;

            this.theDelegate = theDelegate;
            this.theSnakeNetDelegate = new snakeNetDelegate(KillTheConnection);

            this.socket = new System.Net.Sockets.UdpClient(); 
            this.socket.EnableBroadcast = false;            

            if (toSend)                              
            {                                                            
                this.socket.Client.Bind(new System.Net.IPEndPoint(0, 6666)); 
                this.theEndP = new System.Net.IPEndPoint(0, 6666);         
            }                                                        
            else if (!toSend)                                        
            {                                                        
                this.socket.Client.Bind(new System.Net.IPEndPoint(0, 6667));
                this.theEndP = new System.Net.IPEndPoint(0, 6667);          
            }                                                            
        }

        private void KillTheConnection()
        {
            this.mustContinue = false;
            System.Threading.Thread.Sleep(5);

            try
            {
                this.socket.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        public void ReceiveLoop()
        {
            while (this.mustContinue) 
            {
                if (this.iamTheServer)
                {
                    try
                    {
                        this.myBuff = socket.Receive(ref this.theEndP); 
                    }
                    catch (Exception e) { Console.WriteLine(e); }

                    this.snakeNetPacket = this.snakeNetPacket.DeserializeSnakeNetPacket(this.myBuff);
                    Console.WriteLine("Server get: " + this.snakeNetPacket.PacketMessage + " from : " + this.theEndP.Address.ToString().Split(':')[0]);
                }

                if (!this.iamTheServer) 
                {
                    try
                    {
                        this.myBuff = this.socket.Receive(ref this.theEndP);
                    }
                    catch (Exception e) { Console.WriteLine(e); }

                    this.snakeNetPacket = this.snakeNetPacket.DeserializeSnakeNetPacket(this.myBuff); // Deserialize data.
                    Console.WriteLine("Client get: " + this.snakeNetPacket.PacketMessage + " from : " + theEndP.Address.ToString().Split(':')[0]);
                }

                this.theDelegate.DynamicInvoke();

                System.Threading.Thread.Sleep(15); 
            }
        }

        public void SendPacketEngine()
        {
            while (this.mustContinue)
            {
                if (!this.iamTheServer && this.snakeNetPacket.Modified)
                {
                    this.myBuff = this.snakeNetPacket.SerializeSnakeNetPacket();  
                    this.socket.Send(this.myBuff, this.myBuff.Length, serverIP, 6667);
                    this.snakeNetPacket.Modified = false;                      // Set _HasBeenModified to FALSE.
                    Console.WriteLine("Client put on network : " + this.snakeNetPacket.PacketMessage + " to " + this.serverIP);
                }
                
                if (this.iamTheServer && this.snakeNetPacket.Modified)
                {
                    this.myBuff = this.snakeNetPacket.SerializeSnakeNetPacket();                                          
                    this.socket.Send(this.myBuff, this.myBuff.Length, theEndP.Address.ToString().Split(':')[0], 6667);
                    this.snakeNetPacket.Modified = false;                                  
                    Console.WriteLine("Server put on network : " + this.snakeNetPacket.PacketMessage + " to " + theEndP.Address.ToString().Split(':')[0]);
                }

                System.Threading.Thread.Sleep(15); 
            }
        }

    }

}
