using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Windows_Version_Edition
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string strOSInfo =
            "Operating system: " + OSInfo.Bits.ToString() + " bits" + Environment.NewLine +
            "Build version: " + OSInfo.BuildVersion.ToString() + Environment.NewLine +
            "Edition: " + OSInfo.Edition.ToString() + Environment.NewLine +
            "Major Version: " + OSInfo.MajorVersion.ToString() + Environment.NewLine +
            "Minor Version: " + OSInfo.MinorVersion.ToString() + Environment.NewLine +
            "Name: " + OSInfo.Name + Environment.NewLine +
            "Revision Version: " + OSInfo.RevisionVersion.ToString() + Environment.NewLine +
            "Service pack: " + OSInfo.ServicePack + Environment.NewLine +
            "Version: " + OSInfo.VersionString;
            txtbOSInfo.Text = strOSInfo;
        }
    }
}
