using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseFearGUI : MonoBehaviour {
	public Font pixeled;
	public GameObject[] Buttons;
	public int DownUp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		pixeled.material.mainTexture.filterMode = FilterMode.Point;

		for (int i = 0; i < Buttons.Length; i++) {
			if (DownUp == i) {
				Buttons [i].GetComponent<RectTransform> ().localPosition = new Vector3 (-8, -64, 0);
				Buttons [i].GetComponent<Button> ().enabled = true;
			} else {
				Buttons [i].GetComponent<Button> ().enabled = false;
				Buttons [i].GetComponent<RectTransform> ().localPosition  = new Vector3 (-8, -64 - (60*(i-DownUp)), 0);
				Buttons [i].GetComponent<RectTransform> ().localScale  = new Vector3 (1.5f/(DownUp-i),1.5f/(DownUp-i), 0);
				if (Buttons [i].GetComponent<RectTransform> ().localScale.x < 0) {
					Buttons [i].GetComponent<RectTransform> ().localScale = new Vector3 (Buttons [i].GetComponent<RectTransform> ().localScale.x * -1, Buttons [i].GetComponent<RectTransform> ().localScale.y * -1, Buttons [i].GetComponent<RectTransform> ().localScale.z);

				}
			}
		}

		if (Input.GetKeyDown (KeyCode.W)) {
			if (DownUp < 9) {
				DownUp++;
			}
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			if (DownUp > 0) {
				DownUp--;
			}
		}

	}
	void OnGUI(){
		GUIStyle pixelFont = new GUIStyle ();
		pixelFont.normal.textColor = Color.white;
		pixelFont.font = pixeled;
		pixelFont.fontSize = 1;



	}
}
