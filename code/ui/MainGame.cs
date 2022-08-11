using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class MainGame : Panel
{
    Label currentKeys;
    int _clicks = 0;
    public MainGame()
    {
        StyleSheet.Load("/ui/MainUI.scss");

        var left = Add.Panel("left");
        {
            currentKeys = left.Add.Label("currentKeys", "AmountDisplay");
            {
                currentKeys.Text = "0 keys";
            }       
        }

        var center = Add.Panel("center");
        {

            var mainclicky = center.Add.Image("/assets/keyart.png", "theKey");
            mainclicky.AddEventListener("onMouseDown", (e) => {
                _clicks++;
                Log.Info(_clicks + " clicks");
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
        currentKeys.Text = _clicks + " keys";
	}
}