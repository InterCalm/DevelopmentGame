using UnityEngine;
using System.Collections;

public class MainCharacterControl : MonoBehaviour {
	float speed=7.0f;
	int health=3; 
	float DirY;
	float DirX;
	Animator anime;
	bool attack=false;
	bool characterFacingRight=true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	

		if (Input.GetAxis("Horizontal") > 0 && !characterFacingRight) 
		{
			flip();
		} 
		else if (Input.GetAxis ("Horizontal") < 0 && characterFacingRight) 
		{
			flip();
		}
		if (Input.GetAxis ("Horizontal") > 0) {
			GetComponent<Animator>().SetFloat("DirX", move.x);
		}
	}
	void flip(){
		// Set Character Facing Direction To Opposite or False
		characterFacingRight = !characterFacingRight;
		Vector3 currentScale = transform.localScale;
		// Multiply Current Scale By Negative To Flip Direction
		currentScale.x *= -1;
		transform.localScale = currentScale;
	}
}
