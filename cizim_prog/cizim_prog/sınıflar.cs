using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cizim_prog
{
    class MenuArkaplanRenk  
    {
        public static void ArkaPlanDegis(Panel panelAd, Color renk)
        {
            panelAd.BackColor = renk;
        }

      
    }
    class MenuSekilCiz 
    {
        private static Graphics grafik;  
        private static Brush firca;

        public static void MenuCiz(Panel panelAd, Color fircaRenk, Point[] noktalar)
        {
            grafik = panelAd.CreateGraphics();
            firca = new SolidBrush(fircaRenk);
            grafik.FillPolygon(firca, noktalar);
        }
       

        public static void MenuCiz(Panel panelAd, string sekilAd, Color fircaRenk, int x, int y, int w, int h)
        {
            grafik = panelAd.CreateGraphics();
            firca = new SolidBrush(fircaRenk);
            if (sekilAd == "kare")
            {
                grafik.FillRectangle(firca, x, y, w, h);
            }
            else
            {
                grafik.FillEllipse(firca, x, y, w, h);
            }
        }


    }
    
    class SekilCiz : Kaydet 
    {
        static int a = 0;
        protected static Graphics graf;
        protected static Brush firca;
        private static bool kare = false, ucgen = false, altigen = false, daire = false, ciz = false;
        private static int x, y;

        public static void sekilCizTik(string sekilAd) 
        {

            if (sekilAd == "kare")
            {
                kare = true;
                daire = false;
                ucgen = false;
                altigen = false;
            }
            else if (sekilAd == "daire")
            {
                daire = true;
                kare = false;
                ucgen = false;
                altigen = false;
            }
            else if (sekilAd == "ucgen")
            {
                ucgen = true;
                daire = false;
                kare = false;
                altigen = false;
            }
            else if (sekilAd == "altigen")
            {
                altigen = true;
                daire = false;
                ucgen = false;
                kare = false;
            }
        }
       
        public static void sekilCizUp()
        {

            ciz = false;
            a = 1;


        }
      
        public static void sekilCiz(MouseEventArgs basKonum)
        {
            ciz = true;
            x = basKonum.X;
            y = basKonum.Y;




        }
        
        public static void sekilCiz(Panel panelAd, MouseEventArgs harKonum, Color renk, string strrenk) 
        {


            if ((ciz == true) && kare)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                dosyaOku(panelAd);
                int y2 = harKonum.Y, x2 = harKonum.X;

                Point[] kareNoktalar = { new Point(x, y), new Point(x, harKonum.Y), new Point(harKonum.X, harKonum.Y), new Point(harKonum.X, y) };
                graf.FillPolygon(firca, kareNoktalar);

            }
            else if ((ciz == true) && daire)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                dosyaOku(panelAd);
                graf.FillEllipse(firca, 2 * x - harKonum.X, 2 * y - harKonum.Y, 2 * (harKonum.X - x), 2 * (harKonum.Y - y));
            }
            else if (ciz == true && ucgen)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                dosyaOku(panelAd);
                Point[] ucgenDizi = { new Point(x, y), new Point(x - (harKonum.X - x), harKonum.Y), new Point(harKonum.X, harKonum.Y) };
                graf.FillPolygon(firca, ucgenDizi);
            }
            else if (ciz == true && altigen)
            {
                graf = panelAd.CreateGraphics();
                firca = new SolidBrush(renk);
                graf.Clear(Color.Gainsboro);
                dosyaOku(panelAd);
                Point[] altigenNoktalar = { new Point((x - (harKonum.X - x) / 2), y - Math.Abs(harKonum.Y - y)), new Point(2 * x - harKonum.X, y), new Point((x - (harKonum.X - x) / 2), harKonum.Y), new Point((x + (harKonum.X - x) / 2), harKonum.Y), new Point(harKonum.X, y), new Point((x + (harKonum.X - x) / 2), y - Math.Abs(harKonum.Y - y)) };

                graf.FillPolygon(firca, altigenNoktalar);
            }


        }





    }
 
    class Kaydet 
    {


        private static FileStream dosyaYaz; 
        private static StreamWriter yaz;
        protected static string dosyaYolu;
        public static void dosyaTemizle()  
        {
            dosyaYolu = Application.StartupPath.ToString() + "\\temporary.tmp";
            dosyaYaz = new FileStream(dosyaYolu, FileMode.Truncate);
            yaz = new StreamWriter(dosyaYaz);

            yaz.Write("");
            yaz.Close();
            dosyaYaz.Close();
        }
       


        public static void dosyaOku(Panel panel1) 
        {
            Graphics grafik = panel1.CreateGraphics();
            Brush firca;



            Color renk = Color.Black;
            string[] okunan;
            okunan = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
            string[] okunanDizi = new string[300];
        



            for (int j = 0; j < okunan.Length; j++)   
            {

                if ((okunan[j].Split(','))[1] == "kirmizi")
                {
                    renk = Color.Red;
                }
                else if ((okunan[j].Split(','))[1] == "kkirmizi")
                {
                    renk = Color.DarkRed;
                }
                else if ((okunan[j].Split(','))[1] == "mavi")
                {
                    renk = Color.Blue;
                }
                else if ((okunan[j].Split(','))[1] == "yesil")
                {
                    renk = Color.Green;
                }
                else if ((okunan[j].Split(','))[1] == "sari")
                {
                    renk = Color.Yellow;
                }
                else if ((okunan[j].Split(','))[1] == "turuncu")
                {
                    renk = Color.Orange;
                }
                else if ((okunan[j].Split(','))[1] == "mor")
                {
                    renk = Color.Purple;
                }
                else if ((okunan[j].Split(','))[1] == "siyah")
                {
                    renk = Color.Black;
                }
                else if ((okunan[j].Split(','))[1] == "beyaz")
                {
                    renk = Color.White;
                }

                if ((okunan[j].Split(','))[0] == "D") 
                {
                    for (int i = 0; i < 6; i++)
                    {

                        okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                    }
                    firca = new SolidBrush(renk);
                    grafik.FillEllipse(firca, Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3]), Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5]));   
                }
                else if ((okunan[j].Split(','))[0] == "U")
                {
                    for (int i = 0; i < 8; i++)
                    {

                        okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                    }

                    Point[] noktalar = { new Point(Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3])), new Point(Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5])), new Point(Convert.ToInt16(okunanDizi[6]), Convert.ToInt16(okunanDizi[7])) };
                    firca = new SolidBrush(renk);
                    grafik.FillPolygon(firca, noktalar);

                }
                else if ((okunan[j].Split(','))[0] == "A")
                {
                    for (int i = 0; i < 14; i++)
                    {

                        okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                    }
                    Point[] noktalar = { new Point(Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3])), new Point(Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5])), new Point(Convert.ToInt16(okunanDizi[6]), Convert.ToInt16(okunanDizi[7])), new Point(Convert.ToInt16(okunanDizi[8]), Convert.ToInt16(okunanDizi[9])), new Point(Convert.ToInt16(okunanDizi[10]), Convert.ToInt16(okunanDizi[11])), new Point(Convert.ToInt16(okunanDizi[12]), Convert.ToInt16(okunanDizi[13])) };
                    firca = new SolidBrush(renk);
                    grafik.FillPolygon(firca, noktalar);
                }
                else if ((okunan[j].Split(','))[0] == "K")
                {
                    for (int i = 0; i < 10; i++)
                    {

                        okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                    }

                    Point[] noktalar = { new Point(Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3])), new Point(Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5])), new Point(Convert.ToInt16(okunanDizi[6]), Convert.ToInt16(okunanDizi[7])), new Point(Convert.ToInt16(okunanDizi[8]), Convert.ToInt16(okunanDizi[9])) };
                    firca = new SolidBrush(renk);
                    grafik.FillPolygon(firca, noktalar);
                }


            }



        }
      

        public static void daire(string renk, int n1, int n2, int n3, int n4) 
        {
            dosyaYolu = Application.StartupPath.ToString() + "\\temporary.tmp";
            dosyaYaz = new FileStream(dosyaYolu, FileMode.Append);
            yaz = new StreamWriter(dosyaYaz);
            string nn1, nn2, nn3, nn4;

            nn1 = Convert.ToString(n1);
            nn2 = Convert.ToString(n2);
            nn3 = Convert.ToString(n3);
            nn4 = Convert.ToString(n4);

            yaz.WriteLine("D," + renk + "," + nn1 + "," + nn2 + "," + nn3 + "," + nn4);
            yaz.Close();
            dosyaYaz.Close();
        }
        


        public static void cokgen(string renk, Point[] noktalar) 
        {
            dosyaYolu = Application.StartupPath.ToString() + "\\temporary.tmp";
            dosyaYaz = new FileStream(dosyaYolu, FileMode.Append);
            yaz = new StreamWriter(dosyaYaz);
            int x = noktalar.Length;
            if (noktalar.Length == 4) 
            {
                yaz.Write("K,");
            }
            else if (noktalar.Length == 3)
            {
                yaz.Write("U,");
            }
            else if (noktalar.Length == 6)
            {
                yaz.Write("A,");
            }

            yaz.Write(renk);
            for (int i = 0; i < x; i++)
            {

                if (i == x - 1)
                {
                    yaz.WriteLine("," + noktalar[i].X + "," + noktalar[i].Y);
                }
                else
                {
                    yaz.Write("," + noktalar[i].X + "," + noktalar[i].Y);
                }


            }

            yaz.Close();
            dosyaYaz.Close();

        }
        
        public static void butonluKayit(SaveFileDialog dia) 
        {
            StreamWriter sw = new StreamWriter(dia.FileName);
            FileStream fs = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string yazi = sr.ReadLine();
            while (yazi != null)
            {

                sw.WriteLine(yazi);
                yazi = sr.ReadLine();
            }
            sw.Close();
            sr.Close();
            fs.Close();

        }
        


    }

    class ButondanOku : Kaydet  
    {

        public static void oku(Panel panel1, OpenFileDialog ofd)
        {
            dosyaTemizle();
            Graphics grafik = panel1.CreateGraphics();
            Brush firca;
            grafik.Clear(Color.Gainsboro);


            try
            {


                Color renk = Color.Black;
                string[] okunan;
                okunan = File.ReadAllLines(ofd.FileName);
                string[] okunanDizi = new string[30];
                string xokunan;
                xokunan = File.ReadAllText(ofd.FileName);
                File.WriteAllText(Application.StartupPath.ToString() + "\\temporary.tmp", xokunan);

                for (int j = 0; j < okunan.Length; j++)
                {

                    if ((okunan[j].Split(','))[1] == "kirmizi")
                    {
                        renk = Color.Red;
                    }
                    else if ((okunan[j].Split(','))[1] == "kkirmizi")
                    {
                        renk = Color.DarkRed;
                    }
                    else if ((okunan[j].Split(','))[1] == "mavi")
                    {
                        renk = Color.Blue;
                    }
                    else if ((okunan[j].Split(','))[1] == "yesil")
                    {
                        renk = Color.Green;
                    }
                    else if ((okunan[j].Split(','))[1] == "sari")
                    {
                        renk = Color.Yellow;
                    }
                    else if ((okunan[j].Split(','))[1] == "turuncu")
                    {
                        renk = Color.Orange;
                    }
                    else if ((okunan[j].Split(','))[1] == "mor")
                    {
                        renk = Color.Purple;
                    }
                    else if ((okunan[j].Split(','))[1] == "siyah")
                    {
                        renk = Color.Black;
                    }
                    else if ((okunan[j].Split(','))[1] == "beyaz")
                    {
                        renk = Color.White;
                    }

                    if ((okunan[j].Split(','))[0] == "D")
                    {
                        for (int i = 0; i < 6; i++)
                        {

                            okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                        }
                        firca = new SolidBrush(renk);
                        grafik.FillEllipse(firca, Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3]), Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5]));
                    }
                    else if ((okunan[j].Split(','))[0] == "U")
                    {
                        for (int i = 0; i < 8; i++)
                        {

                            okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                        }

                        Point[] noktalar = { new Point(Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3])), new Point(Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5])), new Point(Convert.ToInt16(okunanDizi[6]), Convert.ToInt16(okunanDizi[7])) };
                        firca = new SolidBrush(renk);
                        grafik.FillPolygon(firca, noktalar);

                    }
                    else if ((okunan[j].Split(','))[0] == "A")
                    {
                        for (int i = 0; i < 14; i++)
                        {

                            okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                        }
                        Point[] noktalar = { new Point(Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3])), new Point(Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5])), new Point(Convert.ToInt16(okunanDizi[6]), Convert.ToInt16(okunanDizi[7])), new Point(Convert.ToInt16(okunanDizi[8]), Convert.ToInt16(okunanDizi[9])), new Point(Convert.ToInt16(okunanDizi[10]), Convert.ToInt16(okunanDizi[11])), new Point(Convert.ToInt16(okunanDizi[12]), Convert.ToInt16(okunanDizi[13])) };
                        firca = new SolidBrush(renk);
                        grafik.FillPolygon(firca, noktalar);
                    }
                    else if ((okunan[j].Split(','))[0] == "K")
                    {
                        for (int i = 0; i < 10; i++)
                        {

                            okunanDizi[i] = Convert.ToString((okunan[j].Split(','))[i]);

                        }

                        Point[] noktalar = { new Point(Convert.ToInt16(okunanDizi[2]), Convert.ToInt16(okunanDizi[3])), new Point(Convert.ToInt16(okunanDizi[4]), Convert.ToInt16(okunanDizi[5])), new Point(Convert.ToInt16(okunanDizi[6]), Convert.ToInt16(okunanDizi[7])), new Point(Convert.ToInt16(okunanDizi[8]), Convert.ToInt16(okunanDizi[9])) };
                        firca = new SolidBrush(renk);
                        grafik.FillPolygon(firca, noktalar);
                    }


                }


            }



            catch (Exception)
            {

                throw;
            }



        }




    }
  
    class SekilIsaretle 
    {
        private static string secilenSek = null;
        public static void isretle(MouseEventArgs e, Panel panel1)  
        {
            int bnX = e.X, bnY = e.Y;
            bool icerideMi = false;


            string[] oku = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
            for (int i = 0; i < oku.Length; i++) 
            {

                if ((oku[i].Split(','))[0] == "D")
                {
                    if (bnX > Convert.ToInt16((oku[i].Split(','))[2]) && bnY > Convert.ToInt16((oku[i].Split(','))[3]) && bnX < (Convert.ToInt16((oku[i].Split(','))[4]) + Convert.ToInt16((oku[i].Split(','))[2])) && bnY < ((Convert.ToInt16((oku[i].Split(','))[5]) + Convert.ToInt16((oku[i].Split(','))[3]))))
                    {
                        secilenSek = oku[i];
                        icerideMi = true;
                        Graphics grafik = panel1.CreateGraphics();
                        Pen kalem = new Pen(Color.Gray, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.dosyaOku(panel1);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[2]) - 16, Convert.ToInt16((oku[i].Split(','))[3]) - 16, Convert.ToInt16((oku[i].Split(','))[4]) + 32, Convert.ToInt16((oku[i].Split(','))[5]) + 32);
                    }


                }
                else if ((oku[i].Split(','))[0] == "K")
                {
                    if (bnX > Convert.ToInt16((oku[i].Split(','))[2]) && bnY > Convert.ToInt16((oku[i].Split(','))[3]) && bnX < (Convert.ToInt16((oku[i].Split(','))[6])) && bnY < ((Convert.ToInt16((oku[i].Split(','))[5]))))
                    {
                        secilenSek = oku[i];
                        icerideMi = true;
                        Graphics grafik = panel1.CreateGraphics();
                        Pen kalem = new Pen(Color.Gray, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.dosyaOku(panel1);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[2]) - 16, Convert.ToInt16((oku[i].Split(','))[3]) - 16, Convert.ToInt16((oku[i].Split(','))[8]) - Convert.ToInt16((oku[i].Split(','))[2]) + 32, Convert.ToInt16((oku[i].Split(','))[5]) - Convert.ToInt16((oku[i].Split(','))[3]) + 32);
                    }


                }
                else if ((oku[i].Split(','))[0] == "A")
                {
                    if (bnX > Convert.ToInt16((oku[i].Split(','))[4]) && bnY > Convert.ToInt16((oku[i].Split(','))[3]) && bnX < (Convert.ToInt16((oku[i].Split(','))[10])) && bnY < ((Convert.ToInt16((oku[i].Split(','))[6]))))
                    {
                        secilenSek = oku[i];
                        icerideMi = true;
                        Graphics grafik = panel1.CreateGraphics();
                        Pen kalem = new Pen(Color.Gray, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.dosyaOku(panel1);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[4]) - 16, Convert.ToInt16((oku[i].Split(','))[3]) - 16, Convert.ToInt16((oku[i].Split(','))[10]) - Convert.ToInt16((oku[i].Split(','))[4]) + 32, Convert.ToInt16((oku[i].Split(','))[7]) - Convert.ToInt16((oku[i].Split(','))[13]) + 32);
                    }


                }
                else if ((oku[i].Split(','))[0] == "U")
                {
                    if (bnX > Convert.ToInt16((oku[i].Split(','))[4]) && bnY > Convert.ToInt16((oku[i].Split(','))[3]) && bnX < (Convert.ToInt16((oku[i].Split(','))[6])) && bnY < ((Convert.ToInt16((oku[i].Split(','))[7]))))
                    {
                        secilenSek = oku[i];
                        icerideMi = true;
                        Graphics grafik = panel1.CreateGraphics();
                        Pen kalem = new Pen(Color.Gray, 3);
                        grafik.Clear(Color.Gainsboro);
                        Kaydet.dosyaOku(panel1);
                        grafik.DrawRectangle(kalem, Convert.ToInt16((oku[i].Split(','))[4]) - 16, Convert.ToInt16((oku[i].Split(','))[3]) - 16, Convert.ToInt16((oku[i].Split(','))[6]) - Convert.ToInt16((oku[i].Split(','))[4]) + 32, Convert.ToInt16((oku[i].Split(','))[5]) - Convert.ToInt16((oku[i].Split(','))[3]) + 32);
                    }


                }
            }
        }
 

        public static void sil(Panel panels) 
        {


            if (secilenSek != null)
            {
                try
                {

                    FileStream dosyaYaz;
                    StreamWriter yaz;
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporaryDel.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    string[] geciciOku = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
                    for (int i = 0; i < geciciOku.Length; i++)
                    {
                        if (geciciOku[i] != secilenSek)
                        {
                            yaz.WriteLine(geciciOku[i]);
                        }

                    }
                    yaz.Close();
                    dosyaYaz.Close();
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    yaz.Write(File.ReadAllText(Application.StartupPath.ToString() + "\\temporaryDel.tmp"));

                    yaz.Close();
                    dosyaYaz.Close();
                    Graphics graf = panels.CreateGraphics();
                    graf.Clear(Color.Gainsboro);
                    Kaydet.dosyaOku(panels);

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



        public static void yenidenRenk(string renk, Panel panels) 
        {
            if (secilenSek != null)
            {
                try
                {

                    FileStream dosyaYaz;
                    StreamWriter yaz;
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporaryDel.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    string[] geciciOku = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
                    string[] neu = new string[geciciOku.Length];
                    for (int i = 0; i < geciciOku.Length; i++)
                    {
                        if (geciciOku[i] != secilenSek)
                        {
                            yaz.WriteLine(geciciOku[i]);
                        }
                        else
                        {
                            yaz.WriteLine(geciciOku[i].Replace(geciciOku[i].Split(',')[1], renk));
                        }

                    }
                    yaz.Close();
                    dosyaYaz.Close();
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    yaz.Write(File.ReadAllText(Application.StartupPath.ToString() + "\\temporaryDel.tmp"));

                    yaz.Close();
                    dosyaYaz.Close();
                    Graphics graf = panels.CreateGraphics();
                    graf.Clear(Color.Gainsboro);
                    Kaydet.dosyaOku(panels);

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
        public static void sil1(Panel panels)
        {


           
                try
                {

                    FileStream dosyaYaz;
                    StreamWriter yaz;
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporaryDel.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    string[] geciciOku = File.ReadAllLines(Application.StartupPath.ToString() + "\\temporary.tmp");
                 
                    yaz.Close();
                    dosyaYaz.Close();
                    dosyaYaz = new FileStream(Application.StartupPath.ToString() + "\\temporary.tmp", FileMode.Truncate);
                    yaz = new StreamWriter(dosyaYaz);
                    yaz.Write(File.ReadAllText(Application.StartupPath.ToString() + "\\temporaryDel.tmp"));

                    yaz.Close();
                    dosyaYaz.Close();
                    Graphics graf = panels.CreateGraphics();
                    graf.Clear(Color.Gainsboro);                 
                    Kaydet.dosyaOku(panels);

                }
                catch (Exception)
                {

                    throw;
                }
            
        }


    }
}
