using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henry : MonoBehaviour{

	//variables
	public double attack = 0;
	public int HP = 100;
	public float defense = 10f;
	private int attackType = 0;
	private int defenseType = 0;
	public double enemyTestHP = 100f;
	public bool AttackChange = false;

	//switches for items or buffs
	void Update(){

		//declared up before the void update, but you cant use random.range outside a void update
		double attack = Random.Range(7f, 10f);

		//-insert definition here-
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
			attack = (attack * 1.5);
			AttackChange = true;
			break;
		case 2:
			attack = (attack * 2);
			AttackChange = true;
			break;
		default:
			attack = Random.Range (7, 10);
			AttackChange = true;
			break;
		}
	}


	//buffs
	//fear
	//GUI


}
