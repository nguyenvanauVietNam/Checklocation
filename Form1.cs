using System.Net;

namespace WinFormsApp_Check_Location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                WebClient client = new WebClient();
                string response = client.DownloadString("https://ipinfo.io");
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(response);
                string country = data.country;
                label1.Text = "Location: " + country;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fund contry: " + ex.Message);
            }
        }
    }
}
