//displays ui (inventory) on henry

//add change NectarUse and antiDepressionUse in Henry.cs to true when used

//allows item access on ui (inventory)

//start includes calls to scripts (SCRIPT NAMES HAVE TO MATCH)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDIcons : MonoBehaviour {
	public float width;
	public float height = 25;

	public Texture inventorySlot;
	public Texture[] Items = new Texture[6];
	public int[] ItemQuatity = new int[6];
	public bool ThereIsNectar;

	public float Nectarx;
	public float Nectary;
	public int I;

	public Font NewFont;
	// Use this for initialization
	void Start () {
		height = 25;


	}
	
	// Update is called once per frame
	void Update () {
		Mathf.Clamp (Health, 0, 100);

	}
	void OnGUI(){
		//CREATES NEW STYLE
		GUIStyle style = new GUIStyle ();
		style.normal.textColor = Color.white;
		style.font = NewFont;
		style.fontSize = 24;
		//SECTION END
		
	

		//CONSUMING ALCHOHOLOR NECTAR
		if (ThereIsNectar) {
			if (GUI.Button (new Rect (((Screen.width / 2) - ((I - 2) * 100)) + (inventorySlot.width / 4), (Screen.height - 75) + (inventorySlot.height / 4), 50, 50), Items [I])) {
				Debug.Log ("You are drunk!");
				ItemQuatity [I]--;
				if (ItemQuatity [I] <= 0) {
					ItemQuatity [I] = 0;
					Items [I] = null;
				}
			}
		}
		//SECTION END

		//DISPLAYING ITEM BOXES
		for (int i = 0; i < 6; i++) {
			GUI.DrawTexture (new Rect ((Screen.width /2)- ((i-2)*100),Screen.height - 75, 75, 75), inventorySlot, ScaleMode.StretchToFill, true, 10.0F);
         //I NEED SPRITES FOR STYLIZED INVENTORY SLOTS
	 
		}
		//SECTION END

		//DISPLAYING ITEMS (TEXTURES)
		
		//I NEED SPRITES FOR THE DIFFERENT ITEMS
		for (int i = 0; i < 6; i++) {
			if (Items [i] != null) {
				if (Items [i].name != "P_Orange01") {
					GUI.DrawTexture (new Rect (((Screen.width / 2) - ((i - 2) * 100)) + (inventorySlot.width / 4), (Screen.height - 75) + (inventorySlot.height / 4), 50, 50), Items [i], ScaleMode.StretchToFill, true, 10.0F);

				} else {
					ThereIsAchohol = true;
					I = i;
					Nectarx = ((Screen.width / 2) - ((I - 2) * 100)) + (inventorySlot.width / 2);
					Nectary = (Screen.height - 75) + (inventorySlot.height / 2);
					GUI.DrawTexture (new Rect (((Screen.width / 2) - ((i - 2) * 100)) + (inventorySlot.width / 4), (Screen.height - 75) + (inventorySlot.height / 4), 50, 50), Items [i], ScaleMode.StretchToFill, true, 10.0F);
				}
			}
		}
		//SECTION END

		//Here, the item numbers (quantity) are created
		for (int i = 0; i < 6; i++) {
			GUI.Label (new Rect (((Screen.width /2)- ((i-2)*100))+6,Screen.height - 75, 75, 75),ItemQuatity[i].ToString(),style);

		}
		//Section END
	}
}
