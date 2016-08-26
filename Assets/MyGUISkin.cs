using UnityEngine;
using System.Collections;

public class MyGUISkin : MonoBehaviour {
	void OnGUI()
	{
		GUI.skin = new GUISkin();
	}
}
