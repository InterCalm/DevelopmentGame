using UnityEngine;
using System.Collections;

public class MainCharacterControl : MonoBehaviour {
	float speed=7.0f;
	int health=3; 
	float DirY;
	float DirX;
	Animator anime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	
		if (Input.GetAxis ("Horizontal") > 0) {
			GetComponent<Animator>().SetFloat("DirX", move.x);
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			flip ();
			GetComponent<Animator>().SetFloat("DirX",move.x);

		}

	}
	void flip(){
	Vector3 theScale = transform.localScale;
	theScale.x *= -1;
	transform.localScale = theScale;
	}
}
