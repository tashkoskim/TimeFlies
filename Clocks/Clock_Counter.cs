using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Net;
using DocumentFormat.OpenXml.Packaging;
using Spire.Doc;

namespace TimeFlies.Clocks
{
    public partial class Clock_Counter : Form
    {
        public Clock_Counter()
        {
            InitializeComponent();
        }

        

        List<string> listaPrazniciOpis = new List<string>();
        List<DateTime> listaPrazniciDatumi = new List<DateTime>();
        Dictionary<string, int> meseci = new Dictionary<string, int> 
        { 
            {  "јануари", 1 },
            {  "февруари", 2},
            {  "март", 3},
            {  "април", 4},
            {  "мај", 5},
            {  "јуни", 6},
            {  "јули", 7},
            { "август", 8},
            {  "септември", 9},
            { "октомври", 10},
            { "ноември", 11},
            { "декември", 12}
        };
        Dictionary<int, string> denoviNedela = new Dictionary<int, string>
        {
            { 1, "Понеделник"},
            { 2, "Вторник"},
            { 3, "Среда"},
            { 4, "Четврток"},
            { 5, "Петок"},
            { 6, "Сабота"},
            { 0, "Недела"}
        };

        private void Clock_Counter_Load(object sender, EventArgs e)
        {
            int tekGod = DateTime.Now.Year;

            // https://www.mtsp.gov.mk/programa-za-nerabotni-denovi.nspx
            PodgotviPraznici(tekGod);

            
            string[] praznik = prvPraznik();
            if(string.IsNullOrEmpty(praznik[0]))
            {
                listaPrazniciOpis.Clear();
                listaPrazniciDatumi.Clear();
                PodgotviPraznici(tekGod+1);
                praznik = prvPraznik();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Digitalen casovnik
            DigitalClock objDigital = new DigitalClock();
            lblDigital.Text = objDigital.Digital_Clock();

            CounterClock(); 
            
        }

        private void CounterClock()
        {
            CounterImageChange();

            // nazivot na group box-ot
            groupBox1.Text = denesenDenTekstualno(DateTime.Now.Date);

            // presmetka za sekundite
            DateTime denes = DateTime.Now;
            DateTime pomDen = new DateTime(denes.AddDays(1).Year, denes.AddDays(1).Month, denes.AddDays(1).Day, 0, 0, 1);
            TimeSpan ts = pomDen.Subtract(denes);

            string sekundiLeft = ts.Seconds + " секунди!";
            if (ts.Seconds == 1 || ts.Seconds == 21 || ts.Seconds == 31 || ts.Seconds == 41 || ts.Seconds == 51)
                sekundiLeft = ts.Seconds + " секунда!";


            string vikend = vremeDoVikend() + sekundiLeft;
            string[] praznik = prvPraznik();

            txtBoxInfo.Text = Environment.NewLine + "- " +vikend + Environment.NewLine + Environment.NewLine + "- " +praznik[0] + sekundiLeft + Environment.NewLine + ">>> " + praznik[1];
            //lblPraznik.Text = praznik[0] + Environment.NewLine + ">>> "+praznik[1];
        }

        string pomHH = "00";
        string pomMM = "00";
        string pomSS = "00";

        private void CounterImageChange()
        {

            int hh = DateTime.Now.Hour;
            if (hh == 0)
                hh = 24;
            pomHH = hh.ToString();
            if (pomHH.Length == 1)
            {
                pBoxHH1.Image = Image.FromFile(@"images\counterH1_0.png");
                pBoxHH2.Image = Image.FromFile(@"images\counter_" + pomHH[0] + ".png");
            }
            else
            {
                pBoxHH1.Image = Image.FromFile(@"images\counterH1_" + pomHH[0] + ".png");
                pBoxHH2.Image = Image.FromFile(@"images\counter_" + pomHH[1] + ".png");
            }
            int mm = DateTime.Now.Minute;
            if (mm == 0)
                mm = 60;
            pomMM = mm.ToString();
            if (pomMM.Length == 1)
            {
                pBoxMM1.Image = Image.FromFile(@"images\counterM1_0.png");
                pBoxMM2.Image = Image.FromFile(@"images\counter_" + pomMM[0] + ".png");
            }
            else
            {
                if(pomMM[0]=='0' || pomMM[0] == '6')
                    pBoxMM1.Image = Image.FromFile(@"images\counterM1_" + pomMM[0] + ".png");
                else
                    pBoxMM1.Image = Image.FromFile(@"images\counter_" + pomMM[0] + ".png");
                pBoxMM2.Image = Image.FromFile(@"images\counter_" + pomMM[1] + ".png");
            }
            int ss = DateTime.Now.Second;
            if (ss == 0)
                ss = 60;
            pomSS = ss.ToString();
            if (pomSS.Length == 1)
            {
                pBoxSS1.Image = Image.FromFile(@"images\counterS1_0.png");
                pBoxSS2.Image = Image.FromFile(@"images\counterS2_" + pomSS[0] + ".png");
            }
            else
            {
                if (pomSS[0] == '0' || pomSS[0] == '6')
                    pBoxSS1.Image = Image.FromFile(@"images\counterS1_" + pomSS[0] + ".png");
                else
                    pBoxSS1.Image = Image.FromFile(@"images\counterS2_" + pomSS[0] + ".png");
                pBoxSS2.Image = Image.FromFile(@"images\counterS2_" + pomSS[1] + ".png");

            }

        }

        private string denesenDenTekstualno(DateTime dt)
        {
            string final = "";
            int mesec = dt.Month;
            int den = dt.Day;
            int god = dt.Year;
            int denTekst = Convert.ToInt32(dt.DayOfWeek);

            string pomMesec = "";
            foreach (var m in meseci)
            {
                if (m.Value == mesec)
                {
                    pomMesec = m.Key;
                }
            }
            final = denoviNedela[denTekst] + ", " + den.ToString() + " " + pomMesec + " " + god.ToString() + " год.";

            return final;
        }
        //------------------------------------------

        // vrati go prviot praznik sto se blizi
        private string[] prvPraznik()
        {
            string[] praznikPoraka = { "",""};
            DateTime denes = DateTime.Now; //new DateTime(2021,10,25,22,22,0);
            for (int i=0;i<listaPrazniciDatumi.Count;i++)
            {
                DateTime pomPraznik = listaPrazniciDatumi[i];
                int res = denes.CompareTo(pomPraznik);
                if(res<0)
                {
                    TimeSpan ts = pomPraznik.Subtract(denes);

                  
                    string denoviLeft = ts.Days + " дена, ";
                    if (ts.Days == 1 || (ts.Days>11 &&ts.Days.ToString().EndsWith("1")) )
                        denoviLeft = ts.Days + " ден, ";
                    string casoviLeft = ts.Hours + " часа, ";
                    if (ts.Hours == 1 || ts.Hours == 21)
                        casoviLeft = ts.Hours + " час, ";
                    string minutiLeft = ts.Minutes + " минути и ";
                    if (ts.Minutes == 1 || ts.Minutes == 21 || ts.Minutes == 31 || ts.Minutes == 41 || ts.Minutes == 51)
                        minutiLeft = ts.Minutes + " минута и ";
                    //string sekundiLeft = ts.Seconds + " секунди!";
                    //if (ts.Seconds == 1 || ts.Seconds == 21 || ts.Seconds == 31 || ts.Seconds == 41 || ts.Seconds == 51)
                    //    sekundiLeft = ts.Seconds + " секунда!";

                    int den = Convert.ToInt32(pomPraznik.DayOfWeek);
                    if (den == 6)
                        praznikPoraka[0] = "Наредниот празник исто како да не е празник :-(, паѓа во сабота и е за " + denoviLeft + casoviLeft + minutiLeft;// + sekundiLeft;
                    else if (den == 7)
                        praznikPoraka[0] = "Наредниот празник паѓа во недела (значи понеделникот ќе се одмара) и е за " + denoviLeft + casoviLeft + minutiLeft;// + sekundiLeft;
                    else
                        praznikPoraka[0] = "Нареден празник е за " + denoviLeft + casoviLeft + minutiLeft;// + sekundiLeft;
                    praznikPoraka[1] = listaPrazniciOpis[i];
                    break;
                }
            }
            return praznikPoraka;
        }

        // vrati kolku denovi ima do vikend
        private string vremeDoVikend()
        {
            string vratiPoraka = "";
            DateTime denes = DateTime.Now;
            int den = Convert.ToInt32(DateTime.Now.DayOfWeek);
            if(den == 6)
            {
                vratiPoraka = "Сабота, почетокот од викендот :-)";
            }
            else if (den == 7)       
            {
                vratiPoraka = "Последен ден од викенд... :-( ";
            }
            else
            {
                DateTime vikendPom = denes.AddDays(6 - den);
                DateTime vikend = new DateTime(vikendPom.Year, vikendPom.Month, vikendPom.Day, 0, 0, 1);
                TimeSpan ts = vikend.Subtract(denes);

                string denoviLeft = ts.Days + " дена, ";
                if (ts.Days == 1)
                    denoviLeft = "1 ден, ";
                string casoviLeft = ts.Hours + " часа, ";
                if (ts.Hours == 1 || ts.Hours == 21)
                    casoviLeft = ts.Hours + " час, ";
                string minutiLeft = ts.Minutes + " минути и ";
                if (ts.Minutes == 1 || ts.Minutes == 21 || ts.Minutes == 31 || ts.Minutes == 41 || ts.Minutes == 51)
                    minutiLeft = ts.Minutes + " минута и ";
                //string sekundiLeft = ts.Seconds + " секунди!";
                //if (ts.Seconds == 1 || ts.Seconds == 21 || ts.Seconds == 31 || ts.Seconds == 41 || ts.Seconds == 51)
                //    sekundiLeft = ts.Seconds + " секунда!";
                vratiPoraka = "До викенд остануваат уште " + denoviLeft + casoviLeft + minutiLeft;// + sekundiLeft;
            }
            return vratiPoraka;
        }

        private void PodgotviPraznici(int tekGod)
        {
            

            // web scrapping
            string url = "https://www.mtsp.gov.mk/programa-za-nerabotni-denovi.nspx";
            string file = GetFileUrl(url, tekGod);


            //string file = @"https://www.mtsp.gov.mk/content/pdf/dokumenti/2019/%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%B0%20%D0%BD%D0%B0%20%D0%BD%D0%B5%D1%80%D0%B0%D0%B1%D0%BE%D1%82%D0%BD%D0%B8%20%D0%B4%D0%B5%D0%BD%D0%BE%D0%B2%D0%B8%20%D0%B7%D0%B0%202020%20%D0%B3%D0%BE%D0%B4%D0%B8%D0%BD%D0%B0%201.pdf";
            // PDF
            if(file.Contains(".pdf") || file.Contains(".PDF"))
            {
                //isparstiraj tekst so iTextSharp
                string prazniciTekst = procitajPrazniciPDF(file);
                if (!string.IsNullOrEmpty(prazniciTekst))
                {
                    popolniListaOpis(prazniciTekst);
                    if (listaPrazniciOpis.Count > 0)
                    {
                        popolniListaDatumi(tekGod);
                    }
                }
            // WORD (.doc || .docx)
            }else if (file.Contains(".doc") || file.Contains(".DOC") || file.Contains(".docx") || file.Contains(".DOCX"))
            {
                string[] fileNameNiza = file.Split('/');
                string fileName = fileNameNiza[fileNameNiza.Length - 1];
                using (var client = new WebClient())
                {
                    client.DownloadFile(file, "documents/"+ fileName );
                }
                string wordFile = "documents/" + fileName;
                if (!fileName.Contains(".docx"))
                {
                    Document document = new Document();
                    document.LoadFromFile(wordFile);

                    wordFile += "x";
                    document.SaveToFile(wordFile, FileFormat.Docx2013);
                }


                using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(wordFile, false))
                {
                    DocumentFormat.OpenXml.Wordprocessing.Body body
                        = wordDoc.MainDocumentPart.Document.Body;

                    string prazniciTekst = body.InnerText;
                    if (!string.IsNullOrEmpty(prazniciTekst))
                    {
                        popolniListaOpis(body);
                        if (listaPrazniciOpis.Count > 0)
                        {
                            popolniListaDatumi(tekGod);
                        }
                    }

                }
            }

            // podredi ja listata so datumite
            podrediDatumi();
        }

        private void podrediDatumi()
        {
            int n = listaPrazniciDatumi.Count;
            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-i-1;j++)
                {
                    int res = DateTime.Compare(listaPrazniciDatumi[j], listaPrazniciDatumi[j + 1]);
                    if(res > 0)
                    {
                        DateTime temp = listaPrazniciDatumi[j];
                        listaPrazniciDatumi[j] = listaPrazniciDatumi[j + 1];
                        listaPrazniciDatumi[j + 1] = temp;

                        string temp2 = listaPrazniciOpis[j];
                        listaPrazniciOpis[j] = listaPrazniciOpis[j + 1];
                        listaPrazniciOpis[j + 1] = temp2;
                    }
                }
            }
        }
        private string GetFileUrl(string url, int god)
        {
            string htmlCode = "";
            using (WebClient client = new WebClient())
            {
                htmlCode = client.DownloadString(url);
            }

            string fileUrl = "";
            string[] linii = htmlCode.Split('\n');

            foreach(string s in linii)
            {
                if(s.Contains("Програма за неработни денови за "+god.ToString()+" година"))
                {
                    string[] pomUrl = s.Split('=');
                    string[] pomUrl2 = pomUrl[1].Split('>');
                    fileUrl = "https://www.mtsp.gov.mk/" + pomUrl2[0].Trim('"');

                    return fileUrl;
                }
            }

            return fileUrl;

        }

        private void popolniListaDatumi(int god)
        {
            foreach(string s in listaPrazniciOpis)
            {
                string[] nizaPom = s.Split(' ');
                int den = Convert.ToInt32(nizaPom[0].Trim());
                int mesec = meseci[nizaPom[1].Trim().ToLower()];
                DateTime datumPraznik = new DateTime(god,mesec,den);
                listaPrazniciDatumi.Add(datumPraznik);
            }
        }

        // za od pdf
        private void popolniListaOpis(string t)
        {
            string[] niza = t.Split('\n'); //(new[] { Environment.NewLine }, StringSplitOptions.None);
            for(int i=0;i<niza.Length;i++)
            {
                string s = niza[i].Trim();
                if(s.Contains("За сите граѓани"))
                {
                    i++;
                    s = niza[i];
                    while(!s.Contains("За граѓаните"))
                    {
                        if(!string.IsNullOrEmpty(s))
                        {
                            string pom = s.Trim();
                            if (s.Contains("•"))
                                pom = pom.TrimStart('•');
                            pom = pom.TrimEnd(',');
                            pom = pom.TrimEnd('.');
                            pom = pom.Trim();

                            char broj = pom[0];
                            if (Char.IsDigit(broj))
                            {
                                listaPrazniciOpis.Add(pom);
                            }
                            else
                            {
                                //znaci e od prethodniot red
                                string pomEl = listaPrazniciOpis[listaPrazniciOpis.Count - 1] + " " + pom;
                                listaPrazniciOpis.RemoveAt(listaPrazniciOpis.Count - 1);
                                listaPrazniciOpis.Add(pomEl);
                            }
                        }

                        i++;
                        s = niza[i].Trim();
                        
                    }// KRAJ za while(!s.Contains("За граѓаните"))
                }// KRAJ za if(s.Contains("За сите граѓани"))

                if (s.Contains("православна вероисповед"))
                {
                    i++;
                    s = niza[i];
                    while (!s.Contains("За граѓаните"))
                    {
                        if (!string.IsNullOrEmpty(s))
                        {
                            string pom = s.Trim();
                            if (s.Contains("•"))
                                pom = pom.TrimStart('•');
                            pom = pom.TrimEnd(',');
                            pom = pom.TrimEnd('.');
                            pom = pom.Trim();

                            char broj = pom[0];
                            if(Char.IsDigit(broj))
                            {
                                listaPrazniciOpis.Add(pom);
                            }
                            else
                            {
                                //znaci e od prethodniot red
                                string pomEl = listaPrazniciOpis[listaPrazniciOpis.Count - 1] + " " + pom;
                                listaPrazniciOpis.RemoveAt(listaPrazniciOpis.Count - 1);
                                listaPrazniciOpis.Add(pomEl);
                            }
                            
                        }

                        i++;
                        s = niza[i].Trim();
                        
                    }// KRAJ za while(!s.Contains("За граѓаните"))
                }// KRAJ za if(s.Contains("За сите граѓани"))

            }
        }

        // za od word
        private void popolniListaOpis(DocumentFormat.OpenXml.Wordprocessing.Body body)
        {
            bool zname = false, zname2 = false;
            foreach (DocumentFormat.OpenXml.Wordprocessing.Paragraph p in body.ChildElements)
            {
                string s = p.InnerText.Trim();
                //string s = p.InnerText.Trim();
                if (s.Contains("За сите граѓани") || zname == true)
                {
                    if(zname == false)
                    {
                        zname = true;
                        continue;
                    }
                    s = p.InnerText.Trim();
                    if (!s.Contains("За граѓаните"))
                    {
                        if (!string.IsNullOrEmpty(s))
                        {
                            string pom = s.Trim();
                            if (s.Contains("•"))
                                pom = pom.TrimStart('•');
                            pom = pom.TrimEnd(',');
                            pom = pom.TrimEnd('.');
                            pom = pom.Trim();

                            char broj = pom[0];
                            if (Char.IsDigit(broj))
                            {
                                listaPrazniciOpis.Add(pom);
                            }
                            else
                            {
                                //znaci e od prethodniot red
                                string pomEl = listaPrazniciOpis[listaPrazniciOpis.Count - 1] + " " + pom;
                                listaPrazniciOpis.RemoveAt(listaPrazniciOpis.Count - 1);
                                listaPrazniciOpis.Add(pomEl);
                            }
                        }

                        //s = p.NextSibling().InnerText.Trim();

                    }// KRAJ za while(!s.Contains("За граѓаните"))
                    else
                    {
                        zname = false;
                    }
                }// KRAJ za if(s.Contains("За сите граѓани"))

                if (s.Contains("православна вероисповед") || zname2 == true)
                {
                    if (zname2 == false)
                    {
                        zname2 = true;
                        continue;
                    }
                    s = p.InnerText.Trim();
                    if (!s.Contains("За граѓаните"))
                    {
                        if (!string.IsNullOrEmpty(s))
                        {
                            string pom = s.Trim();
                            if (s.Contains("•"))
                                pom = pom.TrimStart('•');
                            pom = pom.TrimEnd(',');
                            pom = pom.TrimEnd('.');
                            pom = pom.Trim();

                            char broj = pom[0];
                            if (Char.IsDigit(broj))
                            {
                                listaPrazniciOpis.Add(pom);
                            }
                            else
                            {
                                //znaci e od prethodniot red
                                string pomEl = listaPrazniciOpis[listaPrazniciOpis.Count - 1] + " " + pom;
                                listaPrazniciOpis.RemoveAt(listaPrazniciOpis.Count - 1);
                                listaPrazniciOpis.Add(pomEl);
                            }

                        }

                        //s = p.NextSibling().InnerText.Trim();

                    }// KRAJ za while(!s.Contains("За граѓаните"))
                    else
                    {
                        zname2 = false;
                        break;
                    }
                }// KRAJ za if(s.Contains("За сите граѓани"))
            }

            
        }

        private string procitajPrazniciPDF(string file)
        {
            StringBuilder sb = new StringBuilder();

            using (PdfReader reader = new PdfReader(file))
            {
                for (int pageNo = 1; pageNo <= reader.NumberOfPages; pageNo++)
                {
                    ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                    string text = PdfTextExtractor.GetTextFromPage(reader, pageNo, strategy);
                    text = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text)));
                    sb.Append(text);
                }
            }

            return sb.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
