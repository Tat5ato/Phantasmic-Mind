using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour{
	#region Class Properties

	private int level;
	private int xpMax;
	public int xp;
	private int fearMax;
	public int fear;
	public int attack;
	private int healthMax;
	public int health;
	public int luck;
	private int specialChargeMax;
	public int specialCharge;

	void Start () {
		level = 1;
		xpMax = 10;
		xp = 0;
		fearMax = 50;
		fear = 0;
		attack = 5;
		healthMax = 20;
		health = healthMax;
		luck = 2;
		specialCharge = 5;
	}


	#endregion

	bool IsDead() {
		return this.health <= 0;
	}

	bool TakeDamage(int dmg) { 
		this.health -= dmg;
		return this.IsDead ();
	}

	bool TakeDamage(float dmg) {
		int realDmg = Mathf.RoundToInt (dmg);
		return this.TakeDamage (realDmg);
	}

	void Heal(int value) {
		if (value + health > healthMax) {
			this.health = this.healthMax;
		} else {
			this.health += value;
		}
	}

	void Heal(float value) {
		int realValue = Mathf.RoundToInt (value);
		this.Heal (realValue);
	}

	void GainExperience(int value) {
		this.xp += value;
		if (this.xp >= this.xpMax) {
			this.LevelUp ();
		}
	}

	bool GainFear (int spook) { 
		if (this.fear + spook >= this.fearMax) {
			this.fear = this.fearMax;
			return true;
		} else {
			this.fear += spook;
			return false;
		}
	}
	bool GainFear (float spook) {
		int realFear = Mathf.RoundToInt (spook);
		return this.GainFear (realFear);
	}

	void LevelUp() {
		this.level++;
		this.xp -= this.xpMax;
		this.xpMax += 5;
		this.fearMax += 10;
		this.attack += 1;
		this.healthMax += 5;
		luck += 1;
		if (level % 10 == 0 && specialCharge > 2) {
			specialChargeMax -= 1;
		}

		this.health = healthMax;

		if (xp > xpMax) {
			LevelUp ();
		}
			
	}

}

