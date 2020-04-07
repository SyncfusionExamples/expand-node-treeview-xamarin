# How to expand the particular node in Xamarin.Forms TreeView (SfTreeView)

You can expand the particular [TreeView](https://help.syncfusion.com/xamarin/treeview/overview?) node in Xamarin.Forms using [ExpandNode](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.SfTreeView~ExpandNode.html?) method.

You can also refer the following article.

https://www.syncfusion.com/kb/11361/how-to-expand-the-particular-treeview-node-in-xamarin-forms-sftreeview 

**C#**

TreeView node **Downloads** is expanded when the TreeView is loaded.

``` c#
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
```
