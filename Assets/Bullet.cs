//Joshua Schwarz (jjs209)
//Bullet.cs
//Mickey FPS

using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	private float timePassed = 0;
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		//Bullet dies after a short time if it doesn't hit an enemy
		timePassed += Time.deltaTime;
		if(timePassed > 2)
			GameObject.Destroy(this.gameObject);
	
	}
	
	void OnTriggerEnter (Collider other)
    {
		if(other.CompareTag("Enemy"))
			GameObject.Destroy(this.gameObject);
	}
}
