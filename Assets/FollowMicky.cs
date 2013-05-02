using UnityEngine;
using System.Collections;

public class FollowMicky : MonoBehaviour {

	// Use this for initialization
	public GameObject micky;
	public float inc;
	void Start () {
	
		inc = 0.025F;
		micky = GameObject.Find ("Mickey");
	}
	
	// Update is called once per frame
	void Update () {
	
		var position = transform.position;
		var goal = micky.transform.position;
		
		if(position.x < goal.x - 2)
			position.x += inc;
		if(position.x > goal.x + 2)
			position.x -= inc;
		
		if(position.z < goal.z - 2)
			position.z += inc;
		if(position.z > goal.z + 2)
			position.z -= inc;
		
		transform.position = position;
	}
}
