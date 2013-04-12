using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace snake1._0._2.Model
{
    [Serializable] 
    class SnakeNetPacket
    {

        private Boolean modified;
        private String packetMessage;
        private SnakeModel theSnakeBody;     
        private SnakeFoodModel snakeFood;
        private String playerName;
        private int playerScore;

        public String PacketMessage
        {
            set { this.packetMessage = value; }
            get { return this.packetMessage; }
        }

        public Boolean Modified
        {
            set { this.modified = value; }
            get { return this.modified; }
        }

        public SnakeModel TheSnakeBody
        {
            set { this.theSnakeBody = value; }
            get { return this.theSnakeBody; }
        }

        public SnakeFoodModel SnakeFood
        {
            set { this.snakeFood = value; }
            get { return this.snakeFood; }
        }


        public String PlayerName
        {
            set { this.playerName = value; }
            get { return this.playerName; }
        }

        public int PlayerScore
        {
            set { this.playerScore = value; }
            get { return this.playerScore; }
        }

        public SnakeNetPacket()
        {
            packetMessage = "000";
            theSnakeBody = new SnakeModel();
            snakeFood = new SnakeFoodModel(); 
            playerName = "";        
            playerScore = 0;        

            modified = false;
        }

        public Byte[] SerializeSnakeNetPacket()
        {
            BinaryFormatter binaryFormater = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream();

            binaryFormater.Serialize(memoryStream, this);

            return memoryStream.ToArray();
        }


        public SnakeNetPacket DeserializeSnakeNetPacket(byte[] arrayOfBytes)
        {
            MemoryStream memoryStream = new MemoryStream();       
            BinaryFormatter binaryFormater = new BinaryFormatter(); 
            SnakeNetPacket obj = new SnakeNetPacket();    

            try
            {
                memoryStream.Write(arrayOfBytes, 0, arrayOfBytes.Length);
                memoryStream.Seek(0, SeekOrigin.Begin);
                obj = (SnakeNetPacket)binaryFormater.Deserialize(memoryStream);
            }
            catch (Exception e) { Console.WriteLine(e); }

            return obj;  
        }
    }
}
