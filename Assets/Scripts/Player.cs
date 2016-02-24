using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GamerController controller;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		controller.SendMessage ("Damage", 1);
	}
}
