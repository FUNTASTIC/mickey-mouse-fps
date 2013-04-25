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
		if(Input.GetMouseButtonDown(0))
		{
			Vector3 position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
			Quaternion rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
			Instantiate (Resources.Load ("Bullet"), position, rotation);
		}	
		//set up crosshair
		crosshair.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
		crosshair.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
		crosshair.transform.Translate(new Vector3(0f,0f,5f));
		//set up mickey
		mickey.transform.position = new Vector3(transform.position.x, transform.position.y-.5f, transform.position.z);
		mickey.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
		mickey.transform.Translate(new Vector3(0f,0f,.5f));
		
		GameObject[] bullets = GameObject.FindGameObjectsWithTag("Bullet");
		foreach(GameObject bullet in bullets)
		{
			bullet.transform.Translate(new Vector3(0,0,1f));
		}		
		//this.transform.Translate(new Vector3(Input.GetAxis ("Mouse X"), Input.GetAxis ("Mouse Y"), 0));
	}
}
