using System;
using System.Collections.Generic;
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
using System.Net;
using System.IO;
using Newtonsoft.Json;
using GetBookingValues.Models;
using GetBookingValues.Controllers;
using System.Web;




namespace WPFT_Training
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
 
    public partial class MainWindow : Window
    {
     
        public MainWindow()
        {
            InitializeComponent();

           
            
                
            
        }

        private void loadButton_Click(object sender, RoutedEventArgs e)
        {
            List<ListElements> test = ListElementsController.GetListElements();

            dataGrid1.ItemsSource = test;
        }
    }
    
}
