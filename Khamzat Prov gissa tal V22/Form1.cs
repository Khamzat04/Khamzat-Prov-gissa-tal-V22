namespace Khamzat_Prov_gissa_tal_V22
{
    public partial class Form1 : Form
    {
        // Detta är variabler för datorbs tak och för antal gissningar du gör  
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
            //detta lägger till talet 10 och 20 till listrutan.
            lbxStörstaTalet.Items.Add(10);
            lbxStörstaTalet.Items.Add(20);
            //Detta nere ska markera det första talet i listrutan.
            lbxStörstaTalet.SelectedItem = lbxStörstaTalet.Items[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            //Första koden skapar Datorns tal genom att hämta det största talet från.
            //den översätter det till ett heltal och skapa ett.
            //slumptal som ligger i intervallet 1 till det största talet.
            string störstaTal = lbxStörstaTalet.SelectedItem.ToString();
            int störst = int.Parse(störstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, störst + 1);

            //Första koden ner åt ska aktivera spelet.
            //andra koden ska Grupprutan gbxSpelet.
            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            // skriv ?? i etiketten lblDatornsTal.
            lblDatornsTal.Text = "??";
            //sätter instansvariabeln antalGissningar till 0
            antalGissningar = 0;

        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
            antalGissningar++;
            string gissa = tbxGissa.Text;
            int gissatTal = int.Parse(gissa);

            if (gissatTal == datornsTal)
            {
                lblResultat.Text = "Korrekt efter" +
                antalGissningar + " försök.";
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + "Försök\n");

            }

            else if (gissatTal < datornsTal)
            {
                lblResultat.Text = "För lågt. Försök igen.";
            }
            else
            {
                lblResultat.Text = "För högt. Försök igen";
            }
        }

        private void gbxSpeldata_Enter(object sender, EventArgs e)
        {

        }

        private void lblDatornsTal_Click(object sender, EventArgs e)
        {

        }

        private void btnSpelaIgen_Click(object sender, EventArgs e)
        {

        }

        private void lblMinaResultat_Click(object sender, EventArgs e)
        {

        }

        private void tbxGissa_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxStörstaTalet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}