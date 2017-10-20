//base for controlling if item is consumed
//takes input from InGame Inventory with working nectar consumption to give output to Henry.cs
//output to Henry.cs chganges value used by fear guage
//start includes calls to scripts (SCRIPT NAMES HAVE TO MATCH)




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemConsumption : MonoBehaviour {

	
	public GameObject nectar = GameObject.FindGameObjectWithTag("nectar");
	public GameObject medicine = GameObject.FindGameObjectWithTag("medicine");
	//see if in inventory from Item Collection script
	public bool nectarCheck = false;
	public bool medicineCheck = false;
	//see if gui button is clikced to be used from HUD script
	public bool nectarUse = false;
	public bool medicineUse = false;
	//gui button
	public bool nectarGUI;
	public bool medicineGUI;
	
	// Use this for initialization
	void Start () {
		GameObject Henry = GameObject.Find ("Henry");
		fearGaugeCalculator FearGuageCalculator = Henry.GetComponents<fearGaugeCalculator> ();
		Henry henry = Henry.GetComponents<Henry> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (nectarCheck) {
			nectarGUI = true;
			//button press nectarUse = True (for HUD people)
		}
		if (medicineCheck) {
			medicineGUI = true;
			//button press medicineUse = True (for HUD people)
		}
		
		//returned from HUD script
		if(nectarUse){
			henry.nectar = true;
		}
		if(medicineUse){
			henry.medicine = true;
		}
	}
}
