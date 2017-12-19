using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Movie_Log {
   public partial class WatchedMovies : Form {
      public WatchedMovies () {
         InitializeComponent ();
      }

      private void ViewWatched_Load (object sender, EventArgs e) {
         try {
            var lines = File.ReadAllLines ("LMDB.txt");
            string[] column = { "Name", "Type", "Season", "Episode", "Language", "Year", "Actors", "Others", "View date", "Genre", "Rating" };
            foreach (string s in column)
               WatchedMoviesTable.Columns.Add (s, s);
            DataGridViewColumn c0 = WatchedMoviesTable.Columns[0];
            DataGridViewColumn c1 = WatchedMoviesTable.Columns[1];
            DataGridViewColumn c2 = WatchedMoviesTable.Columns[2];
            DataGridViewColumn c3 = WatchedMoviesTable.Columns[3];
            DataGridViewColumn c4 = WatchedMoviesTable.Columns[5];
            DataGridViewColumn c5 = WatchedMoviesTable.Columns[6];
            DataGridViewColumn c6 = WatchedMoviesTable.Columns[7];
            DataGridViewColumn c7 = WatchedMoviesTable.Columns[8];
            DataGridViewColumn c8 = WatchedMoviesTable.Columns[10];
            WatchedMoviesTable.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy"; 
            c0.Width = 180;
            c0.Width = 180;
            c0.Width = 180;
            c1.Width = 80;
            c2.Width = c3.Width = 80;
            c4.Width = 60;
            c5.Width = 200;
            c6.Width = 150;
            c7.Width = 100;
            c8.Width = 80;
            foreach (var rowLines in lines) {
               var row = rowLines.Split (':');
               if (Object.Equals (row[1], "Movie")) {
                  row[2] = row[3] = "";
               }
               var date = DateTime.Parse(row[8]);
               var dateV = new DateTime (date.Year, date.Month, date.Day);
               WatchedMoviesTable.Rows.Add (new object[] {row[0], row[1], row[2], row[3],
                  row[4], row[5], row[6], row[7], dateV, row[9], row[10] });
            }
         } catch (Exception ex) {
            MessageBox.Show (ex.Message);
         }
      }

      private void WMovie_FormClosing (object sender, FormClosingEventArgs e) {
      }
   }
}
