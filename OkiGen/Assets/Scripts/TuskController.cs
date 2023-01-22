using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TuskController : MonoBehaviour
{
    public Text tuskText;
    public TextMesh plusOneText;
    public Button nextLevelButton;

    public GameObject[] fruits;
    private GameObject neededFruit;


    public static int randomFruitNumber;
    public static int neededFruitCount;

    private float minusRdb;

    private string neededFruitTag;

    private void Start()
    {
        minusRdb = 0;
        neededFruitCount = 0;
        randomFruitNumber = Random.Range(1, 4);
        neededFruit = fruits[(Random.Range(0, 4))];
        neededFruitTag = neededFruit.tag;

        tuskText.text = ("Collect" + " " + randomFruitNumber + " " + neededFruit.name);
    }

    void FixedUpdate()
    {
        minusRdb -= 2f;
        plusOneText.gameObject.GetComponent<TextMesh>().color = new Color(31, 255, 0, minusRdb);
        plusOneText.gameObject.transform.position = new Vector3(plusOneText.gameObject.transform.position.x, plusOneText.gameObject.transform.position.y + 0.004f, plusOneText.gameObject.transform.position.z);

        if (neededFruitCount == randomFruitNumber)
        {
            nextLevelButton.gameObject.SetActive(true);
        }

        if (neededFruitCount == randomFruitNumber)
        {

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(neededFruitTag))
        {
            neededFruitCount++;
            plusOneText.transform.position = new Vector3(transform.position.x, transform.position.y, plusOneText.transform.position.z);
            plusOneText.gameObject.GetComponent<TextMesh>().color = new Color(31, 255, 0, 255);
            minusRdb = 255;

            other.tag = "Untagged";

        }
    }
}
