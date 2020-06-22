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
        private bool enableNotification;
        private bool enableFilterOpacity;
        private int filterOpacityValue;
        private bool enableLog;

        public Dictionary<string, string> Shortcuts { get => shortcuts; }
        public string GamePath { get => gamePath; set => gamePath = value; }
        public bool EnableNotification { get => enableNotification; set => enableNotification = value; }
        public bool EnableFilterOpacity { get => enableFilterOpacity; set => enableFilterOpacity = value; }
        public int FilterOpacityValue { get => filterOpacityValue; set => filterOpacityValue = value; }
        public bool EnableLog { get => enableLog; set => enableLog = value; }


        public ConfigurableOptions()
        {
            shortcuts = new Dictionary<string, string>();
            shortcuts = DefaultShorcuts();
            gamePath = "";
            enableNotification = true;
            filterOpacityValue = 0;
            enableLog = false;
        }

        //Deserialization constructor
        protected ConfigurableOptions(SerializationInfo info, StreamingContext context)
        {
            if (info != null)
            {
                shortcuts = (Dictionary<string, string>)info.GetValue("shortcuts", typeof(Dictionary<string, string>));
                gamePath = info.GetString("gamePath");
                enableNotification = (bool)info.GetValue("enableNotification", typeof(bool));
                enableFilterOpacity = (bool)info.GetValue("enableFilterOpacity", typeof(bool));
                filterOpacityValue = (int)info.GetValue("filterOpacityValue", typeof(int));
                enableLog = (bool)info.GetValue("enableLog", typeof(bool));
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if(info != null)
            {
                info.AddValue("shortcuts", shortcuts);
                info.AddValue("gamePath", gamePath);
                info.AddValue("enableNotification", enableNotification);
                info.AddValue("enableFilterOpacity", enableFilterOpacity);
                info.AddValue("filterOpacityValue", filterOpacityValue);
                info.AddValue("enableLog", enableLog);
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
