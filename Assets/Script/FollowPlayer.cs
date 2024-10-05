using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    //Camera position at 2.36,4.6,-4.03
    private Vector3 offset = new Vector3(2.36f, 4.6f, -4.03f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;

    }
}
