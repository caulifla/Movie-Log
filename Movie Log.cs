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
   public partial class Main : Form {
      public Main () {
         InitializeComponent ();
      }

      private void addMovie_Click (object sender, EventArgs e) {
         MovieInfoForm newForm = new MovieInfoForm ();
         newForm.Show ();
      }

      private void statButton_Click (object sender, EventArgs e) {
         WatchedMovies statistics = new WatchedMovies ();
         statistics.Show ();
      }
   }
}
