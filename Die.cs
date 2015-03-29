using UnityEngine; 
using System.Collections; 
public class Die : MonoBehaviour{ 
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{ 
			Application.LoadLevel("Gameover");
		} 	
	} 
}
