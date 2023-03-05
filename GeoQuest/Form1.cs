using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace GeoQuest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string randomCountry = "";
        string randomCode = "";

        private void SetRandomCountry(Dictionary<string, string> countries)
        {
            int randomIndex = new Random().Next(countries.Count);
            randomCountry = countries.ElementAt(randomIndex).Key;
            randomCode = countries.ElementAt(randomIndex).Value;
            label1.Text = $"Click on: {randomCountry} ({randomCode})";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a Timer that will tick every 1000ms (1 second) and set the label2 text to the current time in HH:mm:ss format
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) =>
            {
                label2.Text = DateTime.Now.ToString("HH:mm:ss");
            };
            timer.Start();


            Dictionary<string, string> countries = new Dictionary<string, string>()
            {
                {"Albania", "AL"}, {"Andorra", "AD"}, {"Austria", "AT"}, {"Azerbaijan", "AZ"}, {"Armenia", "AM"}, {"Belarus", "BY"},
                {"Belgium", "BE"}, {"Bosnia and Herzegovina", "BA"}, {"Bulgaria", "BG"}, {"Croatia", "HR"}, {"Cyprus", "CY"},
                {"Czech Republic", "CZ"}, {"Denmark", "DK"}, {"Estonia", "EE"}, {"Finland", "FI"}, {"France", "FR"}, {"Germany", "DE"},
                {"Georgia", "GE"}, {"Greece", "GR"}, {"Hungary", "HU"}, {"Iceland", "IS"}, {"Ireland", "IE"}, {"Italy", "IT"},
                {"Kosovo", "XK"}, {"Latvia", "LV"}, {"Liechtenstein", "LI"}, {"Lithuania", "LT"}, {"Luxembourg", "LU"},
                {"North Macedonia", "MK"}, {"Malta", "MT"}, {"Moldova", "MD"}, {"Monaco", "MC"}, {"Montenegro", "ME"},
                {"The Netherlands", "NL"}, {"Norway", "NO"}, {"Poland", "PL"}, {"Portugal", "PT"}, {"Romania", "RO"},
                {"Russia", "RU"}, {"San Marino", "SM"}, {"Serbia", "RS"}, {"Slovakia", "SK"}, {"Slovenia", "SI"}, {"Spain", "ES"},
                {"Sweden", "SE"}, {"Switzerland", "CH"}, {"Türkiye", "TR"}, {"Ukraine", "UA"}, {"United Kingdom", "UK"},
                {"Vatican City", "VA"}
            };

            // Shuffle the dictionary
            countries = countries.OrderBy(x => Guid.NewGuid()).ToDictionary(item => item.Key, item => item.Value);

            SetRandomCountry(countries);

            // For pictureBox1 to pictureBox50 set the image to the flag of the country
            for (int i = 1; i <= 50; i++)
            {
                PictureBox pb = (PictureBox)this.Controls.Find($"pictureBox{i}", true)[0];
                pb.Image = Image.FromFile($"Assets/Flags/{countries.ElementAt(i - 1).Value}.png");
                // Also set the name of the picturebox to the country code
                pb.Name = countries.ElementAt(i - 1).Value;
            }

            int guessCount = 0;

            // When the user clicks a picturebox, check if the name of the picturebox is the same as the randomCode
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    c.Click += (s, e) =>
                    {
                        if (c.Name == randomCode)
                        {
                            guessCount = 0;
                            SoundPlayer simpleSound = new SoundPlayer(@"Assets/Sounds/pin.wav");
                            simpleSound.Play();
                            countries.Remove(randomCountry);
                            c.Visible = false;

                            // Remove all previously drawn borders
                            Graphics g = this.CreateGraphics();
                            g.Clear(this.BackColor);

                            if (countries.Count == 0)
                            {
                                MessageBox.Show("You won!");
                                return;
                            }
                            SetRandomCountry(countries);
                        }
                        else
                        {
                            guessCount++;
                        }
                        if (guessCount == 3)
                        {
                            guessCount = 0;
                            // Make the correct picturebox have a green border of 25px using the DrawRectangle method
                            Graphics g = this.CreateGraphics();
                            PictureBox correctPb = (PictureBox)this.Controls.Find(randomCode, true)[0];
                            g.DrawRectangle(new Pen(Color.Green, 10), correctPb.Location.X, correctPb.Location.Y, correctPb.Width, correctPb.Height);
                        }
                    };
                }
            }
        }
    }
}