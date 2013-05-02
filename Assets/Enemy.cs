using UnityEngine;
using System.Collections;

// This script is attached to all enemies.
// it keep track of health and kills the enemy
// when no health left
public class Enemy : MonoBehaviour {

	// Use this for initialization
	private int health;
	public GameObject enemy;
	void Start () {
	
		health = 3;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public int GetHealth() {
		return health;
	}
	
	void OnTriggerEnter (Collider obj) {
	
		print (obj.tag);
		if(obj.CompareTag("Bullet")) {
		
			print ("Enemy struck");
			health--;
			if (health == 0) {
				GameObject.Destroy(this.gameObject);
				GameObject.Find("GameMaster").SendMessage("scored");
				if(Random.Range(0, 100) < 30)
					Instantiate (Resources.Load ("littleaudio"), transform.position, transform.rotation);

			}
		}
	}
}
