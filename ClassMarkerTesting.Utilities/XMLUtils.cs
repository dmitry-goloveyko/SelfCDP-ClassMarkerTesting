using System.Xml;

namespace ClassMarkerTesting.Utilities
{
    public static class XMLUtils
    {
        public static XmlReader MoveToElementWithName(this XmlReader reader, string name)
        {
            while (reader.Name != name && reader.Read())
            {
            }

            return reader;
        }
    }
}
