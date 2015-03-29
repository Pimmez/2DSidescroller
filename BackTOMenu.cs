using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update(){
		if (Input.GetKeyDown (KeyCode.M)) 
		{
			Application.LoadLevel ("_Menu");
		}
		
	}
}
