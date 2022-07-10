namespace Notes
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddButton = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.CheckedListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Errors = new System.Windows.Forms.Label();
            this.LabelText = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelNotes = new System.Windows.Forms.Label();
            this.LabelErrors = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.ListBox();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.InputTime = new System.Windows.Forms.DateTimePicker();
            this.Notificate = new System.ComponentModel.BackgroundWorker();
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.Marks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Silver;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddButton.Location = new System.Drawing.Point(806, 186);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(228, 37);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InputText
            // 
            this.InputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputText.Location = new System.Drawing.Point(806, 33);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputText.Size = new System.Drawing.Size(483, 65);
            this.InputText.TabIndex = 2;
            // 
            // Notes
            // 
            this.Notes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notes.FormattingEnabled = true;
            this.Notes.Location = new System.Drawing.Point(12, 33);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(488, 388);
            this.Notes.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteButton.Location = new System.Drawing.Point(1061, 186);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(228, 37);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Errors
            // 
            this.Errors.BackColor = System.Drawing.Color.White;
            this.Errors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Errors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Errors.ForeColor = System.Drawing.Color.Red;
            this.Errors.Location = new System.Drawing.Point(806, 322);
            this.Errors.Name = "Errors";
            this.Errors.Size = new System.Drawing.Size(483, 41);
            this.Errors.TabIndex = 5;
            this.Errors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelText
            // 
            this.LabelText.AutoSize = true;
            this.LabelText.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.LabelText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelText.Location = new System.Drawing.Point(1020, 4);
            this.LabelText.Name = "LabelText";
            this.LabelText.Size = new System.Drawing.Size(58, 26);
            this.LabelText.TabIndex = 6;
            this.LabelText.Text = "TEXT";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.LabelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelTime.Location = new System.Drawing.Point(1023, 114);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(55, 26);
            this.LabelTime.TabIndex = 7;
            this.LabelTime.Text = "TIME";
            // 
            // LabelNotes
            // 
            this.LabelNotes.AutoSize = true;
            this.LabelNotes.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.LabelNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelNotes.Location = new System.Drawing.Point(320, 4);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(74, 26);
            this.LabelNotes.TabIndex = 9;
            this.LabelNotes.Text = "NOTES";
            // 
            // LabelErrors
            // 
            this.LabelErrors.AutoSize = true;
            this.LabelErrors.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold);
            this.LabelErrors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelErrors.Location = new System.Drawing.Point(1005, 285);
            this.LabelErrors.Name = "LabelErrors";
            this.LabelErrors.Size = new System.Drawing.Size(89, 26);
            this.LabelErrors.TabIndex = 10;
            this.LabelErrors.Text = "ERRORS";
            // 
            // Times
            // 
            this.Times.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Times.FormattingEnabled = true;
            this.Times.ItemHeight = 24;
            this.Times.Location = new System.Drawing.Point(506, 33);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(147, 388);
            this.Times.TabIndex = 11;
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelAuthor.ForeColor = System.Drawing.Color.DimGray;
            this.LabelAuthor.Location = new System.Drawing.Point(1185, 397);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(104, 20);
            this.LabelAuthor.TabIndex = 12;
            this.LabelAuthor.Text = "Made by Infibiss";
            // 
            // InputTime
            // 
            this.InputTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.InputTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.InputTime.Location = new System.Drawing.Point(990, 143);
            this.InputTime.Name = "InputTime";
            this.InputTime.Size = new System.Drawing.Size(135, 22);
            this.InputTime.TabIndex = 13;
            // 
            // Notificate
            // 
            this.Notificate.WorkerSupportsCancellation = true;
            this.Notificate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Notificate_DoWork);
            // 
            // Tray
            // 
            this.Tray.Icon = ((System.Drawing.Icon)(resources.GetObject("Tray.Icon")));
            this.Tray.Text = "Notifications";
            this.Tray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Tray_MouseDoubleClick);
            // 
            // Marks
            // 
            this.Marks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Marks.ForeColor = System.Drawing.Color.Lime;
            this.Marks.FormattingEnabled = true;
            this.Marks.ItemHeight = 24;
            this.Marks.Location = new System.Drawing.Point(659, 33);
            this.Marks.Name = "Marks";
            this.Marks.Size = new System.Drawing.Size(32, 388);
            this.Marks.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1301, 442);
            this.Controls.Add(this.Marks);
            this.Controls.Add(this.InputTime);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.LabelErrors);
            this.Controls.Add(this.LabelNotes);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelText);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.AddButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.CheckedListBox Notes;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Errors;
        private System.Windows.Forms.Label LabelText;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelNotes;
        private System.Windows.Forms.Label LabelErrors;
        private System.Windows.Forms.ListBox Times;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.DateTimePicker InputTime;
        private System.ComponentModel.BackgroundWorker Notificate;
        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.ListBox Marks;
    }
}

