using System.Globalization;
using System.Net.NetworkInformation;

namespace LANSpeed
{
    public partial class MainForm : Form
    {
        private String getTranslatedString(String id)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;

            if (ci.TwoLetterISOLanguageName.ToLower().Equals("pt"))
            {
                switch (id)
                {
                    case "DISCONNECTED":
                        return "Desconectado";
                    case "START":
                        return "Iniciar";
                    case "STOP":
                        return "Parar";
                    default:
                        return "";
                }
            }
            else
            {
                switch (id)
                {
                    case "DISCONNECTED":
                        return "Disconnected";
                    case "START":
                        return "Start";
                    case "STOP":
                        return "Stop";
                    default:
                        return "";
                }
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnStart.Text = getTranslatedString("START");
            btnStop.Text = getTranslatedString("STOP");
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                if (adapter.NetworkInterfaceType.ToString().Equals("Ethernet"))
                {
                    LANComboBoxItem lan = new LANComboBoxItem(adapter.Id, adapter.Description, adapter.Name);
                    cbLanAdapters.Items.Add(lan);
                }
            }

            cbLanAdapters.SelectedIndex = 0;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            String speedReadable = lblSpeed.Text;

            while (btnStop.Enabled && cbLanAdapters.SelectedItem != null)
            {
                NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface adapter in adapters)
                {
                    String lanId = ((LANComboBoxItem)cbLanAdapters.SelectedItem).lanId();

                    if (!adapter.Id.Equals(lanId))
                    {
                        continue;
                    }

                    if (!(adapter.Speed <= 0))
                    {
                        int speedMbs = (int)(adapter.Speed / 1000000);
                        switch (speedMbs)
                        {
                            case 10:
                                speedReadable = "10 MbE";
                                lblSpeed.ForeColor = Color.Black;
                                break;
                            case 100:
                                speedReadable = "100 MbE";
                                lblSpeed.ForeColor = Color.Blue;
                                break;
                            case 1000:
                                speedReadable = "1 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            case 2500:
                                speedReadable = "2.5 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            case 5000:
                                speedReadable = "5 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            case 10000:
                                speedReadable = "10 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            case 100000:
                                speedReadable = "100 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            case 200000:
                                speedReadable = "200 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            case 400000:
                                speedReadable = "400 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            case 800000:
                                speedReadable = "400 GbE";
                                lblSpeed.ForeColor = Color.Green;
                                break;
                            default:
                                speedReadable = speedMbs.ToString() + " MbE";
                                lblSpeed.ForeColor = Color.Black;
                                break;
                        }
                    }
                    else
                    {
                        speedReadable = getTranslatedString("DISCONNECTED");
                        lblSpeed.ForeColor = Color.Red;
                    }
                }

                lblSpeed.Text = speedReadable;
                await Task.Delay(500);
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblSpeed.Text = "";
        }
    }
}
