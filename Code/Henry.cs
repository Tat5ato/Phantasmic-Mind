//all public vars to be changed for game.

//add call real enemy HP to enemyTestHP in update for full game

//add call real health to HP in update for full game

//this script is to be put on Henry to act as the main value holder





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henry : MonoBehaviour{

	// ADD - Check if item is in inventory

	// Variables
	public float attack = 0f;
	public float HP = 100f;
	public float defense = 10f;
	private int attackType = 0;
	private int defenseType = 0;
	public float enemyTestHP = 100f;
	public float fearGuage = 30f;

	// Temporary
	public bool antiDepression = false;
	public bool alcohol = false;

    // Main function
	void Update() {

		// Set Attack Value
		float attack = Random.Range(7f, 10f);

		// Apply buffs if antiDepression of alcohol in inventory
		if (antiDepression == true) {
			// Apply attack buff 2X & defense 1.33
		}
			
		if (alcohol == true) {
			// Apply attack buff 2X & defense 1.33
		}

		// Defense Type Switch
		switch(defenseType){
		default:
			defense = 10f;
			break;
		case 1:
			defense = (defense - 1.33f);
			break;
		}

		// AttackType switch
		switch (attackType) {
		default:
			attack = Random.Range (7f, 10f);
			break;
		case 1:
			attack = (attack * 1.5f);
			break;
		case 2:
			attack = (attack * 2f);
			break;
		}
	}


	//fear
	//GUI



}
