using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightHit : MonoBehaviour
{
    public Animator FlashHit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FlashHit.Play("Flashlight Hit", 0, 0f);
            FlashHit.speed = 1;
        }
    }
}
