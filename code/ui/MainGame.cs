using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class MainGame : Panel
{
    public MainGame()
    {
        StyleSheet.Load("/ui/MainUI.scss");


        var left = Add.Panel("left");
        {
               
        }

        var center = Add.Panel("center");
        {
            var leimage = center.Add.Image("/assets/keyart.png", "leimage");
            leimage.AddEventListener("onClick", (e) => {
            Log.Info("clicked");
        });
        }

        var right = Add.Panel("right");
        {
               
        }
    }

	public override void Tick()//game loop
	{
	}
}