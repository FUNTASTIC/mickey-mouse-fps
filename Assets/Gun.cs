using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	
	
	GameObject crosshair;
	GameObject mickey;
	// Use this for initialization
	void Start () {
		crosshair = GameObject.Find ("Crosshair");
		crosshair.renderer.material.color = Color.red;
		mickey = GameObject.Find ("Mickey");
	}
	
	// Update is called once per frame
	void Update () {
		float x = mickey.transform.position.x;
		float y = mickey.transform.position.y+3;//bullets and crosshair above Mickey's head
		float z = mickey.transform.position.z;
		if(Input.GetMouseButtonDown(0))
		{
			Vector3 position = new Vector3(x,y,z);
			Quaternion rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
			Instantiate (Resources.Load ("Bullet"), position, rotation);
		}	
		//set up crosshair
		crosshair.transform.position = new Vector3(x,y,z);
		crosshair.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
		
		GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
		foreach(GameObject bullet in bullets)
		{
			bullet.transform.Translate(new Vector3(0,0,1f));
		}		
		//this.transform.Translate(new Vector3(Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), 0));
	}
}
