using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	
	GameObject mickey;
	// Use this for initialization
	void Start () {
		mickey = GameObject.Find ("Mickey");
	}
	
	// Update is called once per frame
	void Update () {
		float x = mickey.transform.position.x;
		float y = mickey.transform.position.y+1.9f;//bullets and crosshair above Mickey's head
		float z = mickey.transform.position.z;
		if(Input.GetMouseButtonDown(0))
		{
			Vector3 position = new Vector3(x,y,z);
			Quaternion rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
			Instantiate (Resources.Load ("Bullet"), position, rotation);
		}	
		if(Input.GetMouseButtonDown(1))
		{
			Vector3 position = new Vector3(x,y,z);
			Quaternion rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
			Instantiate (Resources.Load ("Cannon Ball"), position, rotation);
		}	
		
		GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
		foreach(GameObject bullet in bullets)
		{
			bullet.transform.Translate(new Vector3(0,0,1f));
		}		
	}
}
