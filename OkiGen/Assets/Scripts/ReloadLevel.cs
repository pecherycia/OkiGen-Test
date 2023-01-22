using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadLevel : MonoBehaviour
{
   
    public void OnRestartClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
