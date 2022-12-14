using Sandbox;
using Sandbox.UI.Construct;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

//
// You don't need to put things in a namespace, but it doesn't hurt.
//
namespace Sandbox;

/// <summary>
/// This is your game class. This is an entity that is created serverside when
/// the game starts, and is replicated to the client. 
/// 
/// You can use this to create things like HUDs and declare which player class
/// to use for spawned players.
/// </summary>
public partial class MyGame : Sandbox.Game
{
	public new static Game Current => Sandbox.Game.Current as Game;
	

	//vars n shit
	public MainUI MainUI;


	public MyGame()
	{
		if (IsServer){
			MainUI = new MainUI();
		}
	}

	/// <summary>
	/// A client has joined the server. Make them a pawn to play with
	/// </summary>
	public override void ClientJoined( Client client )
	{
		base.ClientJoined( client );
	}

	//generic commands
	[ConCmd.Client("hellozard")]
	public static void helloZard(){
		Log.Info($"Hello {Local.Client.Name}");
	}
}