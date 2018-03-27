using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTaken : MonoBehaviour {

    public bool spawnTaken;
    public static SpawnTaken instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Occupado ()
    {
        if(SpawnItems.instance)
        {

        }  
    }
    
}
