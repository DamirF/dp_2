using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dp_2
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            List<Objective> Tasks = new List<Objective>();
            string _Date = Date_text_box.Text;
            string _Time = Time_text_box.Text;
            string _Name = Name_text_box.Text;
            string _Description = Descr_text_box.Text;

            if (_Name == "" || _Date == "")
            {
                if (_Name == "")
                {
                    name_err.Text = "Поле обязательно для заполнения! ";
                }
                else name_err.Text = null;
                if (_Date == "")
                {
                    date_err.Text = "Поле обязательно для заполнения! ";
                }
                else date_err.Text = null;
            }
           else
            {
                name_err.Text = null;
                Objective obj = new Objective { Date = _Date, Time = _Time, Name = _Name, Description = _Description, status = false };
                using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
                {
                    Tasks = await JsonSerializer.DeserializeAsync<List<Objective>>(fs);
                }
                Tasks.Add(obj);
                using (FileStream fs = new FileStream("tasks.json", FileMode.OpenOrCreate))
                {
                    await JsonSerializer.SerializeAsync<List<Objective>>(fs, Tasks, options);
                }
                Date_text_box.Text = null;
                Time_text_box.Text = null;
                Name_text_box.Text = null;
                Descr_text_box.Text = null;
            }
        }

        private async void theme_but_Click(object sender, EventArgs e)
        {
            List<int> panel_bg;
            using (FileStream fs = new FileStream("bg_set.json", FileMode.OpenOrCreate))
            {
                panel_bg = await JsonSerializer.DeserializeAsync<List<int>>(fs);
            }

        }
    }
}
