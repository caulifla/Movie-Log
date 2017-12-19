using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Movie_Log {
   class Save {
      public static void SaveData (MovieInfo mInfo) {
         using (StreamWriter writer = new StreamWriter ("LMDB.txt", true)) {
            string toWrite = string.Join (":", mInfo.Name, mInfo.Type, mInfo.Season, mInfo.Episode,
               mInfo.Language, mInfo.Year, mInfo.Lead, mInfo.Others, mInfo.ViewDate, mInfo.Genre, mInfo.Rating);
            writer.WriteLine (toWrite);
         }
      }
   }
}
