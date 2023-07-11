using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSoundONOFF : MonoBehaviour
{
    [SerializeField] public Animator _flashlightONOFF;
    [SerializeField] public AudioSource _flashsoundONOFF;
    void Start()
    {
        _flashsoundONOFF.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            _flashsoundONOFF.Play();
        }
    }
}
