using UnityEngine;
using System.Collections;

public class Bullet_Impact : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider col) {
		if (col.tag == "Enemy") {
			GameObject.Instantiate(Resources.Load("Magic_Hit"), this.transform.position, this.transform.rotation);
			
			GameObject.Instantiate(Resources.Load("Blood"), this.transform.position, this.transform.rotation);
			// if hits enemy and they die, create explosion
			if (col.tag == "Enemy" && ((Enemy)col.GetComponent("Enemy")).GetHealth() < 1) {
				// if it is a large enemy create a large explosion, else create normal explosion
				if (false/*col.GetComponent("AI").isLarge()*/) {
					GameObject.Instantiate(Resources.Load ("LargeEnemyDie"), this.transform.position, this.transform.rotation);
				}
				else {
					GameObject.Instantiate(Resources.Load ("NormalEnemyDie"), this.transform.position, this.transform.rotation);
				}
			}
		}
	}
}
