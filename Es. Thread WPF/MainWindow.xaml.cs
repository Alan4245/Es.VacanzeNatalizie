using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Threading;

namespace Es.Thread_WPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    /// imgCar.Margin = new Thickness(35, 320, 0, 0);
    /// int posInitAuto = 100;

    public partial class MainWindow : Window
    {

        readonly Uri uriAuto = new Uri("car.png", UriKind.Relative);
        double posInitAuto;
        static int classifica;
        Uri uriLanternaAccesa = new Uri("lampOn.png", UriKind.Relative);
        static ImageSource imgON;

        public MainWindow()
        {
            InitializeComponent();
            ImageSource img = new BitmapImage(uriAuto);
            imgON = new BitmapImage(uriLanternaAccesa);
            posInitAuto = 35;
            classifica = 0;
            imgCar.Source = img;
            Thread t1 = new Thread(new ThreadStart(CaricaLanterne));
            Thread t2 = new Thread(new ThreadStart(CaricaBar));
            Thread t3 = new Thread(new ThreadStart(CaricaCorsaAuto));
            t1.Start();
            t2.Start();
            t3.Start();
        }

        public void CaricaLanterne()
        {

            int caricamento = 0;

            while (caricamento <= 1000)
            {

                caricamento += 2;

                if(caricamento == 200)
                {

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        imgLamp1.Source = imgON;
                    }));

                }
                else if (caricamento == 400)
                {

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        imgLamp2.Source = imgON;
                    }));

                }
                else if (caricamento == 600)
                {

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        imgLamp3.Source = imgON;
                    }));

                }
                else if (caricamento == 800)
                {

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        imgLamp4.Source = imgON;
                    }));

                }
                else if (caricamento == 1000)
                {

                    this.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        imgLamp5.Source = imgON;
                    }));

                }
                Thread.Sleep(TimeSpan.FromMilliseconds(30));
            }

            if(caricamento > 1000)
            {
                DistinguiClassifica(0);
            }

        }

        public void CaricaBar()
        {

            double statoCaricamento = 0;
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                statoCaricamento = pbThread2.Value;
            }));

            do
            {

                statoCaricamento += 2;
                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    pbThread2.Value = statoCaricamento;
                }));
                Thread.Sleep(TimeSpan.FromMilliseconds(30));
            } while (statoCaricamento < 1000);

            if(statoCaricamento >= 1000)
            {
                DistinguiClassifica(1);
            }
            
        }

        public void CaricaCorsaAuto()
        {

            while (posInitAuto < 680)
            {
                posInitAuto += 1.29;

                Thread.Sleep(TimeSpan.FromMilliseconds(30));

                this.Dispatcher.BeginInvoke(new Action(() =>
                {
                    imgCar.Margin = new Thickness(posInitAuto, 320, 0, 0);
                }));
            }

            if(posInitAuto >= 680)
            {
                DistinguiClassifica(2);
            }

        }

        public void DistinguiClassifica(int sender)
        {

            if(sender== 0)
            {
                if (classifica == 0)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento delle lanterne è arrivato 1°");
                }
                else if (classifica == 1)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento delle lanterne è arrivato 2°");
                }
                else if(classifica == 2)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento delle lanterne è arrivato 3°");
                }
                    
            }
            else if (sender == 1)
            {
                if (classifica == 0)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento della barra è arrivato 1°");
                }
                else if (classifica == 1)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento della barra è arrivato 2°");
                }
                else if (classifica == 2)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento della barra è arrivato 3°");
                }

            }
            else if (sender == 2)
            {
                if (classifica == 0)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento dell' auto è arrivato 1°");
                }
                else if (classifica == 1)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento dell' auto è arrivato 2°");
                }
                else if (classifica == 2)
                {
                    classifica++;
                    MessageBox.Show("Il caricamento dell' auto è arrivato 3°");
                }

            }

        }
    }
}
