using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        /*string randomLanguage = "";
        string randomGreeting = "";
        Dictionary<string, string> greetings = new Dictionary<string, string>();
            greetings.Add("English", "Hello");
            greetings.Add("French", "Bonjour");
            greetings.Add("German", "Guten Tag");
            greetings.Add("Spanish", "Buenos días");
            greetings.Add("Italian", "Buongiorno");
            greetings.Add("Russian", "Добрий день");
            greetings.Add("Polish", "Dzień dobry");
            greetings.Add("Greek", "Καλημέρα");
            greetings.Add("Turkish", "Günaydın");
            greetings.Add("Portuguese", "Bom dia");
            greetings.Add("Romanian", "Bună ziua");
            greetings.Add("Hungarian", "Jó napot");
            greetings.Add("Czech", "Dobrý den");
            greetings.Add("Swedish", "God dag");
            greetings.Add("Finnish", "Hyvää päivää");
            greetings.Add("Dutch", "Goedemorgen");
            greetings.Add("Danish", "Godemorgen");
            greetings.Add("Norwegian", "God morgen");
            greetings.Add("Icelandic", "Góðan dag");
            greetings.Add("Croatian", "Dobar dan");
            greetings.Add("Lithuanian", "Laba diena");
            greetings.Add("Latvian", "Labdien");
            greetings.Add("Ukrainian", "Добрий ранок");
            greetings.Add("Belarusian", "Добры раніцы");
            greetings.Add("Macedonian", "Добро утро");
            greetings.Add("Albanian", "Përshëndetje");
            greetings.Add("Bulgarian", "Добро утро");

        private void SetRandomGreeting(Dictionary<string, string> countries)
        {
            int randomIndex = new Random().Next(countries.Count);
            randomLanguage = countries.ElementAt(randomIndex).Key;
            randomGreeting = countries.ElementAt(randomIndex).Value;
            label1.Text = $"Click on: {randomGreeting} ({randomGreeting})";
        }*/
        private void Form3_Load(object sender, EventArgs e)
        {
            // Shuffle the dictionary
            /*greetings = greetings.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);
            SetRandomGreeting(greetings);*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*if (textBox1.Text == randomLanguage)
            {
                SetRandomGreeting(greetings);
            }*/
        }
    }
}
