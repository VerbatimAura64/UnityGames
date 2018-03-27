using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
    public int scoreValue;
    public AudioClip sound;
    GM gm;

	// Use this for initialization
	void Start () {
        gm = GetComponent<GM>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
            Destroy(gameObject);
            GM.instance.GetComponent<GM>().AddScore(scoreValue);
            
            //gm.AddScore(scoreValue);
        }
    }
}
