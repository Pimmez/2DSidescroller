using UnityEngine; 
using System.Collections; 
public class CollectCoin : MonoBehaviour{ 

	public int score = 0;

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Coin") 
		{ 
		score =+ 5;
		Destroy (col.gameObject); 
		Debug.Log(score);
		} 	
	} 
}
