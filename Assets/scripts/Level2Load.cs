using UnityEngine;
using System.Collections;

public class Level2Load : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other){
		Application.LoadLevel("minigameLevelTwo");
	}
}
