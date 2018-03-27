using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public GameObject Player = null;
    public int index = 0;
    public Transform target;
    public float smoothing = 5f;
    public float xMargin;
    public float yMargin;
    public float xSmooth;
    public float ySmooth;

    //The maximum X and Y coordinates the camera can have
    public Vector2 maxXAndY;
    //The mininum X and Y coordinates the camera can have
    public Vector2 minXAndY;

    private Vector3 offSet;


    // Use this for initialization
    void Start () {
        offSet = transform.position - target.position;
	}

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    /*void FindNext()
    {
        index++;
        if(index >= Player.Length)
        {
            index = 0;
        }

        target = Players[index].transform;
    }*/

    // Update is called once per frame
    void FixedUpdate () {
        Vector3 targetCamPos = target.position + offSet;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        try
        {
            TrackPlayer();
        }
        catch  (MissingReferenceException e)
        {
            Debug.Log("There is no player");
        }
	}

    bool checkXMargin()
    {
        return Mathf.Abs(transform.position.x - target.transform.position.x) > xMargin;
    }

    bool checkYMargin()
    {
        return Mathf.Abs(transform.position.y - target.transform.position.y) > yMargin;
    }


    void TrackPlayer()
    {
        float targetX = transform.position.x;
        float targetY = transform.position.y;

        if (checkXMargin())
            targetX = Mathf.Lerp(transform.position.x, target.transform.position.x, xSmooth * Time.deltaTime);
        if (checkYMargin())
            targetY = Mathf.Lerp(transform.position.y, target.transform.position.y, ySmooth * Time.deltaTime);

        targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
        targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

        transform.position = new Vector3(targetX, targetY, transform.position.z);

    }

}