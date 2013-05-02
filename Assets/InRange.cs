using UnityEngine;
using System.Collections;

public class InRange : MonoBehaviour {

	// Use this for initialization
	private bool attack;
	private float timePassed;
	
	void Start () {
	
		attack = false;
		timePassed = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(attack)
			timePassed += Time.deltaTime;
		if(timePassed > 3 && attack) {
			
			GameObject.Find ("GameMaster").SendMessage("hit");
			timePassed = 0F;
		}
	}
	
	void OnTriggerEnter(Collider obj) {
	
		if(obj.CompareTag("Player")) {
			attack = true;
		    timePassed = 0;
			GameObject.Find ("GameMaster").SendMessage("hit");
		}
			
	}
	
	void OnTriggerExit(Collider obj) {
	
		if(obj.CompareTag("Player")) {
		
			attack = false;
			print ("outofrange");
		}
	}
}
