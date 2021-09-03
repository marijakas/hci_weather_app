using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Collections.ObjectModel;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace Projekat1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public List<string> gradoviLista = new List<string>();
        public string selectedName { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string slikaPrognoza { get; set; }
        public string opis { get; set; }
        public int brojDana { get; set; }
        public string selektovaniGrad { get; set; }
        public ObservableCollection<VremeInfoDaily> TabelaVremeDaily { get; set; }
        public ObservableCollection<VremeInfoHourly> TabelaVremeHourly { get; set; }
        public ObservableCollection<VremeInfoCurrent> TabelaVremeCurrent { get; set; }
        public ObservableCollection<double> temperature { get; set; }
        public ObservableCollection<double> vlaznosti { get; set; }
        public ObservableCollection<double> pritisci { get; set; }
        public ObservableCollection<string> imenaGradova { get; set; }
        public ObservableCollection<Grad> Gradovi { get; set; }
        //Moj api kljuc na kastratovic.marija98@gmail.com  ab01183f7aae390bcc762ff24a67c638

        public MainWindow()
        {

            InitializeComponent();
            selectedName = "Novi Sad";
            DataContext = this;
            Gradovi = new ObservableCollection<Grad>();
            temperature = new ObservableCollection<double>();
            vlaznosti = new ObservableCollection<double>();
            pritisci = new ObservableCollection<double>();
            imenaGradova = new ObservableCollection<string>();
            TabelaVremeDaily = new ObservableCollection<VremeInfoDaily>();
            TabelaVremeHourly = new ObservableCollection<VremeInfoHourly>();
            TabelaVremeCurrent = new ObservableCollection<VremeInfoCurrent>();
            //getWeather("Novi Sad");
            dodajGradove();
            //broj dana za prikaz u tabeli
            brojDana = 7;

            foreach (Grad g in Gradovi)
            {
                imenaGradova.Add(g.ime);
            }

        }


        public void dodajGradove()
        {
            Gradovi.Add(new Grad("Novi Sad", 45.2, 19.8, "Srbija"));
            Gradovi.Add(new Grad("Beograd", 44.7, 20.45, "Srbija"));
            Gradovi.Add(new Grad("London", 51.5, -0.11, "UK"));
            Gradovi.Add(new Grad("Phoenix", 33.44, -112.07, "Mexico"));
            Gradovi.Add(new Grad("Tirana", 41.327, 19.819, "Albanija"));
            Gradovi.Add(new Grad("Bec", 48.210033, 16.363449, "Austrija"));
            Gradovi.Add(new Grad("Baku", 40.409264, 49.867092, "Azerbejdzan"));
            Gradovi.Add(new Grad("Minsk", 53.893009, 27.567444, "Belorusija"));
            Gradovi.Add(new Grad("Brisel", 50.85045, 4.34878, "Belgija"));
            Gradovi.Add(new Grad("Sarajevo", 43.856430, 18.413029, "BIH"));
            Gradovi.Add(new Grad("Sofija", 42.698334, 23.319941, "Bugarska"));
            Gradovi.Add(new Grad("Zagreb", 45.815399, 15.966568, "Hrvatska"));
            Gradovi.Add(new Grad("Nikozija", 35.185566, 33.382275, "Kipar"));
            Gradovi.Add(new Grad("Prag", 50.073658, 14.418540, "Češka"));
            Gradovi.Add(new Grad("Kopenhagen", 55.676098, 12.568337, "Danska"));
            Gradovi.Add(new Grad("Pariz", 48.864716, 2.349014, "Francuska"));
            Gradovi.Add(new Grad("Berlin", 52.520008, 13.404954, "Nemačka"));
            Gradovi.Add(new Grad("Atina", 37.983810, 23.727539, "Grčka"));
            Gradovi.Add(new Grad("Budimpešta", 47.497913, 19.040236, "Mađarska"));
            Gradovi.Add(new Grad("Rejkjavik", 64.128288, -21.827774, "Island"));
            Gradovi.Add(new Grad("Dablin", 53.350140, -6.266155, "Irska"));
            Gradovi.Add(new Grad("Rim", 41.902782, 12.496366, "Italija"));
            Gradovi.Add(new Grad("Astana", 51.169392, 71.449074, "Kazahstan"));
            Gradovi.Add(new Grad("Skoplje", 41.99646, 21.43141, "Makedonija"));
            Gradovi.Add(new Grad("Valeta", 35.89972, 14.51472, "Malta"));
            Gradovi.Add(new Grad("Monako", 43.733334, 7.416667, "Monako"));
            Gradovi.Add(new Grad("Podgorica", 42.442574, 19.268646, "Crna Gora"));
            Gradovi.Add(new Grad("Amsterdam", 52.377956, 4.897070, "Holandija"));
            Gradovi.Add(new Grad("Oslo", 59.911491, 10.757933, "Norveška"));
            Gradovi.Add(new Grad("Varšava", 52.237049, 21.017532, "Poljska"));
            Gradovi.Add(new Grad("Lisabon", 38.736946, -9.142685, "Portugalija"));
            Gradovi.Add(new Grad("Bukurešt", 44.439663, 26.096306, "Rumunija"));
            Gradovi.Add(new Grad("Moskva", 55.751244, 37.618423, "Rusija"));
            Gradovi.Add(new Grad("San Marino", 43.93667, 12.44639, "San Marino"));
            Gradovi.Add(new Grad("Bratislava", 48.148598, 17.107748, "Slovačka"));
            Gradovi.Add(new Grad("Ljubljana", 46.056946, 14.505751, "Španija"));
            Gradovi.Add(new Grad("Stokholm", 59.334591, 18.063240, "Švedska"));
            Gradovi.Add(new Grad("Bern", 46.94809, 7.44744, "Švajcarska"));
            Gradovi.Add(new Grad("Ankara", 39.925533, 32.866287, "Turska"));
            Gradovi.Add(new Grad("Kijev", 50.45466, 30.5238, "Ukrajina"));
            Gradovi.Add(new Grad("Vatikan", 41.90236, 12.45332, "Vatikan"));
            Gradovi.Add(new Grad("Jerevan", 40.177200, 44.503490, "Jermenija"));
            Gradovi.Add(new Grad("Talin", 59.436962, 24.753574, "Estonija"));
            Gradovi.Add(new Grad("Helsinki", 60.192059, 24.945831, "Finska"));
            Gradovi.Add(new Grad("Tbilisi", 41.716667, 44.783333, "Gruzija"));
            Gradovi.Add(new Grad("Riga", 56.946285, 24.105078, "Letonija"));
            Gradovi.Add(new Grad("Vaduz", 47.14151, 9.52154, "Lihtenštajn"));
            Gradovi.Add(new Grad("Luksemburg", 49.611622, 6.131935, "Luksemburg"));
            Gradovi.Add(new Grad("Subotica", 46.100376, 19.667587, "Srbija"));
            Gradovi.Add(new Grad("Sombor", 45.77417, 19.11222, "Srbija"));
            Gradovi.Add(new Grad("Kikinda", 45.82972, 20.46528, "Srbija"));
            Gradovi.Add(new Grad("Zrenjanin", 45.38361, 20.38194, "Srbija"));
            Gradovi.Add(new Grad("Niš", 43.32472, 21.90333, "Srbija"));
            Gradovi.Add(new Grad("Kragujevac", 44.01667, 20.91667, "Srbija"));
            Gradovi.Add(new Grad("Kraljevo", 43.72583, 20.68944, "Srbija"));
            Gradovi.Add(new Grad("Valjevo", 44.27513, 19.89821, "Srbija"));
            Gradovi.Add(new Grad("Čačak", 43.89139, 20.34972, "Srbija"));
            Gradovi.Add(new Grad("Leskovac", 42.99806, 21.94611, "Srbija"));
            Gradovi.Add(new Grad("Priština", 42.667542, 21.166191, "Srbija"));
            Gradovi.Add(new Grad("Šabac", 44.74667, 19.69, "Srbija"));
            Gradovi.Add(new Grad("Vranje", 42.55139, 21.90028, "Srbija"));
            Gradovi.Add(new Grad("Pirot", 43.15306, 22.58611, "Srbija"));
            Gradovi.Add(new Grad("Kruševac", 43.58, 21.33389, "Srbija"));
            Gradovi.Add(new Grad("Pančevo", 44.874241, 20.645199, "Srbija"));
            Gradovi.Add(new Grad("Jagodina", 43.97713, 21.26121, "Srbija"));
            Gradovi.Add(new Grad("Novi Pazar", 43.13667, 20.51222, "Srbija"));
            Gradovi.Add(new Grad("Smederevo", 44.66278, 20.93, "Srbija"));
            Gradovi.Add(new Grad("Loznica", 44.5333, 19.2258, "Srbija"));

        }


        public void getWeatherHourly(double lat, double lon)
        {
            List<VremeInfoHourly> pomocna = new List<VremeInfoHourly>();
            List<double> lista = new List<double>();
            List<double> listap = new List<double>();
            List<double> listav = new List<double>();
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&appid=ab01183f7aae390bcc762ff24a67c638&units=metric&cnt=6", lat, lon);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<VremenskaPrognoza.root>(json);

                VremenskaPrognoza.root outPut = result;


                double temp;
                double pressure;
                double humidity;
                long dt;

                foreach (VremenskaPrognoza.hourly x in outPut.hourly)
                {
                    temp = x.temp;
                    pressure = x.pressure;
                    humidity = x.humidity;
                    dt = x.dt;


                    lista.Add(temp); //48 sati bice info o temperaturi
                    listap.Add(pressure);
                    listav.Add(humidity);

                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(dt);
                    string vreme = dateTimeOffset.ToString();

                    pomocna.Add(new VremeInfoHourly(selectedName, temp.ToString() + " \u00B0" + "C", pressure.ToString() + " mbar", humidity.ToString() + "%", vreme.Split()[1]));
                }
                TabelaVremeHourly.Clear();
                for (int i = 0; i < 18; i++)
                {
                    TabelaVremeHourly.Add(pomocna[i]);
                }
                TabelaSati.Visibility = Visibility.Visible;
                labelaDetaljna.Visibility = Visibility.Visible;
                temperature.Clear();
                pritisci.Clear();
                vlaznosti.Clear();
                for (int i = 0; i < 18; i++)
                {
                    temperature.Add(lista[i]); //ovde je samo  za prvih 18 sati info o temperaturi
                    pritisci.Add(listap[i]);
                    vlaznosti.Add(listav[i]);
                }



            }
        }
        public void getWeatherCurrent(double lat, double lon)

        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&appid=ab01183f7aae390bcc762ff24a67c638&units=metric&cnt=6", lat, lon);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<VremenskaPrognoza.root>(json);
                List<string> listai = new List<string>();
                VremenskaPrognoza.root outPut = result;
                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(outPut.current.dt);

                foreach (VremenskaPrognoza.weather w in outPut.current.weather)
                {
                    slikaPrognoza = w.icon + ".png";
                    ImageViewer1.Source = new BitmapImage(new Uri("Slike/" + slikaPrognoza, UriKind.Relative));
                    LabelaTemperatura.Content = outPut.current.temp + " \u00B0" + "C";
                    LabelaOpis.Content = w.description;


                }
                LabelaVlaznost.Content = "Vlaznost vazduha: " + outPut.current.humidity + "%";
                LabelaPritisak.Content = "Vazdusni pritisak: " + outPut.current.pressure + " mbar";
                LabelaOsecaj.Content = "Osecaj: " + outPut.current.feels_like + " \u00B0" + "C";

                string vreme = dateTimeOffset.ToString();
                foreach (VremeInfoCurrent vi in TabelaVremeCurrent)
                {
                    listai.Add(vi.naziv);
                }
                if (!listai.Contains(selectedName))
                {
                    TabelaVremeCurrent.Add(new VremeInfoCurrent(selectedName, outPut.current.temp.ToString() + " \u00B0" + "C", outPut.current.pressure.ToString() + " mb", outPut.current.humidity.ToString() + "%", vreme.Split()[0], outPut.current.visibility.ToString() +"m"));


                }
            }
        }


        public void getWeatherDaily(double lat, double lon, string grad)
        {
            using (WebClient web = new WebClient())
            {

                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&appid=ab01183f7aae390bcc762ff24a67c638&units=metric&cnt=6", lat, lon);
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<VremenskaPrognoza.root>(json);

                VremenskaPrognoza.root outPut = result;

                double temp;
                double tempMax;
                double tempMin;
                double pressure;
                double humidity;
                long dt;

                // TabelaVremeDaily.Clear();
                foreach (VremenskaPrognoza.daily x in outPut.daily)
                {
                    temp = x.temp.day;
                    tempMax = x.temp.max;
                    tempMin = x.temp.min;
                    pressure = x.pressure;
                    humidity = x.humidity;
                    dt = x.dt;

                    foreach (VremenskaPrognoza.weather w in x.weather)
                    {
                        slikaPrognoza = w.icon + ".png";
                        // ImageViewer1.Source = new BitmapImage(new Uri("Slike/" + slikaPrognoza, UriKind.Relative));

                    }
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(dt);
                    string vreme = dateTimeOffset.ToString();
                    //vreme.Split();

                    TabelaVremeDaily.Add(new VremeInfoDaily(grad, temp.ToString() + " \u00B0" + "C", tempMin.ToString() + " \u00B0" + "C", tempMax.ToString() + " \u00B0" + "C", pressure.ToString() + " mb", humidity.ToString() + "%", vreme.Split()[0]));

                }




            }
        }
        private void Dugme_Click(object sender, RoutedEventArgs e)
        {
            listBox.SetBinding(ListBox.SelectedItemProperty, new Binding("selectedName"));
            // be.UpdateSource();

            itemNameTextBox.SetBinding(TextBox.TextProperty, new Binding("brojDana"));
            //be.UpdateSource();

            // Grad nazivGrada = listaGr.SelectedItem as Grad;
            // Console.WriteLine(nazivGrada.naziv);
            //   getWeatherDaily(itemNameTextBox.Text.ToString());
            LabelaGrad.Content = selectedName + ", ";
           foreach (Grad g in Gradovi)
            {
                if (selectedName.Equals(g.ime))
                {


                    if (!gradoviLista.Contains(g.ime))
                    {
                        gradoviLista.Add(g.ime);
                        lon = g.lon;
                        lat = g.lat;

                        LabelaDrzava.Content = g.drzava;

                        getWeatherHourly(lat, lon);
                        getWeatherCurrent(lat, lon);

                    }




                }

            }


        }


        private void setChart(string atribut)
        {
            switch (atribut)
            {
                case "temperatura":
                    {
                        chart_day.Series = new SeriesCollection

            {
            new LineSeries{


                Title = "Temp",
            Values = new ChartValues<double>(temperature)


        }
    }; break;
                    }

                case "vlaznost":
                    {
                        chart_day.Series = new SeriesCollection

            {
            new LineSeries{


                Title = "Temp",
            Values = new ChartValues<double>(vlaznosti)


        }


        
    }; break;
                    }
                case "pritisak":
                    {
                        chart_day.Series = new SeriesCollection

            {
            new LineSeries{


                Title = "Temp",
            Values = new ChartValues<double>(pritisci)


        }
    }; break;
                    }

            }
        }


        public class Grad
        {


            public Grad(string ime, double lat, double lon, string drzava)
            {
                this.ime = ime;
                this.drzava = drzava;
                this.lat = lat;
                this.lon = lon;
            }
            public string drzava { get; set; }
            public string ime { get; set; }
            public double lat { get; set; }
            public double lon { get; set; }
        }

        private void DugmeTemp_Click(object sender, RoutedEventArgs e)
        {
            setChart("temperatura");
            chart_day.Update();




        }

        private void DugmePres_Click(object sender, RoutedEventArgs e)
        {
            setChart("pritisak");
            chart_day.Update();

        }

        private void DugneHum_Click(object sender, RoutedEventArgs e)
        {
            setChart("vlaznost");
            chart_day.Update();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TabelaGlavna_SelectionChanged(object sender, MouseButtonEventArgs e)
        {
            selektovaniGrad = null;
            // IList rows = tabelaGlavna.SelectedItems;
            VremeInfoCurrent rows = (VremeInfoCurrent)tabelaGlavna.SelectedItem;
            if (rows != null)
            {


                selektovaniGrad = rows.naziv;
                LabelaGrad.Content = selektovaniGrad + ", ";
                foreach (Grad g in Gradovi)
                {
                    if (selektovaniGrad.Equals(g.ime))
                    {
                        lon = g.lon;
                        lat = g.lat;
                        LabelaDrzava.Content = g.drzava;
                        TabelaVremeDaily.Clear();
                        getWeatherDaily(lat, lon, selektovaniGrad);
                        getWeatherHourly(lat, lon);
                        getWeatherCurrent(lat, lon);

                    }
                }




                ObservableCollection<VremeInfoDaily> pomocna = new ObservableCollection<VremeInfoDaily>();
                if (brojDana > 7)
                {
                    brojDana = 7;
                }
                for (int i = 0; i < brojDana; i++)
                {
                    pomocna.Add(TabelaVremeDaily[i]);
                }

                Tabelarni t = new Tabelarni(pomocna);
                t.Show();
            }


        }

        private void obrisiGrad(object sender, RoutedEventArgs e) {
            while (tabelaGlavna.SelectedItems.Count > 0) {
                TabelaVremeCurrent.RemoveAt(tabelaGlavna.SelectedIndex);
            }
        }
    }
}
      

