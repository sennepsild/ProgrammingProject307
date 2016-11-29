using UnityEngine;
using System.Collections;

public class mouseDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.name == "Player")
            {
                Debug.Log("This is a Player");
            }
            else
            {
                Debug.Log("This isn't a Player");
            }
        }

    }
}
