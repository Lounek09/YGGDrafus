using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace YGGDrafus
{
    [Serializable()]
    public class GameFormSerializable : ISerializable
    {
        private int splitterDistance;

        public GameFormSerializable()
        {
            splitterDistance = 744;
        }

        //Deserialization constructor
        protected GameFormSerializable(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                splitterDistance = (int)info.GetValue("SplitterDistance", typeof(int));
            }
        }

        public int SplitterDistance { get => splitterDistance; set => splitterDistance = value; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if(info != null)
            {
                info.AddValue("SplitterDistance", splitterDistance);
            }

        }

        public void Save()
        {
            Stream stream = File.Open("gameForm.ygg", FileMode.OpenOrCreate);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, this);
            stream.Close();
        }
    }
}
