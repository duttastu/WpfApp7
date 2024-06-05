using Microsoft.Win32;
using System.Windows;

namespace WpfApp7
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

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
/*            fileDialog.Filter = "C# Source Files | *.cs";*/
          /*  fileDialog.InitialDirectory = "C:\\temp";*/  // it open pervious directory
            fileDialog.Title = "Pleace pick CS Source Files"; //it shows title of the folder
            fileDialog.Multiselect = true; //it is used to select mutiple files 

            bool? success=fileDialog.ShowDialog();
            if (success == true) 
            {
                string[]  path= fileDialog.FileNames;
                string[] filename= fileDialog.SafeFileNames;
                /*tbInfo.Text = filename;*/
            }
            else
            {

            }
        }
    }
}