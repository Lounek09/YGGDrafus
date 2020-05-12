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
        private readonly Dictionary<string, string> shortcuts;
        private string gamePath;
        private bool notification;
        private int filterOpacity;

        public Dictionary<string, string> Shortcuts { get => shortcuts; }
        public string GamePath { get => gamePath; set => gamePath = value; }
        public bool Notification { get => notification; set => notification = value; }
        public int FilterOpacity { get => filterOpacity; set => filterOpacity = value; }

        public ConfigurableOptions()
        {
            shortcuts = new Dictionary<string, string>();
            shortcuts = DefaultShorcuts();
            gamePath = "";
            notification = true;
            filterOpacity = 0;
        }

        //Deserialization constructor
        protected ConfigurableOptions(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                shortcuts = (Dictionary<string, string>)info.GetValue("shortcuts", typeof(Dictionary<string, string>));
                gamePath = info.GetString("gamePath");
                notification = (bool)info.GetValue("notification", typeof(bool));
                filterOpacity = (int)info.GetValue("notification", typeof(int));
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if(info != null)
            {
                info.AddValue("shortcuts", shortcuts);
                info.AddValue("gamePath", gamePath);
                info.AddValue("notification", notification);
                info.AddValue("filterOpacity", filterOpacity);
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

        public static Dictionary<string, string> DefaultShorcuts()
        {
            Dictionary<string, string> defaultShortcuts = new Dictionary<string, string>
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
