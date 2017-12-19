namespace Movie_Log {
   partial class Main {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose (bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose ();
         }
         base.Dispose (disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent () {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
         this.addMovie = new System.Windows.Forms.Button();
         this.watched = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // addMovie
         // 
         this.addMovie.BackColor = System.Drawing.SystemColors.ButtonFace;
         this.addMovie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addMovie.Location = new System.Drawing.Point(12, 13);
         this.addMovie.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.addMovie.Name = "addMovie";
         this.addMovie.Size = new System.Drawing.Size(120, 120);
         this.addMovie.TabIndex = 0;
         this.addMovie.Text = "Add a Movie/ Series";
         this.addMovie.UseVisualStyleBackColor = false;
         this.addMovie.Click += new System.EventHandler(this.addMovie_Click);
         // 
         // watched
         // 
         this.watched.BackColor = System.Drawing.SystemColors.ButtonFace;
         this.watched.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.watched.Location = new System.Drawing.Point(139, 13);
         this.watched.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.watched.Name = "watched";
         this.watched.Size = new System.Drawing.Size(120, 120);
         this.watched.TabIndex = 8;
         this.watched.Text = "View watched movies";
         this.watched.UseVisualStyleBackColor = false;
         this.watched.Click += new System.EventHandler(this.statButton_Click);
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(271, 143);
         this.Controls.Add(this.watched);
         this.Controls.Add(this.addMovie);
         this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.MaximizeBox = false;
         this.Name = "Main";
         this.Text = "       Movie Log";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button addMovie;
      private System.Windows.Forms.Button watched;
   }
}

