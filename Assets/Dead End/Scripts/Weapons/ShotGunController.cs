using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGunController : MonoBehaviour
{
    public Animator ShotgunRecoil;
    private float _nextAnimateGunTime = 0f;
         
    void Update()
    {
        //play shotgun shoot animation on mouse-click
        if (Input.GetMouseButtonDown(0) && Time.time > _nextAnimateGunTime)
        {
            ShotgunRecoil.Play("Shotgun Recoil", 0, 0f);
            ShotgunRecoil.speed = 1;
            _nextAnimateGunTime = Time.time + 2.0f;     //Wait time for next attack
        }
    }
}