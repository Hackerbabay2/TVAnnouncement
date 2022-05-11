
namespace TVAnnouncement
{
    partial class EditTelecastForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.yearsNumeric = new System.Windows.Forms.NumericUpDown();
            this.summaryBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countryBox = new System.Windows.Forms.TextBox();
            this.artistBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.genreBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.attitudeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "Категория";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Items.AddRange(new object[] {
            "Концерт",
            "Викторина",
            "Игры"});
            this.categoryBox.Location = new System.Drawing.Point(12, 40);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(100, 24);
            this.categoryBox.TabIndex = 51;
            // 
            // yearsNumeric
            // 
            this.yearsNumeric.Location = new System.Drawing.Point(13, 126);
            this.yearsNumeric.Maximum = new decimal(new int[] {
            9998,
            0,
            0,
            0});
            this.yearsNumeric.Name = "yearsNumeric";
            this.yearsNumeric.Size = new System.Drawing.Size(99, 22);
            this.yearsNumeric.TabIndex = 50;
            // 
            // summaryBox
            // 
            this.summaryBox.Location = new System.Drawing.Point(12, 301);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(362, 163);
            this.summaryBox.TabIndex = 49;
            this.summaryBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 48;
            this.label7.Text = "Страна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Краткое содержание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Артисты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Режиссер";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Год";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Название телепередачи";
            // 
            // countryBox
            // 
            this.countryBox.Location = new System.Drawing.Point(12, 210);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(100, 22);
            this.countryBox.TabIndex = 41;
            // 
            // artistBox
            // 
            this.artistBox.Location = new System.Drawing.Point(12, 182);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(100, 22);
            this.artistBox.TabIndex = 40;
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(12, 154);
            this.directorBox.Name = "directorBox";
            this.directorBox.Size = new System.Drawing.Size(100, 22);
            this.directorBox.TabIndex = 39;
            // 
            // genreBox
            // 
            this.genreBox.Location = new System.Drawing.Point(12, 98);
            this.genreBox.Name = "genreBox";
            this.genreBox.Size = new System.Drawing.Size(100, 22);
            this.genreBox.TabIndex = 38;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 70);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 22);
            this.nameBox.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(361, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Внести изминения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 55;
            this.label11.Text = "Отношение зрителя";
            // 
            // comboBox1
            // 
            this.attitudeBox.FormattingEnabled = true;
            this.attitudeBox.Items.AddRange(new object[] {
            "любимая",
            "ежедневный просмотр",
            "исключить из просмотра"});
            this.attitudeBox.Location = new System.Drawing.Point(12, 238);
            this.attitudeBox.Name = "comboBox1";
            this.attitudeBox.Size = new System.Drawing.Size(100, 24);
            this.attitudeBox.TabIndex = 54;
            // 
            // EditTelecastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 508);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.attitudeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.yearsNumeric);
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
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "EditTelecastForm";
            this.Text = "EditTelecastForm";
            this.Load += new System.EventHandler(this.EditTelecastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.NumericUpDown yearsNumeric;
        private System.Windows.Forms.RichTextBox summaryBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryBox;
        private System.Windows.Forms.TextBox artistBox;
        private System.Windows.Forms.TextBox directorBox;
        private System.Windows.Forms.TextBox genreBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox attitudeBox;
    }
}