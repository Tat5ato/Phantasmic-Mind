using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearMachine : MonoBehaviour {
	
	float maxRadius = 15.0f;
	public string Playerfear;
	public string Thunder;



	public Transform player;

	//FOR EXAMPLE ONLY
	public int Damage;
	public int DamageDoubled;
	//------





	//Henry playerInstance = GetComponent<Henry>();

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (gameObject.transform.position, player.transform.position) <= maxRadius) {
			if (gameObject.transform.name == Playerfear) {
				if (gameObject.transform.tag == "Enemy") {
					if (DamageDoubled != (Damage * 2)) {
						DamageDoubled = (Damage * 2);
						Debug.Log ("Damage of Enemy has been doubled");
					}
				}
				//WE NEED A DISTINCT FEAR VALUE IN ORDER TO MODIFY ANYTHING
				Debug.Log ("Fear is increasing...");
			}
		}

}
