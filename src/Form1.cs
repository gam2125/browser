using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace SharpBrowser



{
    public partial class Form1 : Form




    {

        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {
            Cef.Initialize(new CefSettings());
           // browser = new ChromiumWebBrowser("www.google.com");
            browser = new ChromiumWebBrowser("www.clarin.com");
            this.Controls.Add(browser);
           // browser.Dock = DockStyle.Fill;
           browser.Dock = DockStyle.Fill  ;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitBrowser();
         //browser.Load("www.lanacion.com");
        }
        
    }
}
