using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // her importeres System.IO, så vi kan benytte os af paths

// ekstern bibliotek (se link under bilag i journalen) - her importeres iTextSharp.
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


namespace advLixBeregner
{
    public partial class MainForm : Form
    {
        #region globalevariabler
        // Tekst
        string LixText;

        // Analyse-variabler
        int O; // antallet af ord 
        int P; // P er antallet af punktummer
        int L; // L er antallet af lange ord

        int hvorLangtErVi; // bruges til at holde styr på hvor langt vi er i analysen.

        //bool pdf = false; // ses om det er en pdf der læses fra.

        // til side orientering
        int maxChars = 0;  // bruges til at holde styr på alle chars i teksten

        int currentChars = 0;
        int pages = 0;
        int nextPageChars;
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // reset variabler, så den er klar til ny beregning af LIX.
            O = 0;
            P = 0;
            L = 0;

            currentChars = 0;
            maxChars = 0;
            pages = 0;

            // Sætter den tekst der skal beregnes lig med variablen LixText
            LixText = rtbText.Text.ToString();

            // maxChars udregnes - alle karakterene findes i LixText bruges i 
            udregnMaxChars();
                       
            // metoden bruges med maxChars - fundet fra metoden udregnMaxChars();
            analyserTekst(maxChars);

            // OUTPUT til labels - metoderne compareLix og calculateLix bruges
            lblLevel.Text = "Sværhedsgrad: " + sammenlignLix(udregnLix(O, P, L));
            lblLix.Text = "LIX-tal: " + udregnLix(O, P, L).ToString();
         
        }

        public void udregnMaxChars()
        {
            // max karakterer tælles i tekst
            #region pageCalculation
            // Her læses hver karakter i LixText
            foreach (char c in LixText)
            {
                // Når currentChars kommer ov 2400 anslag m. mellem så skrive den +1 til pages
                if (currentChars >= 2400)
                {
                    pages = pages + 1;

                    // currentChars sættes til 0 og der tælles for en ny side
                    currentChars = 0;
                }
                else
                {
                    // Her skrives +1 til begge variabler: currentChars og maxChars.
                    currentChars++;
                    maxChars++;
                }

            }
            // Her udregnes antal til næste side ved at tage 2400 - currentChars
            nextPageChars = 2400 - currentChars;

            // Her outputtes resultaterne til label lblPages som er placeret på main-tabben
            lblPages.Text = "Sider: " + pages + " - Tegn: " + maxChars + " - Næste side (tegn): " + nextPageChars;
            #endregion
        }

        public int udregnLix(int O, int P, int L)
            {
            // sætter lix tilbage til 0, så vi er sikre på den ikke tager den gamle ved et uheld
            int lix = 0;

            // sætter metodens argumenter lig med nye variabler
            int x = O;
            int y = P;
            int z = L;

            if(y == 0) // dette burde ikke være muligt, og den sætter derfor LIX lig med 0.
            {
                lix = 0;
            }
            else
            {
                lix = (x / y) + (z * 100) / x; // Her er formlen som bruges til at beregne LIX-tallet
            }

            // returnerer LIX-tallet
            return lix;
            }

        public string sammenlignLix(int lix)
        {
            int comparedLix; // bruges til at opbevare det beregnede LIX-tal
            string LixLevel; // denne variabel bruges til at beskrive sværhedsgarden
            
            // sætter ny variabel comparedLix lig med det beregnede LIX-tal
            comparedLix = lix;

            // sammenligner LIX-tallet - her kan ikke bruges et switch statement - læs design af kode (OVERVEJELSE)

            // intervallet fra 
            if (comparedLix >= 45)
            {
                if (comparedLix >= 55) LixLevel = "Meget svær - 9. kl. og op"; // sætter sværhedsgrad fra intervallet [55; uendelig[
                if (comparedLix >= 45 && comparedLix <= 54) LixLevel = "Svær  - 8. kl."; // sætter sværhedsgrad fra intervallet [45; 54]
                else LixLevel = "Svær";
            }
            else if (comparedLix >= 35)
            {
                if (comparedLix >= 35 && comparedLix <= 44) LixLevel = "Let - 7. kl.";
                else LixLevel = "Middel";
            }
            else if (comparedLix > 25)
            {
                if (comparedLix >= 30 && comparedLix <= 35) LixLevel = "Let - 6. kl.";
                else if (comparedLix >= 25 && comparedLix <= 30) LixLevel = "Let - 5. kl.";
                else LixLevel = "Let";
            }
            else if (comparedLix <= 25)
            {
                if (comparedLix >= 20 && comparedLix <= 25) LixLevel = "Let: børn - 4. kl.";
                if (comparedLix >= 15 && comparedLix <= 20) LixLevel = "Let: børn - 3. kl.";
                if (comparedLix >= 10 && comparedLix <= 15) LixLevel = "Let: børn - 2. kl.";
                if (comparedLix >= 5 && comparedLix <= 10) LixLevel = "Let: børn - 1. kl.";
                if (comparedLix >= 1 && comparedLix <= 5) LixLevel = "Let: børn - 0. kl.";
                else LixLevel = "Let: børn";
            }
            else if (comparedLix == 0)
            {
                LixLevel = "Ingen punktummer";  
            }
            else
            {
                LixLevel = "ikke defineret";
            }

            // Retunerer sværhedsgraden for Lix som en string
            return LixLevel;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Laver en instance af open file dialog box.
            OpenFileDialog ofd = new OpenFileDialog();

            // Sætter filter indstillinger and filter index.
            ofd.Filter = "Text Files (.txt)|*.txt|PDF (.pdf)|*.pdf|All files (*.*)|*.*";
            
            // sætter filterindex = 3, så brugeren kan se alle kompatible filer, når 
            ofd.FilterIndex = 3;

            if(ofd.ShowDialog() == DialogResult.OK) // denne kode køres kun hvis den var successfuld
            {
                // her får vi filtypen, så vi ved om det er en txt eller en pdf fil
                string filType = Path.GetExtension(ofd.FileName);

                // Får den fulde sti til filen så vi er sikre på det er den rigtige
                string strfilename = ofd.InitialDirectory + ofd.FileName;

                if (filType == ".pdf")
                {
                    MessageBox.Show(".pdf fil blev uploaded");

                    // rtbText sættes lig med funktionen GetTextFromAllPages til tekst stringen som holder den fulde sti.
                    rtbText.Text = GetTextFromAllPages(strfilename);
                }
                else if (filType == ".txt")
                {
                    MessageBox.Show(".txt fil blev uploaded");

                    // System IO bruges til at læse alt tekst fra filen og sætter stringen text lig med det
                    string text = File.ReadAllText(strfilename);

                    // rtbText sættes lig med string text
                    rtbText.Text = text;
                }
                else // fejlmeddelse, hvis if statementet ikke opfyldes
                {
                    MessageBox.Show("Ukendt filtype. Prøv en anden med filtypen .pdf eller .txt");
                }

          
            }
            else // fejlmeddelse, hvis if statementet ikke opfyldes
            {
                MessageBox.Show("Der skete en fejl, og filen skal vælges igen.");
            }
   
        }

        public static string GetTextFromAllPages(String pdfPath)
        {
            /* her bruges itextsharp - Dette er andet kode som er hentet fra Stackoverflow her:
            http://stackoverflow.com/questions/4711134/itextsharp-text-extraction
            */
            PdfReader reader = new PdfReader(pdfPath);
       
            StringWriter output = new StringWriter();

            for (int i = 1; i <= reader.NumberOfPages; i++)
                output.WriteLine(PdfTextExtractor.GetTextFromPage(reader, i, new SimpleTextExtractionStrategy()));

            return output.ToString();
        }

        private void lblAddSche_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // definerer iMax
            int iMax = 0; // iMax bruges til få det nyeste item fra listen lstSche
            int bogensLix = 0;
            string bogensTitel = txtTitel.Text;

            // Parser bogens LIX-tal ved TryParse
            try
            {
                bogensLix = Int32.Parse(txtLix.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Bogens LIX-tal er i forkert format! Der kræves et tal");
            }
           
            // tilføjer tidspunkt fra DataTimePicker (dtpSche)
            lstSche.Items.Add(dtpScheTime.Text + " - " + dtpScheDate.Text + " - Titel: " + bogensTitel + " - LIX: " + bogensLix);

            // looper gennem combo box, så vi har det sidste entry i listen
            for (int i = 0; i < lstSche.Items.Count; i++)
            {
                iMax = i;
            }

            // Sætter teksten næste læsning under main-tabben til Items[0] værdi
            lblTimer.Text = lstSche.Items[iMax].ToString();
        }

        private void lblNextSche_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // linker til tidsplanen-tabben i under main-tabben
            tabControl1.SelectedTab = tabPage3;
        }

        public void analyserTekst(int karakterer)
        {
            hvorLangtErVi = 0;

            #region analysemetoder
            // analyse 1 og analyse 2 
            foreach (char c in LixText)
            {
                if (karakterer > hvorLangtErVi)
                {
                    // logikken for variabler
                    if (c == ' ') // analyse 1
                    {
                        // Der skrives +1 til variablen
                        O++;
                        lblO.Text = "O: " + O.ToString(); // analyse panel
                    }
                    else if (c == '.') // analyse 2 
                    {
                        // Der skrives +1 til variablen
                        P++;
                        lblP.Text = "P: " + P.ToString(); // analyse panel
                    }

                    // hvorLangtErVi stiger med 1, så vi ikke opfylder betingelsen, når analysen er færdig
                    hvorLangtErVi++;
                }

                else
                {

                    // vi hopper ud af loopet, og kører analyse 3 med metoden analyserLangeOrd
                    analyserLangeOrd(karakterer);
                    return;
                }
            }

            #endregion

        }

        public void analyserLangeOrd(int _karakterer)
        {
            // splitter ordene - bruges til analyse 3: L
            string[] words = LixText.Split(' ');

            // sætter hvorLangtErVi til 0, så vi starter forfra
            hvorLangtErVi = 0;

            // analyse 3
            foreach (string word in words)
            {
                if (_karakterer > hvorLangtErVi)
                {
                    // logikken for variabler
                    if (word.Length > 6)
                    {
                        // Der skrives +1 til variablen
                        L++;
                        lblL.Text = "L: " + L.ToString(); // analyse panel
                    }

                    // hvorLangtErVi stiger med 1, så vi ikke opfylder betingelsen, når analysen er færdig
                    hvorLangtErVi++;
                }
                else
                {
                    // vi hopper ud, hvis vi ikke længere opfylder betingelsen
                    return;
                }


            }
        }

        private void lblViewTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // laver en ny isntance af Tabel
            Tabel frmTabel = new Tabel();

            // instancen frmTabel vises
            frmTabel.Show();
        }
    }
    }

