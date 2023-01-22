using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMoveScript : MonoBehaviour
{

    public GameObject mainRig;
    public Transform fruitPosition;
    public Transform toBacketPosition;
    public Transform sntachingPosition;

    [SerializeField] public static float handSpeed;

    private bool moveTofruit;
    private bool moveToBucket;
    private bool moveToSnatchingPosition;


    void Start()
    {
        moveTofruit = false;
        moveToBucket = false;
        moveToSnatchingPosition = false;
        handSpeed = 2;

        fruitPosition = transform;
        toBacketPosition = GameObject.Find("BucketMovePosition").transform;
        sntachingPosition = GameObject.Find("PositionofSntaching").transform;
        mainRig = GameObject.Find("Rig 1");
    }

    void FixedUpdate()
    {

        if (moveTofruit)
        {
            ArmMovingToFruit();

        }

        if (mainRig.gameObject.transform.position == fruitPosition.position)
        {
            moveTofruit = false;

            moveToBucket = true;
        }

        if (moveToBucket)
        {
            ArmMovingToBacket();
        }

        if (mainRig.gameObject.transform.position == toBacketPosition.position)
        {
            moveToBucket = false;
            moveToSnatchingPosition = true;
            

        }
        if (moveToSnatchingPosition)
        {
            ArmMovingToSnatchingPosition();
        }
        if (mainRig.gameObject.transform.position == sntachingPosition.position)
        {
            moveToSnatchingPosition = false;
        }


    }
    void OnMouseDown()
    {

        if (moveTofruit == false)
        {
            moveTofruit = true;
        }


    }

    private void ArmMovingToFruit()
    {
        mainRig.gameObject.transform.position = Vector3.MoveTowards(mainRig.gameObject.transform.position, fruitPosition.position, handSpeed * Time.deltaTime);

    }

    private void ArmMovingToBacket()
    {
        mainRig.gameObject.transform.position = Vector3.MoveTowards(mainRig.gameObject.transform.position, toBacketPosition.position, handSpeed * Time.deltaTime);
    }

    private void ArmMovingToSnatchingPosition()
    {
        mainRig.gameObject.transform.position = Vector3.MoveTowards(mainRig.gameObject.transform.position, sntachingPosition.position, handSpeed * Time.deltaTime);
    }
}
