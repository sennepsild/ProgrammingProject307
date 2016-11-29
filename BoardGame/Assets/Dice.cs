using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dice : MonoBehaviour {

    Text writeText;

	// Use this for initialization
	void Start () {
        writeText = GameObject.Find("DiceText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void WriteToTextField()
    {
        int rndDice = Random.Range(1, 7);

        writeText.text = "" + rndDice;

    }
}
