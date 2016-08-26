using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.Button(new Rect(Screen.width * 0.35f, Screen.height * 0.45f, Screen.width * 0.3f, Screen.height * 0.1f), "Test Script");
	}
}
