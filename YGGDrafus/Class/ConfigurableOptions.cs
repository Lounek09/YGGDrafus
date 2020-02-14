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

        public Dictionary<String, String> Shortcuts { get => shortcuts; }
        public String GamePath { get => gamePath; set => gamePath = value; }

        public ConfigurableOptions()
        {
            shortcuts = new Dictionary<String, String>();
            shortcuts = DefaultShorcuts();
            gamePath = "";
        }

        //Deserialization constructor
        protected ConfigurableOptions(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                shortcuts = (Dictionary<String, String>)info.GetValue("shortcuts", typeof(Dictionary<String, String>));
                gamePath = info.GetString("gamePath");
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if(info != null)
            {
                info.AddValue("shortcuts", shortcuts);
                info.AddValue("gamePath", gamePath);
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
            Dictionary<String, String> defaultShortcuts = new Dictionary<string, string>();

            defaultShortcuts.Add("new", "Ctrl+N");
            defaultShortcuts.Add("next", "F2");
            defaultShortcuts.Add("previous", "F3");

            return defaultShortcuts;
        }
    }
}
