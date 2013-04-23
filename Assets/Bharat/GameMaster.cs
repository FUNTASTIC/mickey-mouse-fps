using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

	//GameObject player = Instantiate(playerPrefab, new Vector3(-20,-2,0), Quaternion.identity) as GameObject;
	// Use this for initialization
	public GameObject gui;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void startGame() {
	
		print ("Starting the game...");
		gui.SetActive(false);
	}
	
}
