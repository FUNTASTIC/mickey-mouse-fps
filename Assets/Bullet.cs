using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	private float timePassed = 0;
	void Start () {
	
		
	}
	
	// Update is called once per frame
	void Update () {
		
		timePassed += Time.deltaTime;
		if(timePassed > 2)
			GameObject.Destroy(this.gameObject);
	
	}
	
	void OnTriggerEnter (Collider other)
    {
		if(other.name != "Mickey" &&
			other.name != "First Person Controller" &&
			other.tag != "Bullet")
		{
			//Debug.Log ("Hit " + other.name);
		}
		
		if(other.CompareTag("Enemy"))
			GameObject.Destroy(this.gameObject);
	}
}
