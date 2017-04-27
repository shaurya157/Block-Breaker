using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	private LevelManager levelmanager;
	
	void OnTriggerEnter2D(Collider2D trigger){
		levelmanager = GameObject.FindObjectOfType<LevelManager>();
		levelmanager.LoadLevel("lose");
	}
	
//	void OnCollisionEnter2D(Collision2D collider){
//		print (collider);
//		print ("collided!");
//	}

//	void Awake(){
//		levelmanager = GameObject.FindObjectOfType<LevelManager>();
//	}
}
