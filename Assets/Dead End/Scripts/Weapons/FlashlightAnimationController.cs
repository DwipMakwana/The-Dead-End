using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FlashlightAnimationController : MonoBehaviour
{
    [SerializeField]public Animator FlashlightAnimation;

    // Start is called before the first frame update
    void Start()
    {
        FlashlightAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            FlashlightAnimation.Play("Player Walk");
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            FlashlightAnimation.Play("Default");
        }
        if( Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.A) ||
            Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.LeftShift) )
        {
            FlashlightAnimation.Play("Player Run");
        }
    }
}
