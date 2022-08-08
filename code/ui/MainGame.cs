using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class MainGame : Panel
{
    public MainGame()
    {
        StyleSheet.Load("/ui/MainUI.scss");

        int clicks = 0;

        var left = Add.Panel("left");
        {
            var currentKeys = left.Add.Label("currentKeys", "AmountDisplay");
            {
                currentKeys.Text = "0 keys";
            }       
        }

        var center = Add.Panel("center");
        {

            var mainclicky = center.Add.Image("/assets/keyart.png", "theKey");
            mainclicky.AddEventListener("onMouseDown", (e) => {
                clicks++;
                Log.Info(clicks + " clicks");
                mainclicky.SetTexture("/assets/keyartsmall.png");
            });
            mainclicky.AddEventListener("onMouseUp",(e) => {
                mainclicky.SetTexture("/assets/keyart.png");
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