namespace Movie_Log {
   partial class WatchedMovies {
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.WatchedMoviesTable = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.WatchedMoviesTable)).BeginInit();
         this.SuspendLayout();
         // 
         // WatchedMoviesTable
         // 
         this.WatchedMoviesTable.AllowUserToAddRows = false;
         this.WatchedMoviesTable.AllowUserToDeleteRows = false;
         this.WatchedMoviesTable.AllowUserToResizeColumns = false;
         this.WatchedMoviesTable.AllowUserToResizeRows = false;
         this.WatchedMoviesTable.BackgroundColor = System.Drawing.SystemColors.Control;
         this.WatchedMoviesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.WatchedMoviesTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.WatchedMoviesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.WatchedMoviesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle2.NullValue = null;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.WatchedMoviesTable.DefaultCellStyle = dataGridViewCellStyle2;
         this.WatchedMoviesTable.Dock = System.Windows.Forms.DockStyle.Top;
         this.WatchedMoviesTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
         this.WatchedMoviesTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.WatchedMoviesTable.Location = new System.Drawing.Point(0, 0);
         this.WatchedMoviesTable.MultiSelect = false;
         this.WatchedMoviesTable.Name = "WatchedMoviesTable";
         this.WatchedMoviesTable.ReadOnly = true;
         this.WatchedMoviesTable.RowHeadersWidth = 40;
         this.WatchedMoviesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
         this.WatchedMoviesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.WatchedMoviesTable.ShowCellErrors = false;
         this.WatchedMoviesTable.ShowCellToolTips = false;
         this.WatchedMoviesTable.ShowEditingIcon = false;
         this.WatchedMoviesTable.ShowRowErrors = false;
         this.WatchedMoviesTable.Size = new System.Drawing.Size(1251, 635);
         this.WatchedMoviesTable.TabIndex = 0;
         // 
         // WatchedMovies
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoSize = true;
         this.ClientSize = new System.Drawing.Size(1251, 635);
         this.Controls.Add(this.WatchedMoviesTable);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.MaximizeBox = false;
         this.Name = "WatchedMovies";
         this.Text = "Watched movies";
         this.Load += new System.EventHandler(this.ViewWatched_Load);
         ((System.ComponentModel.ISupportInitialize)(this.WatchedMoviesTable)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView WatchedMoviesTable;

   }
}