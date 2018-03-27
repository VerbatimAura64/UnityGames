using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Reset : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DestroyObject(other.gameObject);
            GM.instance.GameOver();
                if (Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(0);
                }
        }
    }
}
