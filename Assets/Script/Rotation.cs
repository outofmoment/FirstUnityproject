using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float yvariable = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
      Debug.Log("Hello World");
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,yvariable,0);
        //transform.Translate(Vector3.forward);

    }
}
