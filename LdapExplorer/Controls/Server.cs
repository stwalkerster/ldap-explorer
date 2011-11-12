using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LdapExplorer.Controls
{
    public partial class Server : UserControl
    {
        public Server()
        {
            InitializeComponent();

        }

        public string Description { get; set; }
        public string Hostname { get; set; }
        public string BindDN { get; set; }
        public string BindPassword { get; set; }
        public string RootDN { get; set; }
    }
}
