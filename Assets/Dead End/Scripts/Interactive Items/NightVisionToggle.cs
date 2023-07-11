using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightVisionToggle : MonoBehaviour
{
    DeferredNightVisionEffect myScript;
    // Start is called before the first frame update
    void Start()
    {
        myScript = gameObject.GetComponent<DeferredNightVisionEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            myScript.enabled = true; //enable the script when button is pressed
        }
        else if (Input.GetKeyUp(KeyCode.N))
        {
            myScript.enabled = false; //disable the script when button is pressed
        }
    }
}
