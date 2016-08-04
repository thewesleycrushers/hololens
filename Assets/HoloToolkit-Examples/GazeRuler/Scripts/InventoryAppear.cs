using UnityEngine;
using System.Collections;

public class InventoryAppear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
        GetComponent<MeshRenderer>().enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //called by SpeechManager
    void onInventory()
    {
        GetComponent<MeshRenderer>().enabled = true;
    }
}
