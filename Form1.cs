using FluentModbus;
using System.Net;
using System.Security.Cryptography.Xml;

namespace ModbusClientServer {
    public partial class Form1 : Form {


        ModbusTcpServer server;
        ModbusTcpClient client;
        private bool ctd;
        private bool Connected {
            get {
                return ctd;
            }
            set {
                ctd = value;
                if (ctd)
                    StatoLabel.Text = "Connesso";
                else
                    StatoLabel.Text = "Non connesso";
            }
        }

        public Form1() {
            InitializeComponent();
            ctd = false;
            server = new ModbusTcpServer();
            server.Start();
        }

        private void Scrivi(object sender, EventArgs e) {
            var data = (short)GetNumber(textValue);
            try {
                if (Connected)
                    client.WriteSingleRegister(0, GetNumber(textAddress), data);
            } catch {
                Connected = false;
            }

        }

        private int GetNumber(TextBox tb) {
            try {
                return int.Parse(tb.Text);
            } catch {
                return 0;
            }
        }

        private void Connetti(object sender, EventArgs e) {
            try {
                client = new ModbusTcpClient();
                client.Connect(IPAddress.Parse(textIP.Text));
                Connected = true;
            } catch {
                Connected = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            var a = server.GetHoldingRegisters().ToArray();
            var b = Enumerable.Range(0, a.Length < 50 ? a.Length : 50).ToArray();
            output.Lines = Enumerable.Range(0, b.Length).Select(n => "Position " + b[n] + " ->   " + a[n]).ToArray();
        }

    }
}