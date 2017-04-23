using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	
	void Awake (){
		if (instance){
			Destroy (gameObject);
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(this);
		}
	}
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
