using System.IO;
using System.Xml;

namespace YGGDrafus
{
    static class Xml
    {
        public static XmlDocument ReadXmlFromString(string request)
        {
            XmlDocument document = new XmlDocument() { XmlResolver = null };
            StringReader stringReader = new StringReader(request);
            XmlReader xmlReader = null;
            try
            {
                xmlReader = XmlReader.Create(stringReader, new XmlReaderSettings() { XmlResolver = null });
                document.Load(xmlReader);
            }
            finally
            {
                if (xmlReader != null)
                    xmlReader.Close();
                else
                    document = null;
            }
            return document;
        }

        public static XmlDocument ReadXmlFromFile(string path)
        {
            XmlDocument document = new XmlDocument() { XmlResolver = null };

            if (File.Exists(path))
                document.Load(path);
            else
                document = null;

            return document;
        }
    }
}
