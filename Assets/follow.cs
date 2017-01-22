using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        var guy = GameObject.Find("guy");
        transform.position = guy.transform.position;

        var d = Input.GetAxis("Mouse ScrollWheel");
        if (d > 0f)
        {
            // scroll up
        }
        else if (d < 0f)
        {
            // scroll down
        }

        transform.Translate(0,1,-20);
    }
}
