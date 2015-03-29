using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	
	public Text Score;

	private int nrOfCollectedItems;
	
	void Start()
	{
		GameObject[] objects = GameObject.FindGameObjectsWithTag ("Coin");
		nrOfCollectedItems = 0;
		UpdateUI();
	}
	
	public void AddCollectable()
	{
		nrOfCollectedItems++;
		UpdateUI ();
	}
	
	void UpdateUI()
	{
		Score.text = "Score: " + nrOfCollectedItems;
	}
}
