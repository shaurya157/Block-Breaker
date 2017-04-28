using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	private int timesHit;
	private LevelManager levelManager;
	public Sprite[] hitSprite;
	
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter2D(Collision2D collider){
		timesHit++;
		int maxHits = hitSprite.Length + 1;
		if(timesHit >= maxHits){
			Destroy(gameObject);
		} else {
			LoadSprites();
		}
	}
	
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprite[spriteIndex];
	}
	
	void SimulateWin(){
		levelManager.LoadNextLevel();
	}
}
