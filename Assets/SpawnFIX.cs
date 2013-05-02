using UnityEngine;
using System.Collections;

public class SpawnFIX : MonoBehaviour {
	Vector3[] spawns;
	public float FIXSpawnRate = 5.0F;
	private float elapsedTime;
	// Use this for initialization
	void Start () {
		spawns = new Vector3[] {new Vector3(0f, -6.99f, -30f), new Vector3(-8f, -2.5f, 8.5f), new Vector3(0f, -9.5f, -74.5f)};
		elapsedTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		if (elapsedTime > FIXSpawnRate) {
			Spawn();
			elapsedTime = 0;
		}
	}
	
	void Spawn() {
		int spawnLocation = Random.Range(0,3);
		
		GameObject[] fixes = GameObject.FindGameObjectsWithTag("FIX");
		bool spawnHere = true;
		foreach (GameObject fix in fixes) {
			if (fix.transform.position.Equals(spawns[spawnLocation])) {
				spawnHere = false;
			}
		}
		print ("SPAWN " + spawnHere);
		if (spawnHere)
			GameObject.Instantiate(Resources.Load("FIX"), spawns[spawnLocation], new Quaternion(0,0,0,0));
	}
}
