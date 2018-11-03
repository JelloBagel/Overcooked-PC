using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

    [SerializeField]
    private float speed = 10f;
    private Vector3 playerOnePosition;

    public Vector3 com;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        playerOnePosition = transform.position;
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
    }
	
	// Update is called once per frame
	void Update () {
        rb.centerOfMass = com;
        PlayerOneMovement();
        //cut
    }

    private void PlayerOneMovement()
    {
        Vector3 relativePos = this.transform.position;

        if (Input.GetKey(KeyCode.D)) // move right
        {
            playerOnePosition.x = transform.position.x + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) //move left
        {
            playerOnePosition.x = transform.position.x - speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W)) // move up
        {
            playerOnePosition.z = transform.position.z + speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) // move down
        {
            playerOnePosition.z = transform.position.z - speed * Time.deltaTime;
        }
        this.transform.position = playerOnePosition; //updates player position

        //reset rotation to 0 on X and Z
        this.transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

        //rotate player to face movement direction, changes Y rotation
        if ((relativePos - this.transform.position) != new Vector3(0, 0, 0))
        {
            Quaternion rotation = Quaternion.LookRotation(-(relativePos - this.transform.position));
            this.transform.rotation = rotation;
        }

        ////freeze rotation of X and Z, debug -> causes x and z to sporadically change 
        //transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX;
        //transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationZ;
    }

}
