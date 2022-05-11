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
    public partial class Form1 : Form
    {
        public TVAnnouncement _announcement;

        private FileWriter _fileWriter;
        
        public Form1()
        {
            InitializeComponent();
            _announcement = new TVAnnouncement();
            _fileWriter = new FileWriter(_announcement,channelListBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetDateButtonClick(object sender, EventArgs e)
        {
            if (_announcement.GetChannelByIndex(channelListBox.SelectedIndex) != null)
            {
                _announcement.GetChannelByIndex(channelListBox.SelectedIndex).AddDate(dateTimePicker1);
            }
            else
            {
                MessageBox.Show("Выберете канал");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                foreach (string name in channelListBox.Items)
                {
                    if (name == textBox1.Text)
                    {
                        MessageBox.Show("Такое название уже существует");
                        return;
                    }
                }
                _announcement.AddChanel(textBox1.Text);
                channelListBox.Items.Add(textBox1.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (channelListBox.Items.Count > 0 && channelListBox.SelectedIndex >= 0)
            {
                channelListBox.Items.RemoveAt(channelListBox.SelectedIndex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (channelListBox.SelectedIndex >= 0)
                _announcement.LoadDataListView(ref channelListBox,ref listView1);
            else
                MessageBox.Show("Выберете канал");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_announcement.CountChannels > 0)
            {
                _announcement.GetChannelByIndex(channelListBox.SelectedIndex).SetTelecastData((int)IdNumeric.Value,nameBox.Text,categoryBox.Text, genreBox.Text, (int)yearsNumeric.Value,directorBox.Text,artistBox.Text,summaryBox.Text,countryBox.Text,attitudeBox.Text);
            }
            else
            {
                MessageBox.Show("Нету передач");
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView lsw = (ListView)sender;

            if (e.Column == ListViewItemComparer.SortColumn)
            {
                if (ListViewItemComparer.Order == SortOrder.Ascending)
                {
                    ListViewItemComparer.Order = SortOrder.Descending;
                }
                else
                {
                    ListViewItemComparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                ListViewItemComparer.SortColumn = e.Column;
                ListViewItemComparer.Order = SortOrder.Ascending;
            }
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_announcement.CountChannels > 0 && channelListBox.SelectedIndex >= 0)
            {
                if (_announcement.GetChannelByIndex(channelListBox.SelectedIndex).Dates.Count > 0 && IdNumeric.Value > 0)
                {
                    EditTelecastForm editTelecastForm = new EditTelecastForm(this,channelListBox.SelectedIndex,(int)IdNumeric.Value);
                    editTelecastForm.Show();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _fileWriter.Load();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы действительно хотите очистить все данные?",
                "ВНИМАНИЕ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );

            if (result == DialogResult.Yes)
            {
                _fileWriter.ClearData();
                channelListBox.Items.Clear();
                _announcement = new TVAnnouncement();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            _fileWriter.Write();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _announcement.GetChannelByIndex(channelListBox.SelectedIndex).RemoveTelecastAt((int)IdNumeric.Value);
        }
    }

    public class TVAnnouncement
    {
        private List<Channel> _channels;

        public int CountChannels => _channels.Count;
        public List<Channel> Channels => _channels;

        public TVAnnouncement()
        {
            _channels = new List<Channel>();
        }

        public void AddChanel(string name)
        {
            _channels.Add(new Channel(name,_channels.Count + 1));
        }

        public void LoadDataListView(ref ListBox listBox,ref ListView listView)
        {
            if (_channels.Count > 0)
                _channels[listBox.SelectedIndex].ShowInfoListView(ref listView);
        }

        public Channel GetChannelByIndex(int index)
        {
            if (_channels.Count > 0 && index >= 0)
                return _channels[index];

            return null;
        }
    }

    public class Channel
    {
        private List<Date> _dates;
        private List<Telecast> _telecast;
        private string _name;
        private int _id;

        public List<Date> Dates => _dates;
        public List<Telecast> Telecasts => _telecast;
        public int Id => _id;
        public string Name => _name;

        public Channel(string name, int id)
        {
            _telecast = new List<Telecast>();
            _dates = new List<Date>();
            _name = name;
            _id = id;
        }

        public void RemoveTelecastAt(int index)
        {
            if ((index - 1) < _dates.Count)
            {
                _dates.RemoveAt(index-1);
                _telecast.RemoveAt(index-1);
            }
        }

        public void SetTelecastData(int id, string name, string category, string genre, int years, string director, string artists, string summary, string country, string attitude)
        {
            if (id <= _telecast.Count && id > 0)
            {
                _telecast[id-1].SetData(name, category, genre, years, director, artists, summary, country, attitude);
            }
            else
            {
                MessageBox.Show("Укажите верный ID");
            }
        }

        public void SetDate(int id, DateTimePicker dateTimePicker)
        {
            _dates[id-1].SetDate(dateTimePicker);
        }

        public Date GetDateByIndex(int index)
        {
            return _dates[index-1];
        }

        public Telecast GetTelecastByIndex(int index)
        {
            return _telecast[index-1];
        }

        public void AddDate(DateTimePicker date)
        {
            if (_dates.Count > 0)
            {
                foreach (Date item in _dates)
                {
                    if (item.TimePicker == date.Text)
                    {
                        MessageBox.Show("На это время уже заплонирована передача");
                        return;
                    }
                }
            }
            _dates.Add(new Date(date));
            _telecast.Add(new Telecast());
        }

        public void ShowInfoListView(ref ListView listView)
        {
            ListViewItem listItem = null;
            int id = 0;

            for (int i = 0; i < _dates.Count; i++)
            {
                string[] teleData = _telecast[i].GetData();
                id++;
                _telecast[id-1].setId(id);
                listItem = new ListViewItem(new string[] {
                    id.ToString(),
                    _name,
                    _dates[i].TimePicker,
                    _dates[i].DayWeek,
                    teleData[0],
                    teleData[1],
                    teleData[2],
                    teleData[3],
                    teleData[4],
                    teleData[5],
                    teleData[6],
                    teleData[7],
                    teleData[8]
                });
                listView.Items.Add(listItem);
            }
        }
    }

    public class Date
    {
        private DateTimePicker _timePicker;
        private string _dateTime;
        private string _dayWeek;

        public string TimePicker => _dateTime;
        public string DayWeek => _dayWeek;
        public DateTimePicker DateTime => _timePicker;

        public Date(DateTimePicker timePicker)
        {
            _timePicker = timePicker;
            _dateTime = _timePicker.Value.ToString();
            _dayWeek = timePicker.Value.DayOfWeek.ToString();
        }

        public void SetDate(DateTimePicker dateTimePicker)
        {
            _dateTime = dateTimePicker.Text;
        }
    }

    public class Telecast
    {
        private string _category;
        private string _name;
        private string _genre;
        private string _country;
        private int _years;
        private string _director;
        private string _artists;
        private string _summary;
        private string _attitude;
        private int _id;

        public string Category => _category;
        public string Name => _name;
        public string Genre => _genre;
        public string Country => _country;
        public int Years => _years;
        public string Director => _director;
        public string Artists => _artists;
        public string Summary => _summary;
        public string Attitude => _attitude;
        public int Id => _id;

        public Telecast()
        {
            
        }

        public void SetData(string name,string category, string genre, int years, string director, string artists, string summary, string country, string attitude)
        {
            _category = category;
            _name = name;
            _genre = genre;
            _country = country;
            _years = years;
            _director = director;
            _artists = artists;
            _summary = summary;
            _attitude = attitude;
        }

        public string[] GetData()
        {
            string[] data = new string[9];
            data[0] = _name;
            data[1] = _category;
            data[2] = _genre;
            data[3] = _years.ToString();
            data[4] = _director;
            data[5] = _artists;
            data[6] = _summary;
            data[7] = _country;
            data[8] = _attitude;
            return data;
        }

        public void setId(int id)
        {
            _id = id;
        }
    }
}
