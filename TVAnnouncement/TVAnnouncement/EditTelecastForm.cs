using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVAnnouncement
{
    public partial class EditTelecastForm : Form
    {
        private Form1 _form;
        private Date _date;
        private Telecast _telecast;
        private object[] _objects;
        private int _selectedChannel;
        private int _id;

        public EditTelecastForm(Form1 form, int selectedChannel,int id)
        {
            _form = form;
            _selectedChannel = selectedChannel;
            _id = id;
            InitializeComponent();
            _objects = new object[] { dateTimePicker1, categoryBox, nameBox,genreBox,yearsNumeric,directorBox,artistBox,countryBox};
            _date = _form._announcement.GetChannelByIndex(selectedChannel).GetDateByIndex(_id);
            _telecast = _form._announcement.GetChannelByIndex(selectedChannel).GetTelecastByIndex(_id);
        }

        private void EditTelecastForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = _date.TimePicker;
            categoryBox.Text = _telecast.Category;
            nameBox.Text = _telecast.Name;
            genreBox.Text = _telecast.Genre;
            yearsNumeric.Value = _telecast.Years;
            directorBox.Text = _telecast.Director;
            artistBox.Text = _telecast.Artists;
            countryBox.Text = _telecast.Country;
            summaryBox.Text = _telecast.Summary;
            attitudeBox.Text = _telecast.Attitude;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form._announcement.GetChannelByIndex(_selectedChannel).SetTelecastData(_id, nameBox.Text, categoryBox.Text, genreBox.Text, (int)yearsNumeric.Value, directorBox.Text, artistBox.Text, summaryBox.Text, countryBox.Text, attitudeBox.Text);
            _form._announcement.GetChannelByIndex(_selectedChannel).SetDate(_id,dateTimePicker1);

            DialogResult result = MessageBox.Show(
                "Завершить редактирование?",
                "Изменения применены",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );

            if (result == DialogResult.Yes)
            {
                Hide();
            }
        }
    }
}
