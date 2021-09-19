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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContentsModel {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            var PersonData = new ObservableCollection<Person>(
                Enumerable.Range(1,100).Select(i => new Person { 
                Name = i+"太郎",
                Age=i+20%50
                })
                );

            this.listBox.ItemsSource = PersonData;
        }
        public ObservableCollection<Person> PersonData;
    }
}
