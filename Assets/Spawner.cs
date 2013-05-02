using UnityEngine;
using System.Collections;

/*
 * Joshua Tang
 * Spawns the enemies 
 */
public class Spawner : MonoBehaviour {
	
	public GameObject Enemy;
	
	public int totalEnemy = 3;
    private int numEnemy = 0;
    private int spawnedEnemy = 0;
	
	private bool waveSpawn = true;
    public bool Spawn = true;
    // timed wave controls
    public float waveTimer = 30.0f;
    private float timeTillWave = 0.0f;
    //Wave controls
    public int totalWaves = 5;
    private int numWaves = 0;
	
	private float timePassed = 0;
	public float spawnTime = 0F;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		timePassed += Time.deltaTime;
		
		if(timePassed > spawnTime) {
		
			spawnEnemy();
			if(spawnTime > 1)
				spawnTime -= 0.25F;
			else
				spawnTime = 5F;
			timePassed = 0;
		}
		
	}
	
	private void spawnEnemy() {
		
		Instantiate (Resources.Load ("Monkey"), transform.position, transform.rotation);
		numEnemy++;
		spawnedEnemy++;
	}

}