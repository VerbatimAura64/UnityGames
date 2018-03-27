using UnityEngine;
using System.Collections;

public class TimedDestroy : MonoBehaviour {

    public float lifetime;

	// Use this for initialization
	/*void Start ()
    {
        Destroy(gameObject, lifetime);
	}*/

    void OnTriggerExit2D(Collider2D other)
    {
        Destroy(gameObject, lifetime);
    }
}
