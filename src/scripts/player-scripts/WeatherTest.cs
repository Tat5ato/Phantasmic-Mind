using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherTest : MonoBehaviour {
	public bool IsRaining;
	public bool Thunder;
	public int ThunderInterval;
	// Use this for initialization
	void Start () {
		ThunderInterval = 3;
		StartCoroutine (ThunderCode ());
	}
	
	// Update is called once per frame
	void Update () {
		if (IsRaining == true) {
			Debug.Log ("Fear is increasing...");
		}
	}
	IEnumerator ThunderCode(){
		yield return new WaitForSeconds (ThunderInterval);
		ThunderInterval = Random.Range (5, 20);
		Debug.Log ("THUNDER");
		StartCoroutine (ThunderCode ());

	}
}
