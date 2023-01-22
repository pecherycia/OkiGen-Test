using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorMove : MonoBehaviour
{

    public Rigidbody rb;
    public float conveyorSpeed;
    public Material conveyorMaterial;



    void FixedUpdate()
    {
        conveyorMaterial.mainTextureOffset = new Vector2(Time.time * 10 * Time.deltaTime, 0f);
        Vector3 pos = rb.position;
        rb.position += Vector3.right * conveyorSpeed * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}
