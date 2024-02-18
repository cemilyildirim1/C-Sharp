using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.Platform;

namespace deneme3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OpenGlControl1.InitializeContexts();
            Gl.glClearColor(0, 0, 1, 0);                //arka planı mavi yapma
            Gl.glOrtho(-12, 12, -12, 12, -1, 1);        //kordinat (uzayında) düzleminde x ve y için (-12,12) ölçeklendirme.

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glMatrixMode(Gl.GL_MODELVIEW);

        }

        private void OpenGlControl1_Load(object sender, EventArgs e)
        {

        }
        private void eksen()        //eksen çizgilerini oluşturmak için metod oluşturma
        {

            Gl.glColor3f(1, 1, 1);


            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2f(-12, 0);          // x için eksen çizgileri
            Gl.glVertex2f(12, 0);

            Gl.glVertex2f(0, -12);          //y için eksen çizgileri
            Gl.glVertex2f(0, 12);

            // eksen çizgileri
            for (int i = 1; i <= 12; i++)
            {
                //x pozitif bölge ekseni çizgileri
                Gl.glVertex2f(i * 1, 0.4f);
                Gl.glVertex2f(i * 1, -0.4f);
                //x negatif bölge ekseni çizgileri
                Gl.glVertex2f(i * -1, 0.4f);
                Gl.glVertex2f(i * -1, -0.4f);
                //y pozitif bölge ekseni çizgileri
                Gl.glVertex2f(0.2f, i * 1);
                Gl.glVertex2f(-0.2f, i * 1);
                //y negatif bölge ekseni çizgileri
                Gl.glVertex2f(0.2f, i * -1);
                Gl.glVertex2f(-0.2f, i * -1);

            }

            Gl.glEnd();



        }
        private void ucgen()                //belirtilen noktalarda oluşturulan üçgen 
        {

            Gl.glColor3f(1, 0, 0);
            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glVertex3f(6, 2, 1);
            Gl.glVertex3f(9, 2, 1);
            Gl.glVertex3f(6, 4, 1);

            Gl.glEnd();
        }


        private void nokta_P_10_10()       //P(10,10) noktasında bulunan nokta
        {

            Gl.glPointSize(5.0f);
            Gl.glColor3d(0, 0, 0);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(10, 10);
            Gl.glEnd();

        }

        private void DAİRE_P_10_10()      //P(10,10) noktasında bulunan dairesel cisim
        {
            int kenarSayisi = 50;


            Gl.glColor3d(1, 1, 0);
            Gl.glBegin(Gl.GL_POLYGON);
            for (int i = 0; i < kenarSayisi; i++)   //dairesel cisim için tekrar eden çizgiler
            {
                float donme_acisi = 2.0f * (float)Math.PI * i / kenarSayisi;  // dönme açısını ayarlama
                float x = (float)Math.Cos(donme_acisi) * 0.6f + 10;
                float y = (float)Math.Sin(donme_acisi) * 0.6f + 10;
                Gl.glVertex2f(x, y);                //for döngüsü boyunca ekrana çizgi çeker
            }

            Gl.glEnd();

        }

        //MATRİS ÇARPIMI İLE DÖNDÜRME SONUCUNU BULMA

        //X'(cisim_nokta)  =   X(CisimNokta) * T(ötele) * T(dödür) * T-1(ötele)


        public void dondurme_oteleme()
        {

            //X(CisimNokta) matrisi tanımlama
            double[,] cisimMatris = {
                    { 6, 2, 1 },
                    { 9, 2, 1 },
                    { 6, 4, 1 }
                };
            //T(ötele) matrisini tanımlama
            double[,] T_otele ={
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { -10, -10, 1 }
                };
            //T(dödür) matrisini tanımlama
            double[,] T_dondur ={
                    { Math.Cos(70), -Math.Sin(70), 0 },
                    { Math.Sin(70), Math.Cos(70) , 0 },
                    { 0           , 0            , 1 }
                };
            //T-1 (ötele) matrisini tanımlama
            double[,] T_ters_otele ={
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 10, 10, 1 }
                };

            //1. çarpım 
            // X(CisimNokta) * T(ötele)

            double[,] carpim1_matrisi = new double[3, 3];
            for (int i = 0; i < 3; i++)                     //matris çarpımı için for döngüsü
            {
                for (int j = 0; j < 3; j++)
                {
                    carpim1_matrisi[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        carpim1_matrisi[i, j] += cisimMatris[i, k] * T_otele[k, j];
                    }
                }
            }


            Console.WriteLine("1. ve 2. matrisin Matris Çarpımı Sonucu:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(carpim1_matrisi[i, j] + "\t");

                }
                Console.WriteLine();

            }

            //2. çarpım 
            // Çıkan sonucu (carpim1_matrisi) T(dödür) ile çarpma

            double[,] carpim2_matrisi = new double[3, 3];
            for (int i = 0; i < 3; i++)                     //matris çarpımı için for döngüsü
            {
                for (int j = 0; j < 3; j++)
                {
                    carpim2_matrisi[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        carpim2_matrisi[i, j] += carpim1_matrisi[i, k] * T_dondur[k, j];
                    }
                }
            }
            Console.WriteLine("1. ve 2. matrisin Matris Çarpımı Sonucu:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(carpim2_matrisi[i, j] + "\t");

                }
                Console.WriteLine();

            }

            //3. çarpım 
            // Çıkan sonucu (carpim2_matrisi) T-1(ötele) ile çarpma

            double[,] carpim3_matrisi = new double[3, 3];
            for (int i = 0; i < 3; i++)                     //matris çarpımı için for döngüsü
            {
                for (int j = 0; j < 3; j++)
                {
                    carpim3_matrisi[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        carpim3_matrisi[i, j] += carpim2_matrisi[i, k] * T_ters_otele[k, j];
                    }
                }
            }
            Console.WriteLine(" carpim2 matrisin T-1 (ötele) ile Matris Çarpımı Sonucu:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(carpim3_matrisi[i, j] + "\t");

                }
                Console.WriteLine();

            }



            // döndürülen matrisin oluşturulması
            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glVertex3f(
            (float)carpim3_matrisi[0, 0],
            (float)carpim3_matrisi[0, 1],
            (float)carpim3_matrisi[0, 2]);
            Gl.glVertex3f(
            (float)carpim3_matrisi[1, 0],
            (float)carpim3_matrisi[1, 1],
            (float)carpim3_matrisi[2, 2]);
            Gl.glVertex3f(
            (float)carpim3_matrisi[2, 0],
            (float)carpim3_matrisi[2, 1],
            (float)carpim3_matrisi[2, 2]);

            Gl.glEnd();




            // DÖNDÜRDÜKTEN SONRA ÖTELEME İŞLEMİ YAPIMI
            //X'(cisim_nokta)  =   X(CisimNokta) * T(ötele) 

            //Bu aşamada döndürdüğümüz cismin matrisini (carpim3_matrisi) kullanıcaz.
            //X(CisimNokta) = carpim3_matrisi    


            //T_otele_2  matrisi tanımlama
            double[,] T_otele_2 = {
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, -12, 1 }
                };


            //Dödürdükten sonraki öteleme işlemi için matris çarpımı
            //X(CisimNokta) *   T(ötele)

            /*    ||              ||
                  \/              \/         */

            //carpim3_matrisi * T_otele_2
            double[,] otelenen_matris = new double[3, 3];
            for (int i = 0; i < 3; i++)                       //matris çarpımı için for döngüsü
            {
                for (int j = 0; j < 3; j++)
                {
                    otelenen_matris[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        otelenen_matris[i, j] += carpim3_matrisi[i, k] * T_otele_2[k, j];
                    }
                }
            }
            Console.WriteLine(" OTELEME Sonucu:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(otelenen_matris[i, j] + "\t");

                }
                Console.WriteLine();

            }

            //otelenen matrisin oluşturulması
            Gl.glColor3f(1, 1, 0);
            Gl.glBegin(Gl.GL_TRIANGLES);


            Gl.glVertex3f(
                (float)otelenen_matris[0, 0],
                (float)otelenen_matris[0, 1],
                (float)otelenen_matris[0, 2]);
            Gl.glVertex3f(
                (float)otelenen_matris[1, 0],
                (float)otelenen_matris[1, 1],
                (float)otelenen_matris[2, 2]);
            Gl.glVertex3f(
                (float)otelenen_matris[2, 0],
                (float)otelenen_matris[2, 1],
                (float)otelenen_matris[2, 2]);

            Gl.glEnd();



        }


        private void MyPaint(object sender, PaintEventArgs e)
        {
            // oluşturulan metodların sırayla çağrılması

            eksen();

            ucgen();
            //nokta_P_10_10(); // nokta şeklinde P(10,10) (isteğe bağlı)

            DAİRE_P_10_10();   // daire şeklinde P(10,10) (isteğe bağlı)

            dondurme_oteleme();




        }
    }
}
