using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour {

    public bool holdingObject; 
    private bool ableToDrop;
  
    private GameObject playerHands;

    //private bool onCounter;
    //Counter_Space counterSpace;

    // Use this for initialization
    void Start()
    {
        holdingObject = false;
        ableToDrop = false;
        //onCounter = false;
        playerHands = GameObject.Find("HandGuide");
        //counterSpace = FindObjectOfType<Counter_Space>();
    }

    // Update is called once per frame
    void Update () {

        //Debug.Log(playerHands.holdingObject);

        if (holdingObject == true) //object is at center of the hands
        {
            transform.position = playerHands.transform.position;
            transform.rotation = Quaternion.identity;
            transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }

        //if (onCounter == true)
        //{
        //    //position of pickupable goes to center of the counter space
        //    //transform.position = transform.position;
        //}
	}

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Pickupable is in the trigger of " + other.gameObject.name);

        // if player clicks x, will pick up ingredient (if in collision)
        if (other.gameObject.CompareTag("HandSpace") && Input.GetKeyDown(KeyCode.X) && ableToDrop == false && playerHands.GetComponent<Player_Hand_Controller>().handsOccupied == false)
        {
            Debug.Log("picked up");
            holdingObject = true;
            IEnumerator coroutine = ableToDropTrue(0.5f);
            StartCoroutine(coroutine);
        }
        //if true and clicks x again, then will drop ingredient
        else if (other.gameObject.CompareTag("HandSpace") && Input.GetKeyDown(KeyCode.X) && ableToDrop == true)
        {
            Debug.Log("dropped object");
            holdingObject = false;

            IEnumerator coroutine = ableToDropFalse(0.5f);
            StartCoroutine(coroutine);
        }

        //if (other.gameObject.CompareTag("CounterSpace") && counterSpace.counterUsed == false) //FIX LATER
        //{
        //    print("on counter is true");
        //    onCounter = true;
        //    transform.position = other.transform.position;
        //}
    }

    private IEnumerator ableToDropTrue(float waitTime) //unable to drop object until coroutine is done
    {
        yield return new WaitForSeconds(waitTime);
        ableToDrop = true;
    }

    private IEnumerator ableToDropFalse(float waitTime) //unable to pickup object until coroutine is done
    {
        yield return new WaitForSeconds(waitTime);
        ableToDrop = false;

    }


}
