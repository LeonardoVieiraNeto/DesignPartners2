using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesignPartners2.Cap8
{
  public class GeradorDeXML
  {
    public string GerarXML(object o)
    {
      XmlSerializer serialazer = new XmlSerializer(o.GetType());
      StringWriter writer = new StringWriter();
      serialazer.Serialize(writer, o);
      return writer.ToString();
    }
  }
}
