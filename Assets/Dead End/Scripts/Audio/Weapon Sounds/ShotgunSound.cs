using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunSound : MonoBehaviour
{
    public AudioSource shotgunSound;
    private float _nextAnimateGunTime = 0f;
    [SerializeField] private GameObject Pause;

    void Start()
    {
        shotgunSound.GetComponent<AudioSource>();   //Initialization
    }

    void Update()
    {
        //Plays shotgun sound on mouse-click
        if (Input.GetMouseButtonDown(0) && Time.time > _nextAnimateGunTime)
        {
            if (Pause.activeInHierarchy == false)
            {
                shotgunSound.Play();
                _nextAnimateGunTime = Time.time + 2.0f;     //Wait time for next attack
            }
        }
    }
}
