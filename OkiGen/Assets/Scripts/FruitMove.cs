using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMove : MonoBehaviour
{
    private bool moveWithArm;
    public Transform armPositon;
    public Transform backetPoint;
    public GameObject mainRig;
    private  float fruitSpeed;


    void Start()
    {
        armPositon = GameObject.Find("ArmPosition").transform ;
        backetPoint =  GameObject.Find("BucketMovePosition").transform;
        mainRig = GameObject.Find("Rig 1");

        fruitSpeed = 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (armPositon.position == backetPoint.position)
        {
            moveWithArm = false;
            Debug.Log("moveWithArm" + moveWithArm);
        }
        if (moveWithArm == true)
        {
           MovingTobacket();
        }


        if (armPositon.position == backetPoint.position)
        {
            moveWithArm = false;
            Debug.Log("moveWithArm" + moveWithArm);
        }

        if(transform.position.x < -1)
        {
            Destroy(gameObject, 0.1f);
        }
    }


    private void MovingTobacket()
    {
        
       transform.position = Vector3.MoveTowards(transform.position, armPositon.position, fruitSpeed * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {

            moveWithArm = true;
            Debug.Log("moveWithArm"+ moveWithArm);

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            moveWithArm = false;
            Debug.Log("moveWithArm" + moveWithArm);

        }
    }




}
