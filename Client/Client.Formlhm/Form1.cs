using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client.Formlhm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             
                var bagage2 = MyAirport.Pim.Model.Factory.Model.GetBagage(this.tbAlpha.Text);
                this.tbAlpha.Text = bagage2.LigneAlpha.ToString();
                this.tbAlpha.Enabled = false;
                this.tbClasseBag.Text = bagage2.ClasseBagage.ToString();
                this.tbClasseBag.Enabled = false;
                this.tbCompagnie.Text = bagage2.Compagnie;
                this.tbCompagnie.Enabled = false;
                this.tbItineraire.Text = bagage2.Itineraire;
                this.tbItineraire.Enabled = false;
                this.tbJourExploitation.Text = bagage2.JourExploitation.ToString();
                this.tbJourExploitation.Enabled = false;
                this.tbLigne.Text = bagage2.Ligne.ToString();
                this.tbLigne.Enabled = false;
                this.cbContinuation.Checked = bagage2.Continuation;
                this.cbContinuation.Enabled = false;
                this.cbRush.Checked = bagage2.Rush;
                this.cbRush.Enabled = false;
            }
            catch (ApplicationException appEx)
            {
                this.tbAlpha.Text = this.tbClasseBag.Text = this.tbCompagnie.Text = this.tbItineraire.Text = this.tbJourExploitation.Text = this.tbLigne.Text = "";
                this.cbContinuation.Checked = this.cbRush.Checked = false;
                this.tbAlpha.Enabled = this.tbClasseBag.Enabled = this.tbCompagnie.Enabled = this.tbItineraire.Enabled = this.tbJourExploitation.Enabled =
                this.tbLigne.Enabled = this.cbContinuation.Enabled = this.cbRush.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Une erreur s’est produite dans le traitement de votre demande.\nMerci de bien vouloir re tester ultérieurement ou de contacter votre administrateur.", "Erreur dans le traitement de votre demande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //ajouter les options pour CreateBagage
            }
            catch
            {
                MessageBox.Show("Une erreur s’est produite dans le traitement de votre demande.\nMerci de bien vouloir re tester ultérieurement ou de contacter votre administrateur.", "Erreur dans le traitement de votre demande", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
