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
            var currentKeys = left.Add.Label("currentKeys", "AmountDisplay");
            {
                currentKeys.Text = "0 keys";
            }       
        }

        var center = Add.Panel("center");
        {

            var mainclicky = center.Add.Image("/assets/keyart.png", "theKey");
            mainclicky.AddEventListener("onMouseDown", (e) => {
                Log.Info("clicked");
                mainclicky.SetTexture("/assets/keyartsmall.png");
            });
            mainclicky.AddEventListener("onMouseUp",(e) => {
                Log.Info("mouse up");
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