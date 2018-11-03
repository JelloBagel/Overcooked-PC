using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter_Space : MonoBehaviour {

    public bool counterUsed;
    Pickupable pickUpAble;

	// Use this for initialization
	void Start () {
        counterUsed = false;
        pickUpAble = FindObjectOfType<Pickupable>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Pickupable") && counterUsed == false) //if the object is pickupable and the object was dropped then the counter is now being used
        {
            //ONLY ONE OBJECT CAN BE ON THE COUNTER
            counterUsed = true;
        }
    }
}
