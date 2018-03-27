using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

    public GameObject destructionPoint;

    void Start()
    {
        destructionPoint = GameObject.Find("Platform Destruction Point");
    }

    void Update ()
    {
       if(transform.position.x < destructionPoint.transform.position.x)
        {
            Destroy(gameObject);
        }
    }
}
