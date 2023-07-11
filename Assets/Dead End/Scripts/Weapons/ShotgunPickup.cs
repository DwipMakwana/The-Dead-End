using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunPickup : MonoBehaviour
{
    public GameObject weaponOnGround;
    public GameObject weaponOnHand;
    void Start()
    {
        weaponOnHand.gameObject.SetActive(false);
        weaponOnGround.gameObject.SetActive(true);
    }

    void Update()
    {
       /*if()
        {
            weaponOnGround.gameObject.SetActive(false);
            weaponOnHand.gameObject.SetActive(true);
        }*/
    }
}
