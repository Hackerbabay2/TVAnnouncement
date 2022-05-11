
namespace TVAnnouncement
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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelecastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeekName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telecast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telecastCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.years = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artists = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attutude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.channelListBox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.summaryBox = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.yearsNumeric = new System.Windows.Forms.NumericUpDown();
            this.IdNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.attitudeBox = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Установить дату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SetDateButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название канала";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.TelecastName,
            this.DateTime,
            this.WeekName,
            this.telecast,
            this.telecastCategory,
            this.genre,
            this.years,
            this.director,
            this.Artists,
            this.summary,
            this.country,
            this.attutude});
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(260, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(627, 512);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 28;
            // 
            // TelecastName
            // 
            this.TelecastName.Text = "Name";
            this.TelecastName.Width = 93;
            // 
            // DateTime
            // 
            this.DateTime.Text = "Date Time";
            this.DateTime.Width = 115;
            // 
            // WeekName
            // 
            this.WeekName.Text = "Day Week";
            this.WeekName.Width = 127;
            // 
            // telecast
            // 
            this.telecast.Text = "Telecast";
            this.telecast.Width = 74;
            // 
            // telecastCategory
            // 
            this.telecastCategory.Text = "Category";
            this.telecastCategory.Width = 92;
            // 
            // genre
            // 
            this.genre.Text = "Genre";
            // 
            // years
            // 
            this.years.Text = "Years";
            // 
            // director
            // 
            this.director.Text = "Director";
            // 
            // Artists
            // 
            this.Artists.Text = "Artits";
            // 
            // summary
            // 
            this.summary.Text = "Summary";
            // 
            // country
            // 
            this.country.Text = "Country";
            // 
            // attutude
            // 
            this.attutude.Text = "Attitude";
            // 
            // channelListBox
            // 
            this.channelListBox.FormattingEnabled = true;
            this.channelListBox.ItemHeight = 16;
            this.channelListBox.Location = new System.Drawing.Point(12, 165);
            this.channelListBox.Name = "channelListBox";
            this.channelListBox.Size = new System.Drawing.Size(242, 324);
            this.channelListBox.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(134, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(23, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 495);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(153, 28);
            this.button4.TabIndex = 9;
            this.button4.Text = "Показать";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(895, 117);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 10;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(895, 145);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(100, 22);
            this.genreBox.TabIndex = 11;
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(895, 201);
            this.directorBox.Name = "directorBox";
            this.directorBox.Size = new System.Drawing.Size(100, 22);
            this.directorBox.TabIndex = 13;
            // 
            // artistBox
            // 
            this.artistBox.Location = new System.Drawing.Point(895, 229);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(100, 22);
            this.artistBox.TabIndex = 14;
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(895, 257);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(100, 22);
            this.countryBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1001, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Название телепередачи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1001, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1001, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1001, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Режиссер";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1001, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Страна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(893, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Краткое содержание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1001, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Артисты";
            // 
            // summaryBox
            // 
            this.summaryBox.Location = new System.Drawing.Point(896, 342);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(362, 163);
            this.summaryBox.TabIndex = 29;
            this.summaryBox.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(896, 502);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(362, 23);
            this.button5.TabIndex = 30;
            this.button5.Text = "Внести данные";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // yearsNumeric
            // 
            this.yearsNumeric.Location = new System.Drawing.Point(896, 173);
            this.yearsNumeric.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.yearsNumeric.Name = "yearsNumeric";
            this.yearsNumeric.Size = new System.Drawing.Size(99, 22);
            this.yearsNumeric.TabIndex = 31;
            // 
            // IdNumeric
            // 
            this.IdNumeric.Location = new System.Drawing.Point(896, 59);
            this.IdNumeric.Name = "IdNumeric";
            this.IdNumeric.Size = new System.Drawing.Size(99, 22);
            this.IdNumeric.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1001, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "ID";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1029, 61);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 23);
            this.button6.TabIndex = 34;
            this.button6.Text = "Редактировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Концерт",
            "Викторина",
            "Игры"});
            this.categoryBox.Location = new System.Drawing.Point(895, 87);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(100, 24);
            this.categoryBox.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1004, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 36;
            this.label10.Text = "Категория";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1075, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 38;
            this.label11.Text = "Отношение зрителя";
            // 
            // attitudeBox
            // 
            this.attitudeBox.FormattingEnabled = true;
            this.attitudeBox.Items.AddRange(new object[] {
            "любимая",
            "ежедневный просмотр",
            "исключить из просмотра"});
            this.attitudeBox.Location = new System.Drawing.Point(895, 285);
            this.attitudeBox.Name = "attitudeBox";
            this.attitudeBox.Size = new System.Drawing.Size(178, 24);
            this.attitudeBox.TabIndex = 37;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(163, 131);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 28);
            this.button7.TabIndex = 39;
            this.button7.Text = "Загрузить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(163, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 28);
            this.button8.TabIndex = 40;
            this.button8.Text = "Очистить";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(163, 106);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 28);
            this.button9.TabIndex = 41;
            this.button9.Text = "Сохранить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1163, 61);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(95, 23);
            this.button10.TabIndex = 42;
            this.button10.Text = "Удалить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 537);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.attitudeBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IdNumeric);
            this.Controls.Add(this.yearsNumeric);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.summaryBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.artistBox);
            this.Controls.Add(this.directorBox);
            this.Controls.Add(this.genreBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.channelListBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "TVAnnouncement";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader DateTime;
        private System.Windows.Forms.ColumnHeader WeekName;
        private System.Windows.Forms.ColumnHeader telecastCategory;
        private System.Windows.Forms.ListBox channelListBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader TelecastName;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader telecast;
        private System.Windows.Forms.ColumnHeader genre;
        private System.Windows.Forms.ColumnHeader years;
        private System.Windows.Forms.ColumnHeader director;
        private System.Windows.Forms.ColumnHeader Artists;
        private System.Windows.Forms.ColumnHeader summary;
        private System.Windows.Forms.ColumnHeader country;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox directorBox;
        private System.Windows.Forms.TextBox artistBox;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox summaryBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown yearsNumeric;
        private System.Windows.Forms.NumericUpDown IdNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox attitudeBox;
        private System.Windows.Forms.ColumnHeader attutude;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

