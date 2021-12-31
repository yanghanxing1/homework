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
using System.Xml;
using System.IO;
using System.Xml.XPath;
using Microsoft.Win32; 
using XpathHelp;


namespace XpathSample
{
   
    public partial class MainWindow : Window
    {
       
        private OpenFileDialog dlgopen;       
        private XpathHelper xp;
        public MainWindow()
        {
            InitializeComponent();           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
            xp = new XpathHelper( @"Journals.xml");
            txtxml.Text = xp.doc.InnerXml;
            btnxpathnavigator.IsEnabled = true;                    
        }       

        private void btnOpenxml_Click(object sender, RoutedEventArgs e)
        {
            dlgopen = new Microsoft.Win32.OpenFileDialog();
            dlgopen.DefaultExt = ".xml";
            dlgopen.Filter = "Text documents (.xml)|*.xml|All files (*.*)|*.*" ;
            if (dlgopen.ShowDialog() == true)
            {
                xp = new XpathHelper(dlgopen.FileName);
                txtxml.Text = xp.doc.InnerXml;              
                btnxpathnavigator.IsEnabled = true;
            } 
        }

        private void btnxpathnavigator_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtqueryxpath.Text)) return;
            txtresultxpath.Clear();
            txtresultxpath.Text = (xp.XpathQuery(txtqueryxpath.Text)).ToString();   
        }

      
       
    }
}
