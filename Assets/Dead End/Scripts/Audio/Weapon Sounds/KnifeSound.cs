using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSound : MonoBehaviour
{
    public AudioSource knifeSound;
    private float _nextAnimateTime = 0;
    [SerializeField] private GameObject Pause;

    void Start()
    {
        knifeSound.GetComponent<AudioSource>();     //Initialization
    }

    void Update()
    {
        //Play knife sound on mouse click
        if(Input.GetMouseButtonDown(0) && Time.time > _nextAnimateTime)
        {
            if (Pause.activeInHierarchy == false)
            {
                knifeSound.Play();
                _nextAnimateTime = Time.time + 0.5f;        //Wait time for next attack
            }
        }
    }
}
