using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiaTesto : MonoBehaviour {
    public Text testoDistanza;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit info = GameObject.FindGameObjectWithTag("Player").GetComponent<WorldCursor>().hitInfo;
        testoDistanza.text = info.distance.ToString();
	}
}
