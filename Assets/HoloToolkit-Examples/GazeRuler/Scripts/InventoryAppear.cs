using UnityEngine;
using System.Collections;

public class InventoryAppear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        GetComponent<Renderer>().enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //called by SpeechManager
    void onInventory()
    {
        GetComponent<Renderer>().enabled = true;
    }
}
