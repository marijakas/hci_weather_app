using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projekat1
{
    /// <summary>
    /// Interaction logic for Tabelarni.xaml
    /// </summary>
    public partial class Tabelarni : Window
    {
        public ObservableCollection<VremeInfoDaily> TabelaVremeDaily { get; set; }

        public Tabelarni(ObservableCollection<VremeInfoDaily> tabelaPrvaForma)
        {
            InitializeComponent();
            DataContext = this;
            
            TabelaVremeDaily = tabelaPrvaForma;
          
        }
    }
}
