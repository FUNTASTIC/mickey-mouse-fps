using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	//GameObject player = Instantiate(playerPrefab, new Vector3(-20,-2,0), Quaternion.identity) as GameObject;
	// Use this for initialization
	public GameObject gui;
	public GameObject vengeance_audio;
	public GameObject mickey;
	public GameObject spawn1;
	public GameObject spawn2;
	private int health = 10;
	private int score = 0;
	private float timePassed;
	private bool loose = false;
	
	void Start () {
	
		// mickey.GetComponent<FPSInputController>().enabled = false;
		timePassed = 0;
		spawn1.SetActive(false);
		spawn2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
		timePassed += Time.deltaTime;
		if(health < 10 && timePassed > 5) {
		
			timePassed = 0;
			health++;
		}
	}
	
	public void startGame() {
	
		print ("Starting the game...");
		gui.SetActive(false);
		mickey.SetActive(true);
		spawn1.SetActive (true);
		spawn2.SetActive (true);
		Instantiate (Resources.Load ("vengeance_audio"), transform.position, transform.rotation);
	}
	
	public void hit() {
	
		print ("Micky was hit");
		
		if(health == 0) {  
			mickey.SetActive(false);
			spawn1.SetActive(false);
			spawn2.SetActive(false);
			loose = true;
			GameObject[] monkeys = GameObject.FindGameObjectsWithTag("Enemy");
			foreach(GameObject monkey in monkeys)
			{
				GameObject.Destroy(monkey);
			}
		}
		else
			health -= 1;
	}
	
	public void scored() {
	
		score += 10;
	}
	
	void OnGUI() {
		GameObject m = GameObject.Find("Mickey");
		if (m != null)
			((FixMeter)m.GetComponent("FixMeter")).DrawFIXBar();
		
		GUI.Box (new Rect (0,0,100,50), "Score: "+ score);
		//GUI.Box (new Rect (Screen.width - 100,0,100,50), "Top-right");
		//GUI.Box (new Rect (0,Screen.height - 50,100,50), "Bottom-left");
		
		GUI.Box (new Rect (0,Screen.height-50,100,50), "Health: " + health);
		
		if(loose) {
		
			GUI.Box(new Rect (Screen.width/2, Screen.height/2, 100, 50), "Game Over!");
		}
	
	}
	
}
