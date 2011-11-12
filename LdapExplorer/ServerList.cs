using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LdapExplorer.Controls;

namespace LdapExplorer
{
    public partial class ServerList : Form
    {
        public ServerList()
        {
            InitializeComponent();
        }

        private void ServerList_Load(object sender, EventArgs e)
        {
            foreach (Server item in Properties.Settings.Default.ServerList) 
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }
    }
}
