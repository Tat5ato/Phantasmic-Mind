using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float speed = 0.1f;

	private Rigidbody2D rb2d;
	private bool movingHorizontal;
	private bool movingVertical;


	// Use this for initialization
	void Start () {

		//Get and store a reference to the Rigidbody2D component so that we can access it.
		rb2d = GetComponent<Rigidbody2D> ();
		movingHorizontal = true;
		movingVertical = true;

	}

	// Update is called once per frame
	void FixedUpdate () {

		float moveHorizontal = 0;
		float moveVertical = 0;

		//Store the current horizontal input in the float moveHorizontal.

		//#region RegionName
		if (
			Input.GetKeyDown ("up") || Input.GetKeyDown ("w") || Input.GetKeyDown ("down") || Input.GetKeyDown ("s")
			|| Input.GetKeyUp ("right") || Input.GetKeyUp ("a") || Input.GetKeyUp ("left") || Input.GetKeyUp ("d")
		) {
			movingVertical = true;
			movingHorizontal = false;
		}

		if (
			Input.GetKeyDown ("right") || Input.GetKeyDown ("a") || Input.GetKeyDown ("left") || Input.GetKeyDown ("d")
			|| Input.GetKeyUp ("up") || Input.GetKeyUp ("w") || Input.GetKeyUp ("down") || Input.GetKeyUp ("s")
		) {
			movingVertical = false ;
			movingHorizontal = true;
		}
		//#endregion

		if (movingHorizontal) {
			moveHorizontal = Input.GetAxis ("Horizontal");
		}
			
		if (movingVertical) {
			moveVertical = Input.GetAxis ("Vertical");
		}


		//Store movement in a 2d vector
		Vector2 movement = new Vector2(moveHorizontal, moveVertical); 

		//move the player
		rb2d.MovePosition (rb2d.position + movement * speed);
	}

}
