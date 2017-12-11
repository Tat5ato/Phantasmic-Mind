using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearMachine : MonoBehaviour {
	/*
	public Transform Spider;
	public Transform Water;
	public Transform Blood;
	public Transform Quadrupeds; // 4-Limbed Animals
	public Transform Doll;
	public Transform Thunder;
	public Transform Ghosts;
	public Transform Clowns;
	public Transform Holes;
*/
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
	// Fear of Spiders
	public void Arachnophobia () 
	{ 

    }
	public void Acrophobia () { // Fear of Heights

	}
	public void Aquaphobia () { // Fear of Water and Aquatic Things

	}
	public void Hemophobia () { // Fear of Blood

	}
	public void Zoophobia () { // Fear of 4-limbed animals

	}
	public void Pediophobia () { // Fear of Dolls

	}
	public void Astraphobia () { // Fear of Thunder/Lightning

	}
	public void Spectrophobia () { // Fear of Ghosts

	}
	public void Coulrophobia () { // Fear of Clowns

	}
	public void Trypophobia () { //Fear of Holes

	}

}
