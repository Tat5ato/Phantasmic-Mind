using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henry : MonoBehaviour{

	// Variables
	public float attack = 0;
	public int HP = 100;
	public float defense = 10f;
	private int attackType = 0;
	private int defenseType = 0;
	public float enemyTestHP = 100f;
	public bool AttackChange = false;

    // Main function
	void Update(){

		//declared up before the void update, but you cant use random.range outside a void update
		float attack = Random.Range(7f, 10f);

		// Defense Type Switch
		switch(defenseType){
		case 1:
			defense = (defense - 1.33f);
			break;
		default:
			defense = 10f;
			break;
		}

		//cases represent weapons (or mabye buffs) ex. default is fists, case 1 is a shovel, case 2 is a sword
		switch (attackType) {
		case 1:
			attack = (attack * 1.5f);
			AttackChange = true;
			break;
		case 2:
			attack = (attack * 2f);
			AttackChange = true;
			break;
		default:
			attack = Random.Range (7f, 10f);
			AttackChange = true;
			break;
		}
	}


	//buffs
	//fear
	//GUI


}
