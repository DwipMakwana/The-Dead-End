using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMuzzle : MonoBehaviour
{
    public GameObject Muzzle;
    private float _waitForMuzzle;

    void Start()
    {
        Muzzle.gameObject.SetActive(false); //Initialization
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > _waitForMuzzle)
        {
            Muzzle.gameObject.SetActive(true);
            _waitForMuzzle = Time.time + 2.0f;
        }
        else
        {
            Muzzle.gameObject.SetActive(false);
        }
    }  
}
