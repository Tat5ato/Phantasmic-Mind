using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float speed = 1;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {

		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Store the current horizontal input in the float moveHorizontal.
		float moveHorizontal = Input.GetAxis ("Horizontal");

		//Store the current vertical input in the float moveVertical.
		float moveVertical = Input.GetAxis ("Vertical");

		//Store movement in a 2d vector
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);

		//move the player
		rb2d.MovePosition (rb2d.position + movement * speed);
	}
		
}
