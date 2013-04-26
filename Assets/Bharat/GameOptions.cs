using UnityEngine;
using System.Collections;

public class GameOptions : MonoBehaviour {

	// Use this for initialization
	string [] options;
	
	void Start () {
	
		options = new string[] {"1", "2", "3", "E", "F"};

	}
	
	// Update is called once per frame
	void Update () {
	
		
	}
	
	void OnGUI() {
		
		//GUI.Box (new Rect (0,0,100,50), "Top-left");
		//GUI.Box (new Rect (Screen.width - 100,0,100,50), "Top-right");
		//GUI.Box (new Rect (0,Screen.height - 50,100,50), "Bottom-left");

		for(int i = 0; i < options.Length; i++) {
			int x = Screen.width - 100 * (i + 1);
			GUI.Box (new Rect (x,Screen.height-50,100,50), options[i]);
		}
	}
	
	void updateOption(int index) {
	
		options[index] = index + "\n" + "Ray Gun";
	}
	
	void updateOptionColor(int color) {
		
	}
	
}
