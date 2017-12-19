using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Movie_Log {
   public class SaveXML {
      static string filename = "LMDB.xml";
      public static void SaveData (object o) {
         XmlSerializer xsz = new XmlSerializer (o.GetType ());
         if (!File.Exists ("LMDB.xml")) {
            var writer = new StreamWriter (filename);
            xsz.Serialize (writer, o);
            writer.Close ();
         } else {
            var writer = File.AppendText("LMDB.xml");
            xsz.Serialize (writer, o);
            writer.Close ();
         }
      }
   }
}
