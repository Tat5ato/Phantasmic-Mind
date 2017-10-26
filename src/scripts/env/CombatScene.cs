using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class CombatScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
//Change listed varibles to actual varibles 
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "player")
			UnityEngine.SceneManagement.SceneManager.LoadScene("combatScene");
	}
}


