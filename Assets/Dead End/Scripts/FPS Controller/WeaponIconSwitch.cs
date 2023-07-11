using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponIconSwitch : MonoBehaviour
{
    [SerializeField] public GameObject Weapon1Icon;
    [SerializeField] public GameObject Weapon2Icon;

    void Start()
    {
        //Setting all weapon icons disabled at start
        Weapon1Icon.SetActive(false);
        Weapon2Icon.SetActive(false);
    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            Weapon1Icon.SetActive(true);        //Enable HUD icon
            Weapon2Icon.SetActive(false);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Weapon1Icon.SetActive(false);       //Disable HUD icon
            Weapon2Icon.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Weapon1Icon.SetActive(true);
            Weapon2Icon.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Weapon1Icon.SetActive(false);
            Weapon2Icon.SetActive(true);
        }
    }
}
