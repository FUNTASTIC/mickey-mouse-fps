using UnityEngine;
using System.Collections;

public class FixMeter : MonoBehaviour {
	public float FIXDropRate = 1.0F;
	public int MaxFIX = 30;
	private int currentFIX = 20;
	private Vector2 location;
	private Vector2 size;
	private float progress = 10F;	
	private Texture progressBackground;
	private Texture progressForeground;
	private float elapsedTime;
	
	// Use this for initialization
	void Start () {
		location = new Vector2(10F,50F);
		size = new Vector2(220F, 20F);
		elapsedTime = 0;
		//progressBackground = (Texture)Resources.Load("progressBackground");
		//progressForeground = (Texture)Resources.Load("progressForeground");
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		if (elapsedTime > FIXDropRate) {
			currentFIX -= 1;
			elapsedTime = 0;
		}
		if (currentFIX <= 0) {
			print("DEATH!!!");
		}
	}
	
	public void GetMyFixOn(int fixAmount) {
		currentFIX += fixAmount;
		if (currentFIX > MaxFIX)
			currentFIX = MaxFIX;
	}
	
	public void DrawFIXBar() {
		string progressBars = "";
		for (int i = 0; i < currentFIX; i++) {
			progressBars = progressBars + " |";
		}
		string meter = "FIX: " + progressBars;
		GUI.Label(new Rect(location.x,location.y,size.x,size.y), meter);
	}
}
