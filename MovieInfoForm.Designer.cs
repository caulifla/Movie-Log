namespace Movie_Log {
   partial class MovieInfoForm {
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
         this.NameM = new System.Windows.Forms.Label();
         this.Actors = new System.Windows.Forms.Label();
         this.Other = new System.Windows.Forms.Label();
         this.GenreLabel = new System.Windows.Forms.Label();
         this.Lead = new System.Windows.Forms.TextBox();
         this.Others = new System.Windows.Forms.TextBox();
         this.MName = new System.Windows.Forms.TextBox();
         this.Add = new System.Windows.Forms.Button();
         this.Reset = new System.Windows.Forms.Button();
         this.Cancel = new System.Windows.Forms.Button();
         this.Genre = new System.Windows.Forms.ComboBox();
         this.DatePicker = new System.Windows.Forms.DateTimePicker();
         this.viewDate = new System.Windows.Forms.Label();
         this.Year = new System.Windows.Forms.Label();
         this.YearPicker = new System.Windows.Forms.DateTimePicker();
         this.R1 = new System.Windows.Forms.RadioButton();
         this.R2 = new System.Windows.Forms.RadioButton();
         this.R4 = new System.Windows.Forms.RadioButton();
         this.R3 = new System.Windows.Forms.RadioButton();
         this.R5 = new System.Windows.Forms.RadioButton();
         this.RatingsBox = new System.Windows.Forms.GroupBox();
         this.LanguageBox = new System.Windows.Forms.ComboBox();
         this.Language = new System.Windows.Forms.Label();
         this.typeBox = new System.Windows.Forms.GroupBox();
         this.movier = new System.Windows.Forms.RadioButton();
         this.seriesr = new System.Windows.Forms.RadioButton();
         this.sesonl = new System.Windows.Forms.Label();
         this.episodel = new System.Windows.Forms.Label();
         this.seasonTB = new System.Windows.Forms.TextBox();
         this.episodeTB = new System.Windows.Forms.TextBox();
         this.RatingsBox.SuspendLayout();
         this.typeBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // NameM
         // 
         this.NameM.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.NameM.Location = new System.Drawing.Point(31, 27);
         this.NameM.Name = "NameM";
         this.NameM.Size = new System.Drawing.Size(61, 23);
         this.NameM.TabIndex = 0;
         this.NameM.Text = "Name";
         this.NameM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Actors
         // 
         this.Actors.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Actors.Location = new System.Drawing.Point(31, 185);
         this.Actors.Name = "Actors";
         this.Actors.Size = new System.Drawing.Size(61, 23);
         this.Actors.TabIndex = 6;
         this.Actors.Text = "Actors";
         this.Actors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Other
         // 
         this.Other.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Other.Location = new System.Drawing.Point(31, 215);
         this.Other.Name = "Other";
         this.Other.Size = new System.Drawing.Size(71, 23);
         this.Other.TabIndex = 7;
         this.Other.Text = "Other info";
         this.Other.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // GenreLabel
         // 
         this.GenreLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.GenreLabel.Location = new System.Drawing.Point(31, 275);
         this.GenreLabel.Name = "GenreLabel";
         this.GenreLabel.Size = new System.Drawing.Size(61, 23);
         this.GenreLabel.TabIndex = 9;
         this.GenreLabel.Text = "Genre";
         // 
         // Lead
         // 
         this.Lead.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Lead.Location = new System.Drawing.Point(125, 185);
         this.Lead.MaxLength = 29;
         this.Lead.Name = "Lead";
         this.Lead.Size = new System.Drawing.Size(200, 23);
         this.Lead.TabIndex = 6;
         this.Lead.TextChanged += new System.EventHandler(this.changeMadeEvent);
         this.Lead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrictColon_KeyPress);
         // 
         // Others
         // 
         this.Others.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Others.Location = new System.Drawing.Point(125, 215);
         this.Others.MaxLength = 15;
         this.Others.Name = "Others";
         this.Others.Size = new System.Drawing.Size(200, 23);
         this.Others.TabIndex = 7;
         this.Others.TextChanged += new System.EventHandler(this.changeMadeEvent);
         this.Others.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrictColon_KeyPress);
         // 
         // MName
         // 
         this.MName.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.MName.Location = new System.Drawing.Point(125, 27);
         this.MName.MaxLength = 21;
         this.MName.Name = "MName";
         this.MName.Size = new System.Drawing.Size(200, 23);
         this.MName.TabIndex = 0;
         this.MName.TextChanged += new System.EventHandler(this.changeMadeEvent);
         this.MName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrictColon_KeyPress);
         // 
         // Add
         // 
         this.Add.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Add.Location = new System.Drawing.Point(35, 360);
         this.Add.Name = "Add";
         this.Add.Size = new System.Drawing.Size(75, 25);
         this.Add.TabIndex = 11;
         this.Add.Text = "Add";
         this.Add.UseVisualStyleBackColor = true;
         this.Add.Click += new System.EventHandler(this.Add_Click);
         // 
         // Reset
         // 
         this.Reset.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Reset.Location = new System.Drawing.Point(135, 360);
         this.Reset.Name = "Reset";
         this.Reset.Size = new System.Drawing.Size(75, 25);
         this.Reset.TabIndex = 12;
         this.Reset.Text = "Reset";
         this.Reset.UseVisualStyleBackColor = true;
         this.Reset.Click += new System.EventHandler(this.Reset_Click);
         // 
         // Cancel
         // 
         this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.Cancel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Cancel.Location = new System.Drawing.Point(235, 360);
         this.Cancel.Name = "Cancel";
         this.Cancel.Size = new System.Drawing.Size(75, 25);
         this.Cancel.TabIndex = 13;
         this.Cancel.Text = "Cancel";
         this.Cancel.UseVisualStyleBackColor = true;
         this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
         // 
         // Genre
         // 
         this.Genre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.Genre.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Genre.FormattingEnabled = true;
         this.Genre.Location = new System.Drawing.Point(125, 275);
         this.Genre.Name = "Genre";
         this.Genre.Size = new System.Drawing.Size(116, 26);
         this.Genre.TabIndex = 9;
         this.Genre.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // DatePicker
         // 
         this.DatePicker.CustomFormat = "";
         this.DatePicker.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.DatePicker.Location = new System.Drawing.Point(125, 245);
         this.DatePicker.Name = "DatePicker";
         this.DatePicker.Size = new System.Drawing.Size(116, 23);
         this.DatePicker.TabIndex = 8;
         this.DatePicker.ValueChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // viewDate
         // 
         this.viewDate.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.viewDate.Location = new System.Drawing.Point(31, 245);
         this.viewDate.Name = "viewDate";
         this.viewDate.Size = new System.Drawing.Size(74, 23);
         this.viewDate.TabIndex = 8;
         this.viewDate.Text = "View date";
         this.viewDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // Year
         // 
         this.Year.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Year.Location = new System.Drawing.Point(31, 155);
         this.Year.Name = "Year";
         this.Year.Size = new System.Drawing.Size(61, 23);
         this.Year.TabIndex = 5;
         this.Year.Text = "Year";
         this.Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // YearPicker
         // 
         this.YearPicker.CustomFormat = "yyyy";
         this.YearPicker.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.YearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
         this.YearPicker.Location = new System.Drawing.Point(125, 155);
         this.YearPicker.MaxDate = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
         this.YearPicker.Name = "YearPicker";
         this.YearPicker.RightToLeftLayout = true;
         this.YearPicker.ShowUpDown = true;
         this.YearPicker.Size = new System.Drawing.Size(119, 23);
         this.YearPicker.TabIndex = 5;
         this.YearPicker.ValueChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // R1
         // 
         this.R1.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.R1.Location = new System.Drawing.Point(146, 19);
         this.R1.Name = "R1";
         this.R1.Size = new System.Drawing.Size(31, 23);
         this.R1.TabIndex = 4;
         this.R1.TabStop = true;
         this.R1.Text = "1";
         this.R1.UseVisualStyleBackColor = true;
         this.R1.CheckedChanged += new System.EventHandler(this.changeMadeEvent);
         this.R1.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // R2
         // 
         this.R2.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.R2.Location = new System.Drawing.Point(111, 19);
         this.R2.Name = "R2";
         this.R2.Size = new System.Drawing.Size(31, 23);
         this.R2.TabIndex = 3;
         this.R2.TabStop = true;
         this.R2.Text = "2";
         this.R2.UseVisualStyleBackColor = true;
         this.R2.CheckedChanged += new System.EventHandler(this.changeMadeEvent);
         this.R2.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // R4
         // 
         this.R4.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.R4.Location = new System.Drawing.Point(41, 19);
         this.R4.Name = "R4";
         this.R4.Size = new System.Drawing.Size(31, 23);
         this.R4.TabIndex = 1;
         this.R4.TabStop = true;
         this.R4.Text = "4";
         this.R4.UseVisualStyleBackColor = true;
         this.R4.CheckedChanged += new System.EventHandler(this.changeMadeEvent);
         this.R4.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // R3
         // 
         this.R3.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.R3.Location = new System.Drawing.Point(76, 19);
         this.R3.Name = "R3";
         this.R3.Size = new System.Drawing.Size(31, 23);
         this.R3.TabIndex = 2;
         this.R3.TabStop = true;
         this.R3.Text = "3";
         this.R3.UseVisualStyleBackColor = true;
         this.R3.CheckedChanged += new System.EventHandler(this.changeMadeEvent);
         this.R3.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // R5
         // 
         this.R5.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.R5.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.R5.Location = new System.Drawing.Point(6, 19);
         this.R5.Name = "R5";
         this.R5.Size = new System.Drawing.Size(31, 23);
         this.R5.TabIndex = 0;
         this.R5.TabStop = true;
         this.R5.Text = "5";
         this.R5.UseVisualStyleBackColor = true;
         this.R5.CheckedChanged += new System.EventHandler(this.changeMadeEvent);
         this.R5.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // RatingsBox
         // 
         this.RatingsBox.Controls.Add(this.R5);
         this.RatingsBox.Controls.Add(this.R1);
         this.RatingsBox.Controls.Add(this.R2);
         this.RatingsBox.Controls.Add(this.R3);
         this.RatingsBox.Controls.Add(this.R4);
         this.RatingsBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RatingsBox.Location = new System.Drawing.Point(31, 305);
         this.RatingsBox.Name = "RatingsBox";
         this.RatingsBox.Size = new System.Drawing.Size(189, 48);
         this.RatingsBox.TabIndex = 10;
         this.RatingsBox.TabStop = false;
         this.RatingsBox.Text = "Rating";
         this.RatingsBox.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // LanguageBox
         // 
         this.LanguageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.LanguageBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LanguageBox.FormattingEnabled = true;
         this.LanguageBox.Location = new System.Drawing.Point(125, 117);
         this.LanguageBox.Name = "LanguageBox";
         this.LanguageBox.Size = new System.Drawing.Size(116, 26);
         this.LanguageBox.TabIndex = 4;
         this.LanguageBox.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // Language
         // 
         this.Language.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Language.Location = new System.Drawing.Point(31, 117);
         this.Language.Name = "Language";
         this.Language.Size = new System.Drawing.Size(71, 23);
         this.Language.TabIndex = 4;
         this.Language.Text = "Language";
         this.Language.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // typeBox
         // 
         this.typeBox.Controls.Add(this.movier);
         this.typeBox.Controls.Add(this.seriesr);
         this.typeBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.typeBox.Location = new System.Drawing.Point(31, 63);
         this.typeBox.Name = "typeBox";
         this.typeBox.Size = new System.Drawing.Size(143, 48);
         this.typeBox.TabIndex = 1;
         this.typeBox.TabStop = false;
         this.typeBox.Text = "Type";
         this.typeBox.TextChanged += new System.EventHandler(this.changeMadeEvent);
         // 
         // movier
         // 
         this.movier.AutoSize = true;
         this.movier.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.movier.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.movier.Location = new System.Drawing.Point(6, 19);
         this.movier.Name = "movier";
         this.movier.Size = new System.Drawing.Size(67, 23);
         this.movier.TabIndex = 0;
         this.movier.TabStop = true;
         this.movier.Text = "Movie";
         this.movier.UseVisualStyleBackColor = true;
         this.movier.CheckedChanged += new System.EventHandler(this.changeMadeEvent);
         this.movier.Click += new System.EventHandler(this.clear_Click);
         // 
         // seriesr
         // 
         this.seriesr.AutoSize = true;
         this.seriesr.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.seriesr.Location = new System.Drawing.Point(75, 19);
         this.seriesr.Name = "seriesr";
         this.seriesr.Size = new System.Drawing.Size(68, 23);
         this.seriesr.TabIndex = 4;
         this.seriesr.TabStop = true;
         this.seriesr.Text = "Series";
         this.seriesr.UseVisualStyleBackColor = true;
         this.seriesr.CheckedChanged += new System.EventHandler(this.changeMadeEvent);
         this.seriesr.Click += new System.EventHandler(this.seriesClicked);
         // 
         // sesonl
         // 
         this.sesonl.AutoSize = true;
         this.sesonl.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.sesonl.Location = new System.Drawing.Point(194, 61);
         this.sesonl.Name = "sesonl";
         this.sesonl.Size = new System.Drawing.Size(46, 18);
         this.sesonl.TabIndex = 2;
         this.sesonl.Text = "Season";
         this.sesonl.Visible = false;
         // 
         // episodel
         // 
         this.episodel.AutoSize = true;
         this.episodel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.episodel.Location = new System.Drawing.Point(260, 61);
         this.episodel.Name = "episodel";
         this.episodel.Size = new System.Drawing.Size(50, 18);
         this.episodel.TabIndex = 3;
         this.episodel.Text = "Episode";
         this.episodel.Visible = false;
         // 
         // seasonTB
         // 
         this.seasonTB.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.seasonTB.Location = new System.Drawing.Point(201, 82);
         this.seasonTB.Name = "seasonTB";
         this.seasonTB.Size = new System.Drawing.Size(29, 23);
         this.seasonTB.TabIndex = 2;
         this.seasonTB.Visible = false;
         this.seasonTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrictColon_KeyPress);
         // 
         // episodeTB
         // 
         this.episodeTB.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.episodeTB.Location = new System.Drawing.Point(271, 82);
         this.episodeTB.Name = "episodeTB";
         this.episodeTB.Size = new System.Drawing.Size(29, 23);
         this.episodeTB.TabIndex = 3;
         this.episodeTB.Visible = false;
         this.episodeTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RestrictColon_KeyPress);
         // 
         // MovieInfoForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Window;
         this.CancelButton = this.Cancel;
         this.ClientSize = new System.Drawing.Size(358, 399);
         this.Controls.Add(this.episodeTB);
         this.Controls.Add(this.seasonTB);
         this.Controls.Add(this.episodel);
         this.Controls.Add(this.sesonl);
         this.Controls.Add(this.typeBox);
         this.Controls.Add(this.Language);
         this.Controls.Add(this.LanguageBox);
         this.Controls.Add(this.RatingsBox);
         this.Controls.Add(this.YearPicker);
         this.Controls.Add(this.Year);
         this.Controls.Add(this.viewDate);
         this.Controls.Add(this.DatePicker);
         this.Controls.Add(this.Genre);
         this.Controls.Add(this.Cancel);
         this.Controls.Add(this.Reset);
         this.Controls.Add(this.Add);
         this.Controls.Add(this.MName);
         this.Controls.Add(this.Others);
         this.Controls.Add(this.Lead);
         this.Controls.Add(this.GenreLabel);
         this.Controls.Add(this.Other);
         this.Controls.Add(this.Actors);
         this.Controls.Add(this.NameM);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.Name = "MovieInfoForm";
         this.Text = "Add Movie/Series";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieInfoForm_FormClosing);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MovieInfoForm_FormClosed);
         this.TextChanged += new System.EventHandler(this.changeMadeEvent);
         this.RatingsBox.ResumeLayout(false);
         this.typeBox.ResumeLayout(false);
         this.typeBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label NameM;
      private System.Windows.Forms.Label Actors;
      private System.Windows.Forms.Label Other;
      private System.Windows.Forms.Label GenreLabel;
      private System.Windows.Forms.TextBox Lead;
      private System.Windows.Forms.TextBox Others;
      private System.Windows.Forms.TextBox MName;
      private System.Windows.Forms.Button Add;
      private System.Windows.Forms.Button Reset;
      private System.Windows.Forms.Button Cancel;
      private System.Windows.Forms.ComboBox Genre;
      private System.Windows.Forms.DateTimePicker DatePicker;
      private System.Windows.Forms.Label viewDate;
      private System.Windows.Forms.Label Year;
      private System.Windows.Forms.DateTimePicker YearPicker;
      private System.Windows.Forms.RadioButton R1;
      private System.Windows.Forms.RadioButton R2;
      private System.Windows.Forms.RadioButton R4;
      private System.Windows.Forms.RadioButton R3;
      private System.Windows.Forms.RadioButton R5;
      private System.Windows.Forms.GroupBox RatingsBox;
      private System.Windows.Forms.ComboBox LanguageBox;
      private System.Windows.Forms.Label Language;
      private System.Windows.Forms.GroupBox typeBox;
      private System.Windows.Forms.RadioButton movier;
      private System.Windows.Forms.RadioButton seriesr;
      private System.Windows.Forms.Label sesonl;
      private System.Windows.Forms.Label episodel;
      private System.Windows.Forms.TextBox seasonTB;
      private System.Windows.Forms.TextBox episodeTB;
   }
}