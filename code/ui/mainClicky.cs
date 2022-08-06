using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class MainClicky : Panel
{
    public MainClicky()
    {
        StyleSheet.Load("/ui/MainUI.scss");

        var center = Add.Panel("center");
        {
            Button btn = center.Add.Button("btn");          
        }
    }    
}