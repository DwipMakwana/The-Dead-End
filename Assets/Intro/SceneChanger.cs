using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public string leveltoload;
    private float timer = 58f;       //After how much time to load the next scene

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            SceneManager.LoadScene(leveltoload);        //Level to load
        }

        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(leveltoload);        //Skip to level load by keycode
        }
    }
}
