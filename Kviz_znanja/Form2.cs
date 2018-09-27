using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kviz_znanja
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int bb=2;
        public int brojac;
        public int bodovi;
        public List<pitanja> lista = new List<pitanja>();
        public void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = "Za pomoć kliknuti na sliku";
            label4.Text = "Bodovi ";
            label5.Text = bodovi.ToString();
            brojac = 1;
            List<string> odg = new List<string>();
            List<string> hint = new List<string>();
            odg.Add("Abakus");
            odg.Add("Akro");
            odg.Add("Pascalina");
            odg.Add("Logaritamsko racunalo");
            hint.Add("Pascalina");
            hint.Add("Abakus");
            pitanja pi = new pitanja("Kako se zvalo prvo pomagalo za računanje ? ", "Abakus",odg, hint );
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Copy");
            odg.Add("Paste");
            odg.Add("Cut");
            odg.Add("Disable");
            hint.Add("Paste");
            hint.Add("Copy");
            pi = new pitanja("Kombinacija Ctrl+V na tipkovnici koristi se u Windows aplikacijama za komandu: ", "Paste", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Fizicki dio racunala");
            odg.Add("Racunalna mreza");
            odg.Add("Programski dio racunala");
            odg.Add("Uredaj za memoriju");
            hint.Add("Programski dio racunala");
            hint.Add("Fizicki dio racunala");
            pi = new pitanja("Softver je: ? ", "Programski dio racunala", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("neisporučeni mail");
            odg.Add("mail zaražen virusom");
            odg.Add("neželjeni mail");
            odg.Add("virus");
            hint.Add("neželjeni mail");
            hint.Add("neisporučeni mail");
            pi = new pitanja("Spam je: ", "neželjeni mail", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("F");
            odg.Add("11");
            odg.Add("16");
            odg.Add("10");
            hint.Add("16");
            hint.Add("10");
            pi = new pitanja("Zbroj brojeva 8 + 8 u heksadekadskom brojevnom sustavu iznosi:", "10", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Programski jezik");
            odg.Add("Operacijski sustav");
            odg.Add("Aplikacija");
            odg.Add("Fizicki dio racunala");
            hint.Add("Programski jezik");
            hint.Add("Operacijski sustav");
            pi = new pitanja("Pascal je: ", "Programski jezik", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("samo upisivanje sadržaja");
            odg.Add("samo čitanje sadržaja");
            odg.Add("čitanje i upisivanje sadržaja");
            odg.Add("niti jedno od navedenog");
            hint.Add("samo čitanje sadržaja");
            hint.Add("samo upisivanje sadržaja");
            pi = new pitanja("ROM memorija omogućava: ", "samo čitanje sadržaja", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Sprječavanje gubitka podataka");
            odg.Add("Povećanje prostora na hard disku");
            odg.Add("Provera da li fajlovi imaju viruse");
            odg.Add("Da bi se fajlovi lakše pronalazili");
            hint.Add("Povećanje prostora na hard disku");
            hint.Add("Sprječavanje gubitka podataka");
            pi = new pitanja(" Zbog čega je važno praviti rezervne kopije fajlova?", "Sprječavanje gubitka podataka", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Procesor");
            odg.Add("CD-ROM ");
            odg.Add("Miš");
            odg.Add("Disketa ");
            hint.Add("Disketa ");
            hint.Add("Procesor");
            pi = new pitanja("Koja od navedenih komponenti je neophodna da bi računalo radilo?", "Procesor", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Read Only Access Memory ");
            odg.Add("Robust Archive Memory");
            odg.Add("Real Archive Mode");
            odg.Add("Random Access Memory");
            hint.Add("Random Access Memory");
            hint.Add("Real Archive Mode");
            pi = new pitanja("RAM je skraćenica od: ?", "Random Access Memory", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("32 ");
            odg.Add("1 ");
            odg.Add("8 ");
            odg.Add("16 ");
            hint.Add("16 ");
            hint.Add("8 ");
            pi = new pitanja("Koliko bita sadrži 1 bajt?", "8 ", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Calculating Process Unit");
            odg.Add("Control Program Unit");
            odg.Add("Central Processing Unit");
            odg.Add("Control Process Unit");
            hint.Add("Control Process Unit");
            hint.Add("Central Processing Unit");
            pi = new pitanja("Skraćenica CPU označava...?", "Central Processing Unit", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Hibrid Text Multi Language ");
            odg.Add("Hyper Text Multi Language");
            odg.Add("Hyper Text Multimedia Language");
            odg.Add("Hyper Text Markup Language");
            hint.Add("Hyper Text Markup Language");
            hint.Add("Hyper Text Multimedia Language");
            pi = new pitanja("HTML je skaćenica od: ?", "Hyper Text Markup Language", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("8");
            odg.Add("4");
            odg.Add("10");
            odg.Add("2");
            hint.Add("4");
            hint.Add("8");
            pi = new pitanja("Koliko parica sadrži UTP kabl?", "8", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("Intelligent Path");
            odg.Add("Internet Path");
            odg.Add("Internet Protokol");
            odg.Add("Intelligent Protocol ");
            hint.Add("Intelligent Protocol ");
            hint.Add("Internet Protokol");
            pi = new pitanja("IP je skraćenica od: ", "Internet Protokol", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("File Transfer Priority");
            odg.Add("File Trapping Priority");
            odg.Add("File Transfer Protocol ");
            odg.Add("File Trapping Protocol");
            hint.Add("File Trapping Protocol");
            hint.Add("File Transfer Protocol ");
            pi = new pitanja("FTP je skraćenica od: ", "File Transfer Protocol ", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("http:\\www.yahoo.com ");
            odg.Add("http://www.yahoo.com ");
            odg.Add("http:/www.yahoo.com ");
            odg.Add("http:///www.yahoo.com ");
            hint.Add("http:\\www.yahoo.com ");
            hint.Add("http://www.yahoo.com ");
            pi = new pitanja("Koja URL adresa je pravilno napisana?", "http://www.yahoo.com ", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("LAN");
            odg.Add("WAN");
            odg.Add("WWW");
            odg.Add("MAN");
            hint.Add("LAN");
            hint.Add("WAN");
            pi = new pitanja("Kojom oznakom (skraćenicom) se označavaju lokalne računarske mreže: ", "LAN", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("D");
            odg.Add("A");
            odg.Add("C");
            odg.Add("B");
            hint.Add("C");
            hint.Add("B");
            pi = new pitanja("Kako označavamo broj 11 u heksadecimalnom sustavu? ", "B", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("//");
            odg.Add("%");
            odg.Add("!=");
            odg.Add("==");
            hint.Add("//");
            hint.Add("%");
            pi = new pitanja("Aritmetički operator za ostatak cjelobrojnoj dijeljenja u Pythonu je: ", "%", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("sqrt(x)");
            odg.Add("pow(x,2)");
            odg.Add("trunc(x)");
            odg.Add("round(x)");
            hint.Add("round(x)");
            hint.Add("sqrt(x)");
            pi = new pitanja("Kako označavamo drugi korijen realnog broja u Pythonu?", "sqrt(x)", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("GIF");
            odg.Add("JPG");
            odg.Add("TIFF");
            odg.Add("BMP");
            hint.Add("JPG");
            hint.Add("GIF");
            pi = new pitanja("Koji od navedenih slikovnih formata omogućuje spremanje jednostavnih animacija? ", "GIF", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("xml");
            odg.Add("pops");
            odg.Add("xml");
            odg.Add("https");
            hint.Add("https");
            hint.Add("xml");
            pi = new pitanja("Koji od sljedećih protokola omogućuje sigurniju kupovinu putem weba?", "https", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("tekstualnoga");
            odg.Add("slikovnoga");
            odg.Add("izvršnoga");
            odg.Add("video");
            hint.Add("tekstualnoga");
            hint.Add("video");
            pi = new pitanja("Kojega je tipa datoteka čije je ime slika.avi? ", "video", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("MS Outlook");
            odg.Add("MS Word");
            odg.Add("MS PowerPoint");
            odg.Add("MS Excel");
            hint.Add("MS PowerPoint");
            hint.Add("MS Outlook");
            pi = new pitanja("Koji je od navedenih programa namijenjen slanju i primanju poruka elektroničke pošte ? ", "MS Outlook", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("tekstualnoga");
            odg.Add("slikovnoga");
            odg.Add("izvršnoga");
            odg.Add("video");
            hint.Add("tekstualnoga");
            hint.Add("slikovnoga");
            pi = new pitanja("Kojega je tipa datoteka čije je ime slika.rtf ?", "tekstualnoga", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("adresa bajta");
            odg.Add("web adresa");
            odg.Add("IP adresa");
            odg.Add("e-mail adresa");
            hint.Add("e-mail adresa");
            hint.Add("IP adresa");
            pi = new pitanja("Kako se naziva jedinstvena adresa računala unutar računalne mreže? ", "IP adresa", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("HTTP");
            odg.Add("IP");
            odg.Add("URL");
            odg.Add("DNS");
            hint.Add("DNS");
            hint.Add("URL");
            pi = new pitanja("Kako se naziva sustav koji prevodi brojčanu adresu računala u simboličku i obrnuto?", "DNS", odg, hint);
            lista.Add(pi);


            odg = new List<string>();
            hint = new List<string>();
            odg.Add("16");
            odg.Add("15");
            odg.Add("4");
            odg.Add("8");
            hint.Add("8");
            hint.Add("16");
            pi = new pitanja("Kolika je baza hexadecimalnog sustava ?", "16", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("slikovna");
            odg.Add("tekstualna");
            odg.Add("programska");
            odg.Add("zvukovna");
            hint.Add("programska");
            hint.Add("zvukovna");
            pi = new pitanja("Koja od navedenih datoteka može imati nastavak .wav? ?", "zvukovna", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("telnet");
            odg.Add("ftp");
            odg.Add("http");
            odg.Add("smtp");
            hint.Add("http");
            hint.Add("ftp");
            pi = new pitanja("Koji je osnovni protokol za World Wide Web?", "http", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("u tablicu");
            odg.Add("u zaglavlje");
            odg.Add("u podnožje");
            odg.Add("u tekstni okvir");
            hint.Add("u zaglavlje");
            hint.Add("u podnožje");
            pi = new pitanja("Gdje ćemo upisati već jednom upisani tekst ako želimo da se pojavljuje na dnu svake stranice Word dokumenta ? ", "u podnožje", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("16");
            odg.Add("15");
            odg.Add("4");
            odg.Add("8");
            hint.Add("8");
            hint.Add("16");
            pi = new pitanja("Kolika je baza hexadecimalnog sustava ?", "16", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("16");
            odg.Add("15");
            odg.Add("4");
            odg.Add("8");
            hint.Add("8");
            hint.Add("16");
            pi = new pitanja("Kolika je baza hexadecimalnog sustava ?", "16", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("16");
            odg.Add("15");
            odg.Add("4");
            odg.Add("8");
            hint.Add("8");
            hint.Add("16");
            pi = new pitanja("Kolika je baza hexadecimalnog sustava ?", "16", odg, hint);
            lista.Add(pi);

            odg = new List<string>();
            hint = new List<string>();
            odg.Add("16");
            odg.Add("15");
            odg.Add("4");
            odg.Add("8");
            hint.Add("8");
            hint.Add("16");
            pi = new pitanja("Kolika je baza hexadecimalnog sustava ?", "16", odg, hint);
            lista.Add(pi);

            label1.Text = brojac.ToString() + ". pitanje";

            label2.Text = pi.Pitanje;
            int d = lista.Count();
            
            label1.Text = brojac.ToString() + ". pitanje";
            label2.Text = lista[brojac-1].Pitanje;
            comboBox1.Items.Clear();
            comboBox1.Items.Add(lista[brojac-1].Odgovori[0]);
            comboBox1.Items.Add(lista[brojac-1].Odgovori[1]);
            comboBox1.Items.Add(lista[brojac-1].Odgovori[2]);
            comboBox1.Items.Add(lista[brojac-1].Odgovori[3]);
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            comboBox1.Items.Clear();
            
            label3.Text += lista[brojac - 1].Hint[0].ToString();
            label3.Text += "\n";
            label3.Text += lista[brojac - 1].Hint[1].ToString();
            
            comboBox1.Items.Add(lista[brojac - 1].Hint[0].ToString());
            comboBox1.Items.Add(lista[brojac - 1].Hint[1].ToString());
            bodovi = bodovi - 1;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Za pomoć kliknuti na sliku";
            
            string kon_odg = comboBox1.SelectedItem.ToString();
            if (kon_odg == lista[brojac-1].TocanOdgovor)
            {
                bodovi = bodovi + 3;
                MessageBox.Show("Točan odgovor! ");
                label5.Text = bodovi.ToString();
                label1.Text = bb.ToString() + ". pitanje";
                label2.Text = lista[bb - 1].Pitanje;
                comboBox1.Items.Clear();
                comboBox1.Items.Add(lista[bb - 1].Odgovori[0]);
                comboBox1.Items.Add(lista[bb - 1].Odgovori[1]);
                comboBox1.Items.Add(lista[bb - 1].Odgovori[2]);
                comboBox1.Items.Add(lista[bb - 1].Odgovori[3]);
                bb = bb + 1;
            }
            else
            {
                MessageBox.Show("Netočan odgovor! ");
                this.Close();
            }
            brojac = brojac + 1;
            comboBox1.Text = "";
            if (bodovi > 5 && bodovi <= 10)
                BackColor = Color.HotPink;

            if (bodovi <= 20 && bodovi > 10)
            {
                BackColor = Color.Gray;
            }
            if (bodovi <= 30 && bodovi > 20)
            {
                BackColor = Color.Gold;
            }
            if (bodovi <= 40 && bodovi > 30)
            {
                BackColor = Color.Gainsboro;
            }
            if (bodovi <= 50 && bodovi > 40)
            {
                BackColor = Color.LawnGreen;
            }
            if (bodovi <= 60 && bodovi > 50)
            {
                BackColor = Color.Lavender;
            }
            if (bodovi <= 70 && bodovi > 60)
            {
                BackColor = Color.LightBlue;
            }
            if (bodovi <= 80 && bodovi > 70)
            {
                BackColor = Color.LightGoldenrodYellow;
            }
            if (bodovi <= 90 && bodovi > 80)
            {
                BackColor = Color.LightSkyBlue;
            }
            
            if (bodovi > 90)
            {
                comboBox1.Hide();
                label1.Text = label2.Text = label3.Text = label4.Text = label5.Text = "";
                button1.Hide();
                button5.Hide();
                pictureBox1.Hide();
                BackColor = Color.Coral;
                label1.Text =  "Došli ste do kraja igre!";
                pictureBox2.Show();
                MessageBox.Show("Čestitamo! " );

            }

        }
        public Igrac i;
    }
}
