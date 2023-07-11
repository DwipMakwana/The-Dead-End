using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeHitController : MonoBehaviour
{
     public Animator KnifeHit;
     private float _nextKnifeHit; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > _nextKnifeHit)
        {
            KnifeHit.Play("Knife Hit", 0, 0f);
            KnifeHit.speed = 1;
            _nextKnifeHit = Time.time + 0.5f;       //Wait time for next attack
        }
    }
}
