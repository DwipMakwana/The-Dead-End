using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    [SerializeField] public GameObject Weapon1;
    [SerializeField] public GameObject Weapon2;
    [SerializeField] public Animator KnifeSwitch;
    [SerializeField] public Animator ShotgunSwitch;

    public void Start()
    {   
        //Setting all weapons disabled at start
        Weapon1.SetActive(false);
        Weapon2.SetActive(false);
    }

    public void Update()
    {   
        //Getting input from player
        //hor mouse scroll control
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {           
            Weapon1.SetActive(true);            //Enables knife and disables shotgum
            Weapon2.SetActive(false);
            KnifeSwitch.Play("KnifeSwitch");    //Plays knife withdraw animation
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Weapon1.SetActive(false);               //Enables shotgun and disables knife
            Weapon2.SetActive(true);
            ShotgunSwitch.Play("ShotgunSwitch");    //Plays shotgun withdraw animation
        }

        //Same for Alphanumeric key control
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapon1.SetActive(true);
            Weapon2.SetActive(false);
            KnifeSwitch.Play("KnifeSwitch");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Weapon1.SetActive(false);
            Weapon2.SetActive(true);
            ShotgunSwitch.Play("ShotgunSwitch");
        }
    }
}
