using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	int x;
	// Use this for initialization
	public  void Quit() {
		Application.Quit();
	}
	public void Restart_Game() {
		Application.LoadLevel("maze_1");
		// Change to main menu after main menu is made
	}
	public  void Restart_Level() {
		x = Application.loadedLevel;
			Application.LoadLevel(x);
	}

}
