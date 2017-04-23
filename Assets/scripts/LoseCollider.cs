using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {
	
	public LevelManager levelmanager;
	
	void OnTriggerEnter2D(Collider2D trigger){
		levelmanager.LoadLevel("lose");
	}
	
	void OnCollisionEnter2D(Collision2D collider){
		print (collider);
		print ("collided!");
	}
}
