using Sandbox;
using Sandbox.UI;

[Library]
public partial class MainUI : HudEntity<RootPanel>
{
	public MainUI()
	{
		if ( !IsClient )
			return;

		RootPanel.StyleSheet.Load( "/ui/MainUI.scss" );

		RootPanel.AddChild<ChatBox>();
		RootPanel.AddChild<VoiceList>();
		RootPanel.AddChild<VoiceSpeaker>();
		RootPanel.AddChild<MainGame>();
	}
}