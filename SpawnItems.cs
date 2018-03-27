using UnityEngine;
using System.Collections;

public class SpawnItems : MonoBehaviour {

    public Transform[] itemSpawns;
    public bool[] SpawnTaken;
    public static SpawnItems instance = null;
    public GameObject item;
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject empty;

    // Use this for initialization
    void Start () {
        Spawn();
    }

    
	
	void Spawn () {
        for (int i = 0; i < itemSpawns.Length; i++)
        {
            int coinFlip = Random.Range(0, 7);
            if (coinFlip < 1)
            {
                Instantiate(item, itemSpawns[i].position, Quaternion.identity);
                SpawnTaken[i] = true;
            }
             else if (coinFlip <= 2 && SpawnTaken[i] == false)
            {
                Instantiate(item1, itemSpawns[i].position, Quaternion.identity);
                SpawnTaken[i] = true;
            }
            else if (coinFlip > 2 && coinFlip <= 3 && SpawnTaken[i] == false) { 
                Instantiate(item2, itemSpawns[i].position, Quaternion.identity);
                SpawnTaken[i] = true;
            }
            else if (coinFlip > 3 && coinFlip <= 4 && SpawnTaken[i] == false) {
                Instantiate(item3, itemSpawns[i].position, Quaternion.identity);
                SpawnTaken[i] = true;
            }
            else if (coinFlip > 4 && coinFlip <= 5 && SpawnTaken[i] == false) {
                Instantiate(item4, itemSpawns[i].position, Quaternion.identity);
                SpawnTaken[i] = true;
            }
            else
            {
                Instantiate(empty, itemSpawns[i].position, Quaternion.identity);
            }
            

        }
	}
}
