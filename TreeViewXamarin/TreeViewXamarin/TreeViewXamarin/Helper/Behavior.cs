using Syncfusion.TreeView.Engine;
using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class Behavior : Behavior<SfTreeView>
    {
        SfTreeView treeView;
        protected override void OnAttachedTo(SfTreeView bindable)
        {
            treeView = bindable;
            treeView.Loaded += TreeView_Loaded;
            treeView.CollapseAll();
            base.OnAttachedTo(bindable);
        }
        private void TreeView_Loaded(object sender, Syncfusion.XForms.TreeView.TreeViewLoadedEventArgs e)
        {
            int TotalNodes = treeView.Nodes.Count();
            for (int i = 0; i < TotalNodes; i++)
            {
                TreeViewNode node = treeView.Nodes[i];
                var content = (node.Content as Folder).FileName;
                if (content.ToString() == "Downloads")
                {
                    treeView.ExpandNode(node);
                }
            }
        }
        protected override void OnDetachingFrom(SfTreeView bindable)
        {
            treeView.Loaded -= TreeView_Loaded;
            base.OnDetachingFrom(bindable);
        }
    }
}
