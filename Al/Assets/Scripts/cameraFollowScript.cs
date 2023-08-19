using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 0, -5);
        
    }
}
