using System;
using System.Collections.Generic;
using System.IO;
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

namespace MechanicsBase
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

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void BtnReadFromFile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // dangerous code goes here. 
                string[] fileLines = File.ReadAllLines
                    ("../../data/toc.txt");
                //MessageBox.Show("It worked");

                //tbOutput.Text = fileLines[8];

                for (int index = 0; index < fileLines.Length; index++)
                {
                    tbOutput.Text = tbOutput.Text + fileLines[index];
                }


            }
            catch (Exception ex)
            {
                // what happens when it fails goes here. 
                MessageBox.Show("It did not work");

            }





        }
    }
}
