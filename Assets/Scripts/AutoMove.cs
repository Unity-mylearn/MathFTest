using UnityEngine;
using System.Collections;

public class AutoMove : MonoBehaviour {

	public float speed = 5.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
	}
}
