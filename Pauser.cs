using UnityEngine;
using System.Collections;

public class Pauser : MonoBehaviour {
    [HideInInspector] public bool paused = false;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            paused = !paused;

        }

        if (paused)
        {
            Time.timeScale = 0;
            GM.instance.pauseText.text = "Press 'P' to resume";
        }
        else
        {
            Time.timeScale = 1;
           
        }
    }
}
