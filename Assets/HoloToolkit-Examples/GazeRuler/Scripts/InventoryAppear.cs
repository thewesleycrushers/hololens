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
        Debug.LogWarning("open inventory triggered in game object");
        GetComponent<Renderer>().enabled = true;
    }
}
