using UnityEngine;
using System.Collections;

public class TimeKill : MonoBehaviour {
	public float duration = 5F;
	float createdTime;
	// Use this for initialization
	void Start () {
		createdTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > createdTime + duration) {
			GameObject.Destroy(this.gameObject);
		}
	}
}
