 using UnityEngine;
using System.Collections;

public class DisneyGUI : MonoBehaviour {

	// Use this for initialization
	private int menux;
	private int menuy;
	public int menuw;
	public int menuh;
	private int optionw;
	private int optionh;
	// note the actual number of options allowed is numoptions-1
	// this is because the menu header is included as an option
	public int numoptions;
	public GameObject go;
	
	public GameObject gm;
	
	void Start () {
	
		numoptions = 5;
		menuw = 100;
		menuh = 200;
		menux = Screen.width/2-menuw/2;
		menuy = Screen.height/2-menuh/2;
		optionh = menuh/numoptions;
		gm = GameObject.FindGameObjectWithTag("GameController");
		
	}
	
	// Update is called once per frame
	void Update () {
	
		
	}
	
	void OnGUI() {
		
		// Make a background box
		GUI.Box(new Rect(menux,menuy,menuw,menuh), "Menu");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(menux+5,menuy+optionh, menuw-10,optionh), "Option 1")) {
			
			gm.SendMessage("startGame");
		}

		// Make the second button.
		if(GUI.Button(new Rect(menux+5,menuy+optionh*2,menuw-10,optionh), "Option 2")) {
			
			go.SendMessage("updateOption", 1);
		}
	}
}
