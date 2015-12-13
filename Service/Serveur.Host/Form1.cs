using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;



namespace Serveur.Host
{
    public partial class Form1 : Form
    {
        private ServiceHost host = null;

        public Form1()
        {
            InitializeComponent();
        }

        void host_State(object sender, EventArgs e)
        {
            this.textBox1.Text = this.host.State.ToString();
            this.listBox1.Items.Add("Changement d'état :" + this.host.State.ToString());
        }

        private void buttonCreate_Click_1(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(MyAirport.Serveur.Service));

            host.Closed += host_State;
            host.Closing += host_State;
            host.Faulted += host_State;
            host.Opened += host_State;
            host.Opening += host_State;

            this.textBox1.Text = host.State.ToString();
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add("Création du service.");
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            host.Open();
            this.textBox1.Text = host.State.ToString();
        }
    }
}
