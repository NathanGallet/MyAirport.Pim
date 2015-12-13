using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client.Formlhm
{
    public partial class Form1 : Form
    {
        ServiceBagageReference.ServiceClient proxy = null;

        public Form1()
        {
            InitializeComponent();
            proxy = new ServiceBagageReference.ServiceClient();
        }

        //bouton de recherche de bagage
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var bagage2 = proxy.GetBagagebyCodeIata(this.tbAlpha.Text);

                this.tbAlpha.Text = bagage2.LigneAlpha.ToString();
                this.tbClasseBag.Text = bagage2.ClasseBagage.ToString();
                this.tbCompagnie.Text = bagage2.Compagnie;
                this.tbItineraire.Text = bagage2.Itineraire;
                this.tbJourExploitation.Text = bagage2.JourExploitation.ToString();
                this.tbLigne.Text = bagage2.Ligne.ToString();
                this.cbContinuation.Checked = bagage2.Continuation;
                this.cbRush.Checked = bagage2.Rush;

                disableInput();
            }
            catch (ApplicationException appEx)
            {
                this.tbAlpha.Text = this.tbClasseBag.Text = this.tbCompagnie.Text = this.tbItineraire.Text = this.tbJourExploitation.Text = this.tbLigne.Text = "";
                this.cbContinuation.Checked = this.cbRush.Checked = false;
                this.tbAlpha.Enabled = this.tbClasseBag.Enabled = this.tbCompagnie.Enabled = this.tbItineraire.Enabled = this.tbJourExploitation.Enabled =
                this.tbLigne.Enabled = this.cbContinuation.Enabled = this.cbRush.Enabled = true;

            }
            catch (CommunicationException excp)
            {
                this.listBoxLogs.Items.Add("Une erreur de communication c'est produite dans le traitement de votre demande");
                this.listBoxLogs.Items.Add("\tType: " + excp.GetType().ToString());
                this.listBoxLogs.Items.Add("\tMessage: " + excp.Message);
            }
            catch (Exception excp)
            {
                this.listBoxLogs.Items.Add("Une erreur s'est produite dans le traitement de votre demande");
                this.listBoxLogs.Items.Add("\tType: " + excp.GetType().ToString());
                this.listBoxLogs.Items.Add("\tMessage: " + excp.Message);
            }
        }

        //bouton d'ajout de bagage
        private void button2_Click(object sender, EventArgs e)
        {
            ServiceBagageReference.BagageDefinition bag = new ServiceBagageReference.BagageDefinition();

            bag.CodeIata = this.tbAlpha.Text;
            bag.Compagnie = this.tbCompagnie.Text;
            bag.Itineraire = this.tbItineraire.Text;
            bag.Rush = this.cbRush.Checked;
            bag.Continuation = this.cbContinuation.Checked;
            bag.ClasseBagage = Convert.ToChar(this.tbClasseBag.Text);
            bag.Ligne = Convert.ToInt32(this.tbLigne.Text);
            bag.JourExploitation = Convert.ToInt32(this.tbJourExploitation.Text);

            proxy.CreateBagage(bag);
            this.listBoxLogs.Items.Add("Le bagage a bien été enregistré, ID : " + bag.IdBagage);
            
        }

        //decoche tous les boutons
        private void disableInput()
        {
            this.tbAlpha.Enabled = false;
            this.tbClasseBag.Enabled = false;
            this.tbCompagnie.Enabled = false;
            this.tbItineraire.Enabled = false;
            this.tbJourExploitation.Enabled = false;
            this.tbLigne.Enabled = false;
            this.cbContinuation.Enabled = false;
            this.cbRush.Enabled = false;
        }

        //coche tous les boutons
        private void enableInput()
        {
            this.tbAlpha.Enabled = true;
            this.tbClasseBag.Enabled = true;
            this.tbCompagnie.Enabled = true;
            this.tbItineraire.Enabled = true;
            this.tbJourExploitation.Enabled = true;
            this.tbLigne.Enabled = true;
            this.cbContinuation.Enabled = true;
            this.cbRush.Enabled = true;
        }

    }
}
