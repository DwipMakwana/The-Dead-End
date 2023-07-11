using UnityEngine;

public class GameObjectiveInfo : MonoBehaviour
{
    public GameObject InfoUI;
    private bool Enabled;

    public void Start()
    {
        Enabled = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            Enabled = !Enabled;
            if (Enabled == true)
            {
                InfoUI.SetActive(false);
            }
            else
            {
                InfoUI.SetActive(true);
            }
            
    }
}
