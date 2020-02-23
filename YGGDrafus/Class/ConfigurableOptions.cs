using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Input;

namespace YGGDrafus
{
    [Serializable()]
    public class ConfigurableOptions : ISerializable
    {
        private readonly Dictionary<String, String> shortcuts;
        private String gamePath;
        private bool notification;

        public Dictionary<String, String> Shortcuts { get => shortcuts; }
        public String GamePath { get => gamePath; set => gamePath = value; }
        public bool Notification { get => notification; set => notification = value; }

        public ConfigurableOptions()
        {
            shortcuts = new Dictionary<String, String>();
            shortcuts = DefaultShorcuts();
            gamePath = "";
            notification = true;
        }

        //Deserialization constructor
        protected ConfigurableOptions(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                shortcuts = (Dictionary<String, String>)info.GetValue("shortcuts", typeof(Dictionary<String, String>));
                gamePath = info.GetString("gamePath");
                notification = (bool)info.GetValue("notification", typeof(bool));
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if(info != null)
            {
                info.AddValue("shortcuts", shortcuts);
                info.AddValue("gamePath", gamePath);
                info.AddValue("notification", notification);
            }
        }

        public void Save()
        {
            Stream stream = null;
            try
            {
                stream = File.Open("options.ygg", FileMode.OpenOrCreate);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, this);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public static Dictionary<String, String> DefaultShorcuts()
        {
            Dictionary<String, String> defaultShortcuts = new Dictionary<string, string>
            {
                { "new", "Ctrl+N" },
                { "next", "F2" },
                { "previous", "F3" },
                { "screenshot", "F5" }
            };

            return defaultShortcuts;
        }
    }
}
