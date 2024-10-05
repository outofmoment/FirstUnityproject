using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float player;
    Rigidbody playerrb;
    public float gravityMultiplier = 10.0f;
    public string horizontalString = "Horizontal";
    public string verticalString = "Vertical";
    public bool isonGround = true;
    AudioSource playeraudio;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody>();
        playeraudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
        
    }
     private void Movement()
    {
        horizontalInput = Input.GetAxis(horizontalString);
        verticalInput = Input.GetAxis(verticalString);
        //transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        playerrb.AddForce(Vector3.forward * verticalInput * speed);
        playerrb.AddForce(Vector3.right * horizontalInput * speed);
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonGround) 
        {
            playerrb.AddForce(Vector3.up * gravityMultiplier, ForceMode.Impulse);
            isonGround = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isonGround = true;

        }



    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            playeraudio.Play();
        
        }

    }
}
