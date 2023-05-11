namespace Khamzat_Prov_gissa_tal_V22
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblStörstaTalet = new Label();
            lblDator = new Label();
            lblGissa = new Label();
            lblResultat = new Label();
            lblDatornsTal = new Label();
            tbxGissa = new TextBox();
            btnGissa = new Button();
            tbxMinaResultat = new TextBox();
            lblMinaResultat = new Label();
            btnSpelaIgen = new Button();
            btnStartaSpelet = new Button();
            lbxStörstaTalet = new ListBox();
            gbxSpeldata = new GroupBox();
            gbxSpelet = new GroupBox();
            gbxSpeldata.SuspendLayout();
            gbxSpelet.SuspendLayout();
            SuspendLayout();
            // 
            // lblStörstaTalet
            // 
            lblStörstaTalet.AutoSize = true;
            lblStörstaTalet.Location = new Point(6, 22);
            lblStörstaTalet.Name = "lblStörstaTalet";
            lblStörstaTalet.Size = new Size(72, 15);
            lblStörstaTalet.TabIndex = 0;
            lblStörstaTalet.Text = "Största talet:";
            // 
            // lblDator
            // 
            lblDator.AutoSize = true;
            lblDator.Location = new Point(41, 19);
            lblDator.Name = "lblDator";
            lblDator.Size = new Size(67, 15);
            lblDator.TabIndex = 1;
            lblDator.Text = "Datorns tal:";
            // 
            // lblGissa
            // 
            lblGissa.AutoSize = true;
            lblGissa.Location = new Point(41, 55);
            lblGissa.Name = "lblGissa";
            lblGissa.Size = new Size(70, 15);
            lblGissa.TabIndex = 2;
            lblGissa.Text = "Gissa ett tal:";
            // 
            // lblResultat
            // 
            lblResultat.BackColor = SystemColors.ButtonHighlight;
            lblResultat.BorderStyle = BorderStyle.Fixed3D;
            lblResultat.Location = new Point(12, 81);
            lblResultat.Name = "lblResultat";
            lblResultat.Size = new Size(155, 23);
            lblResultat.TabIndex = 3;
            lblResultat.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatornsTal
            // 
            lblDatornsTal.BackColor = SystemColors.ButtonHighlight;
            lblDatornsTal.BorderStyle = BorderStyle.Fixed3D;
            lblDatornsTal.Location = new Point(114, 19);
            lblDatornsTal.Name = "lblDatornsTal";
            lblDatornsTal.Size = new Size(53, 23);
            lblDatornsTal.TabIndex = 4;
            lblDatornsTal.TextAlign = ContentAlignment.MiddleLeft;
            lblDatornsTal.Click += lblDatornsTal_Click;
            // 
            // tbxGissa
            // 
            tbxGissa.Location = new Point(114, 55);
            tbxGissa.Name = "tbxGissa";
            tbxGissa.Size = new Size(53, 23);
            tbxGissa.TabIndex = 5;
            tbxGissa.TextChanged += tbxGissa_TextChanged;
            // 
            // btnGissa
            // 
            btnGissa.Location = new Point(173, 34);
            btnGissa.Name = "btnGissa";
            btnGissa.Size = new Size(75, 23);
            btnGissa.TabIndex = 6;
            btnGissa.Text = "Gissa";
            btnGissa.UseVisualStyleBackColor = true;
            btnGissa.Click += btnGissa_Click;
            // 
            // tbxMinaResultat
            // 
            tbxMinaResultat.Enabled = false;
            tbxMinaResultat.ForeColor = SystemColors.Info;
            tbxMinaResultat.Location = new Point(254, 41);
            tbxMinaResultat.Multiline = true;
            tbxMinaResultat.Name = "tbxMinaResultat";
            tbxMinaResultat.ScrollBars = ScrollBars.Vertical;
            tbxMinaResultat.Size = new Size(90, 60);
            tbxMinaResultat.TabIndex = 7;
            // 
            // lblMinaResultat
            // 
            lblMinaResultat.AutoSize = true;
            lblMinaResultat.Location = new Point(258, 23);
            lblMinaResultat.Name = "lblMinaResultat";
            lblMinaResultat.Size = new Size(76, 15);
            lblMinaResultat.TabIndex = 8;
            lblMinaResultat.Text = "Mina resultat";
            lblMinaResultat.Click += lblMinaResultat_Click;
            // 
            // btnSpelaIgen
            // 
            btnSpelaIgen.BackColor = SystemColors.ActiveCaption;
            btnSpelaIgen.Enabled = false;
            btnSpelaIgen.Location = new Point(250, 84);
            btnSpelaIgen.Name = "btnSpelaIgen";
            btnSpelaIgen.Size = new Size(75, 23);
            btnSpelaIgen.TabIndex = 9;
            btnSpelaIgen.Text = "Spela igen";
            btnSpelaIgen.UseVisualStyleBackColor = false;
            btnSpelaIgen.Click += btnSpelaIgen_Click;
            // 
            // btnStartaSpelet
            // 
            btnStartaSpelet.BackColor = SystemColors.ActiveCaption;
            btnStartaSpelet.Location = new Point(250, 39);
            btnStartaSpelet.Name = "btnStartaSpelet";
            btnStartaSpelet.Size = new Size(75, 23);
            btnStartaSpelet.TabIndex = 10;
            btnStartaSpelet.Text = "Starta spelet";
            btnStartaSpelet.UseVisualStyleBackColor = false;
            btnStartaSpelet.Click += btnStartaSpelet_Click;
            // 
            // lbxStörstaTalet
            // 
            lbxStörstaTalet.FormattingEnabled = true;
            lbxStörstaTalet.ItemHeight = 15;
            lbxStörstaTalet.Location = new Point(99, 22);
            lbxStörstaTalet.Name = "lbxStörstaTalet";
            lbxStörstaTalet.Size = new Size(90, 34);
            lbxStörstaTalet.TabIndex = 11;
            lbxStörstaTalet.SelectedIndexChanged += lbxStörstaTalet_SelectedIndexChanged;
            // 
            // gbxSpeldata
            // 
            gbxSpeldata.BackColor = SystemColors.ActiveCaption;
            gbxSpeldata.Controls.Add(lblStörstaTalet);
            gbxSpeldata.Controls.Add(lbxStörstaTalet);
            gbxSpeldata.Location = new Point(12, 39);
            gbxSpeldata.Name = "gbxSpeldata";
            gbxSpeldata.Size = new Size(221, 85);
            gbxSpeldata.TabIndex = 12;
            gbxSpeldata.TabStop = false;
            gbxSpeldata.Text = "Speldata";
            gbxSpeldata.Enter += gbxSpeldata_Enter;
            // 
            // gbxSpelet
            // 
            gbxSpelet.BackColor = SystemColors.ActiveCaption;
            gbxSpelet.Controls.Add(lblResultat);
            gbxSpelet.Controls.Add(lblDator);
            gbxSpelet.Controls.Add(lblDatornsTal);
            gbxSpelet.Controls.Add(lblGissa);
            gbxSpelet.Controls.Add(lblMinaResultat);
            gbxSpelet.Controls.Add(tbxGissa);
            gbxSpelet.Controls.Add(tbxMinaResultat);
            gbxSpelet.Controls.Add(btnGissa);
            gbxSpelet.Enabled = false;
            gbxSpelet.Location = new Point(12, 143);
            gbxSpelet.Name = "gbxSpelet";
            gbxSpelet.Size = new Size(352, 110);
            gbxSpelet.TabIndex = 13;
            gbxSpelet.TabStop = false;
            gbxSpelet.Text = "Spelet";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(397, 322);
            Controls.Add(gbxSpelet);
            Controls.Add(gbxSpeldata);
            Controls.Add(btnStartaSpelet);
            Controls.Add(btnSpelaIgen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxSpeldata.ResumeLayout(false);
            gbxSpeldata.PerformLayout();
            gbxSpelet.ResumeLayout(false);
            gbxSpelet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStörstaTalet;
        private Label lblDator;
        private Label lblGissa;
        private Label lblResultat;
        private Label lblDatornsTal;
        private TextBox tbxGissa;
        private Button btnGissa;
        private TextBox tbxMinaResultat;
        private Label lblMinaResultat;
        private Button btnSpelaIgen;
        private Button btnStartaSpelet;
        private ListBox lbxStörstaTalet;
        private GroupBox gbxSpeldata;
        private GroupBox gbxSpelet;
    }
}