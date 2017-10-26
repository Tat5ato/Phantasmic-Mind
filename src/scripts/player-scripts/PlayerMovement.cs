using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float speed = 0.1f;

	private Rigidbody2D rb2d;

	private bool movingUp;
	private bool movingDown;
	private bool movingLeft;
	private bool movingRight;


	// Use this for initialization
	void Start () {

		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();

		movingUp = true;
		movingDown = true;
		movingLeft = true;
		movingRight = true;

	}

	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = 0;
		float moveVertical = 0;


		//Checks to see if moving up
		if (Input.GetKeyDown ("up") || Input.GetKeyDown ("w")
			|| ((Input.GetKeyUp ("right") || Input.GetKeyUp ("d") || Input.GetKeyUp ("left") || Input.GetKeyUp ("a") || Input.GetKeyUp ("down") || Input.GetKeyUp ("s")) 
				&& (Input.GetKey ("up") || Input.GetKey ("w")))) {
			movingUp = true;
			movingDown = false;
			movingLeft = false;
			movingRight = false;
		}

		//Checks to see if moving down
		if (Input.GetKeyDown ("down") || Input.GetKeyDown ("s")
			|| ((Input.GetKeyUp ("right") || Input.GetKeyUp ("d") || Input.GetKeyUp ("left") || Input.GetKeyUp ("a") || Input.GetKeyUp ("up") || Input.GetKeyUp ("w")) 
				&& (Input.GetKey ("down") || Input.GetKey ("s")))) {
			movingUp = false;
			movingDown = true;
			movingLeft = false;
			movingRight = false;
		}

		//Checks to see if moving left
		if (Input.GetKeyDown ("left") || Input.GetKeyDown ("a")
			|| ((Input.GetKeyUp ("right") || Input.GetKeyUp ("d") || Input.GetKeyUp ("up") || Input.GetKeyUp ("w") || Input.GetKeyUp ("down") || Input.GetKeyUp ("s")) 
				&& (Input.GetKey ("left") || Input.GetKey ("a")))) {
			movingUp = false;
			movingDown = false;
			movingLeft = true;
			movingRight = false;
		}

		//Checks to see if moving right
		if (Input.GetKeyDown ("right") || Input.GetKeyDown ("d")
			|| ((Input.GetKeyUp ("left") || Input.GetKeyUp ("a") || Input.GetKeyUp ("up") || Input.GetKeyUp ("w") || Input.GetKeyUp ("down") || Input.GetKeyUp ("s")) 
				&& (Input.GetKey ("right") || Input.GetKey ("d")))) {
			movingUp = false;
			movingDown = false;
			movingLeft = false;
			movingRight = true;
		}


		if (movingLeft || movingRight) {
			moveHorizontal = Input.GetAxis ("Horizontal");
		}

		if (movingUp || movingDown) {
			moveVertical = Input.GetAxis ("Vertical");
		} 


		//Store movement in a 2d vector
		Vector2 movement = new Vector2(moveHorizontal, moveVertical); 

		//move the player
		rb2d.MovePosition (rb2d.position + movement * speed);
	}

}
