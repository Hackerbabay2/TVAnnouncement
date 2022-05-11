using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TVAnnouncement
{
    class FileWriter
    {
        private TVAnnouncement _announcement;
        private ListBox _listBox;
        private string _path;
        private string[] _items = new string[] { "id","name","dateTime","weekDay","telecastName","category","genre","years","director","artists","summary","country","attitude"};

        public FileWriter(TVAnnouncement announcement,ListBox listBox)
        {
            _listBox = listBox;
            _path = @"data";
            _announcement = announcement;
            CheckDirectory();
        }

        public void CheckDirectory()
        {
            if (!Directory.Exists(_path))
                Directory.CreateDirectory(_path);
        }

        public void Load()
        {
            foreach (string pathChannel in Directory.GetDirectories(_path))
            {
                string[] channels = Directory.GetDirectories(pathChannel);
                _announcement.AddChanel(pathChannel.Replace("data\\","").Replace(".txt",""));
                _listBox.Items.Add(pathChannel.Replace("data\\", "").Replace(".txt", ""));

                foreach (string path in channels)
                {
                    string[] data = Directory.GetFiles(path);
                    DateTimePicker dateTime = new DateTimePicker();
                    dateTime.Text = File.ReadAllText(data[4]);
                    _announcement.GetChannelByIndex(_announcement.CountChannels - 1).AddDate(dateTime);
                    _announcement.GetChannelByIndex(_announcement.CountChannels - 1).SetTelecastData(
                        Convert.ToInt32(File.ReadAllText(data[7])),
                        File.ReadAllText(data[10]),
                        File.ReadAllText(data[2]),
                        File.ReadAllText(data[6]),
                        Convert.ToInt32(File.ReadAllText(data[12])),
                        File.ReadAllText(data[5]),
                        File.ReadAllText(data[0]),
                        File.ReadAllText(data[9]),
                        File.ReadAllText(data[3]),
                        File.ReadAllText(data[1])
                        );
                }
            }
        }

        public void Write()
        {
            foreach (Channel channel in _announcement.Channels)
            {
                string folderPath = $"{_path}/{channel.Name}";
                Directory.CreateDirectory(folderPath);

                for (int i = 0; i < channel.Dates.Count; i++)
                {
                    Directory.CreateDirectory($"{folderPath}/{i + 1}");

                    string[] path = Directory.GetDirectories(folderPath);

                    for (int z = 0; z < path.Length; z++)
                    {
                            Telecast telecast = channel.GetTelecastByIndex(i + 1);
                            File.WriteAllText($"{path[i]}/{_items[0]}.txt",telecast.Id.ToString());
                            File.WriteAllText($"{path[i]}/{_items[1]}.txt", channel.Name);
                            File.WriteAllText($"{path[i]}/{_items[2]}.txt", channel.GetDateByIndex(z + 1).TimePicker);
                            File.WriteAllText($"{path[i]}/{_items[3]}.txt", channel.GetDateByIndex(z + 1).DayWeek);
                            File.WriteAllText($"{path[i]}/{_items[4]}.txt", telecast.Name);
                            File.WriteAllText($"{path[i]}/{_items[5]}.txt", telecast.Category);
                            File.WriteAllText($"{path[i]}/{_items[6]}.txt", telecast.Genre);
                            File.WriteAllText($"{path[i]}/{_items[7]}.txt", telecast.Years.ToString());
                            File.WriteAllText($"{path[i]}/{_items[8]}.txt", telecast.Director);
                            File.WriteAllText($"{path[i]}/{_items[9]}.txt", telecast.Artists);
                            File.WriteAllText($"{path[i]}/{_items[10]}.txt", telecast.Summary);
                            File.WriteAllText($"{path[i]}/{_items[11]}.txt", telecast.Country);
                            File.WriteAllText($"{path[i]}/{_items[12]}.txt", telecast.Attitude);
                    }
                }
            }
        }

        public void ClearData()
        {
            Directory.Delete(_path, true);
            CheckDirectory();
        }
    }
}
