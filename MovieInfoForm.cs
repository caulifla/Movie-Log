using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace Movie_Log {
   public partial class MovieInfoForm : Form {
      public MovieInfoForm () {
         InitializeComponent ();
         DatePicker.MaxDate = DateTime.Now;
         YearPicker.MaxDate = DateTime.Now;
         string[] genres = { "Action", "Adventure", "Animation", "Comedy", "Crime", "Drama", "Epic", "Fantasy", "Horror", "Musical/Dance", "Romance", "Political", "Science Fiction", "Thriller", "War", "Western" };
         string[] languages = { "English", "Tamil", "Malayalam", "Telugu", "Hindi" };
         foreach (string s in genres) {
            Genre.Items.Add (s);
         }
         foreach (string s in languages) {
            LanguageBox.Items.Add (s);
         }
      }

      static bool addButton = false;
      static bool changeMade = false;

      public class SelectRatingException : Exception {
         
      }
      public class SelectTypeException : Exception {
      }

      private void Add_Click (object sender, EventArgs e) {
         addButton = true;
         try {
            MovieInfo newMovie = new MovieInfo ();
            newMovie.Name = MName.Text;
            newMovie.Language = LanguageBox.SelectedItem.ToString ();
            string type = null;
            if (typeBox.Controls.OfType<RadioButton> ().Any (x => x.Checked)) {
               foreach (Control r in typeBox.Controls) {
                  RadioButton selected = r as RadioButton;
                  if (selected.Checked) {
                     type = selected.Text;
                  }
                  if (Object.Equals (type, "Series")) {
                     newMovie.Season = Convert.ToInt32 (seasonTB.Text);
                     newMovie.Episode = Convert.ToInt32 (episodeTB.Text);
                  }
               }
            } else {
               throw new SelectTypeException ();
            }
            newMovie.Type = type;
            newMovie.Lead = Lead.Text;
            newMovie.Others = Others.Text;
            int rating = 0;
            if (RatingsBox.Controls.OfType<RadioButton> ().Any (x => x.Checked)) {
               foreach (Control r in RatingsBox.Controls) {
                  RadioButton selected = r as RadioButton;
                  if (selected.Checked) {
                     rating = Convert.ToInt32 (selected.Text);
                  }
               }
            } else {
               throw new SelectRatingException ();
            }
            newMovie.Rating = rating;
            newMovie.Genre = Genre.SelectedItem.ToString (); ;
            newMovie.ViewDate = DatePicker.Text;
            newMovie.Year = YearPicker.Text;
            Save.SaveData (newMovie);
            MessageBox.Show (newMovie.Name + " added successfully.");
            this.Close ();
         } catch (Exception exception) {
            if (exception is FormatException) {
               var result = MessageBox.Show ("Invalid data.");
            } else if (exception is SelectRatingException) {
               MessageBox.Show ("Please select a rating.");
            } else if (exception is SelectTypeException) {
               MessageBox.Show ("Please select Movie or Series");
            } else if (exception is NullReferenceException)
               MessageBox.Show ("Please fill all the fields");
         }
      }

      private void Cancel_Click (object sender, EventArgs e) {
         this.Close ();
      }

      private void Reset_Click (object sender, EventArgs e) {
         MName.Clear ();
         LanguageBox.SelectedItem = null;
         Lead.Clear ();
         Others.Clear ();
         Genre.SelectedItem = null;
         YearPicker.ResetText ();
         DatePicker.ResetText ();
         R1.Checked = false;
         R2.Checked = false;
         R3.Checked = false;
         R4.Checked = false;
         R5.Checked = false;
         movier.Checked = false;
         seriesr.Checked = false;
         changeMade = false;
      }

      private void MovieInfoForm_FormClosing (object sender, FormClosingEventArgs e) {
         if (changeMade) {
            if (!addButton) {
               var userInput = MessageBox.Show ("Discard data without saving?", "Cancelling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (userInput == System.Windows.Forms.DialogResult.No)
                  e.Cancel = true;
            }
         } else
            e.Cancel = false;
      }

      private void clear_Click (object sender, EventArgs e) {
         seasonTB.Clear ();
         episodeTB.Clear ();
         seasonTB.Visible = episodeTB.Visible = false;
         sesonl.Visible = episodel.Visible = false;
      }

      private void changeMadeEvent (object sender, EventArgs e) {
         changeMade = true;
      }

      private void MovieInfoForm_FormClosed (object sender, FormClosedEventArgs e) {
         changeMade = false;
      }

      private void seriesClicked (object sender, EventArgs e) {
         seasonTB.Visible = episodeTB.Visible = true;
         sesonl.Visible = episodel.Visible = true;
      }

      private void RestrictColon_KeyPress (object sender, KeyPressEventArgs e) {
         if (Object.Equals (':', e.KeyChar))
            e.Handled = true;
      }
   }
}
