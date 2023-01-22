using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Animations.Rigging;

public class WinningProcces : MonoBehaviour
{
    public Animator animator;
    public Camera mainCamera;
    public GameObject rig;
    public GameObject conveyor;

    public Transform winningCameraPos;

            
    void Update()
    {
        if (TuskController.neededFruitCount == TuskController.randomFruitNumber)
        {

            conveyor.SetActive(false);

            mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, winningCameraPos.position, 0.002f);

            animator.SetBool("isWinning", true);

            rig.GetComponent<Rig>().weight = 0;



        }
    }
}
