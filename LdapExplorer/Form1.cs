using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.DirectoryServices;

namespace LdapExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DirectoryEntry d = new DirectoryEntry("LDAP://directory.helpmebot.org.uk");

            DirectorySearcher ds = new DirectorySearcher(d);
            ds.SearchScope = SearchScope.Base;
            ;
            SearchResult rslt = ds.FindOne();
            DirectoryEntry basedn = rslt.GetDirectoryEntry();

            TreeNode basednnode = new TreeNode(basedn.Path);
            basednnode.Tag = new NodeStatus() {entry = basedn};
            basednnode.Nodes.Add(" ");

            treeView1.Nodes.Add(basednnode);
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            NodeStatus status = (NodeStatus) e.Node.Tag;

            if(!status.evaluated)
            {
                node.Nodes.Clear();
                evaluateChildren(status.entry, ref node);
                status.evaluated = true;
            }
        }

        private void evaluateChildren(DirectoryEntry entry, ref TreeNode node)
        {
            throw new NotImplementedException();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
