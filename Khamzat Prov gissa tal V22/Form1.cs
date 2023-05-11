namespace Khamzat_Prov_gissa_tal_V22
{
    public partial class Form1 : Form
    {
        // Detta �r variabler f�r datorbs tak och f�r antal gissningar du g�r  
        int datornsTal;
        int antalGissningar;

        public Form1()
        {
            InitializeComponent();
            //detta l�gger till talet 10 och 20 till listrutan.
            lbxSt�rstaTalet.Items.Add(10);
            lbxSt�rstaTalet.Items.Add(20);
            //Detta nere ska markera det f�rsta talet i listrutan.
            lbxSt�rstaTalet.SelectedItem = lbxSt�rstaTalet.Items[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStartaSpelet_Click(object sender, EventArgs e)
        {
            //F�rsta koden skapar Datorns tal genom att h�mta det st�rsta talet fr�n.
            //den �vers�tter det till ett heltal och skapa ett.
            //slumptal som ligger i intervallet 1 till det st�rsta talet.
            string st�rstaTal = lbxSt�rstaTalet.SelectedItem.ToString();
            int st�rst = int.Parse(st�rstaTal);
            Random slump = new Random();
            datornsTal = slump.Next(1, st�rst + 1);

            //F�rsta koden ner �t ska aktivera spelet.
            //andra koden ska Grupprutan gbxSpelet.
            btnStartaSpelet.Enabled = false;
            gbxSpeldata.Enabled = false;
            gbxSpelet.Enabled = true;

            // skriv ?? i etiketten lblDatornsTal.
            lblDatornsTal.Text = "??";
            //s�tter instansvariabeln antalGissningar till 0
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
                antalGissningar + " f�rs�k.";
                btnSpelaIgen.Enabled = true;

                lblDatornsTal.Text = datornsTal.ToString();
                tbxMinaResultat.AppendText(antalGissningar + "F�rs�k\n");

            }

            else if (gissatTal < datornsTal)
            {
                lblResultat.Text = "F�r l�gt. F�rs�k igen.";
            }
            else
            {
                lblResultat.Text = "F�r h�gt. F�rs�k igen";
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

        private void lbxSt�rstaTalet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}