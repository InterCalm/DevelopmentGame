using UnityEngine;
using System.Collections;

public class MainCharacterControl : MonoBehaviour {
	float speed=1.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var move = Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	}
	}

