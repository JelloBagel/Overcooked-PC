using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hand_Controller : MonoBehaviour {

    public bool handsOccupied;
    GameObject[] pickUpAbles;


    private void Start()
    {
        handsOccupied = false;
        if (pickUpAbles == null)
            pickUpAbles = GameObject.FindGameObjectsWithTag("Pickupable");
    }

    private void Update()
    {
        //true if hands have a pickupable object in it
        foreach (GameObject pickUpAble in pickUpAbles)
        {
            if (pickUpAble.GetComponent<Pickupable>().holdingObject == true)
            {
                handsOccupied = true;
            }
            else
            {
                handsOccupied = false;
            }
        }
    }
}
