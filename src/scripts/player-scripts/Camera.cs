using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	[SerializeField]
	GameObject player; //main character being followed
	
	[SerializeField]
	private Vector2 startPosition = new Vector2 (0 ,0); //where the camera starts, could be cahnaged to vector3 if necissary

	private Vector3 offset; // camera distance from player, it is constant

	//Camera's z distance from player
	private float zoom = -10;

	/** Start is called at initialization */
	void Start () {
		
		transform.position = new Vector3 (startPosition.x, startPosition.y, zoom); //set the start position of the camera
			
		offset = player.transform.position - transform.position; //measure player distance from camera

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = player.transform.position - offset; //follow the player with a constant frame of reference

	}
}
