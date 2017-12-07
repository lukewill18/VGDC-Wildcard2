using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcontroller : MonoBehaviour
{

    public bool nextLevel = false;
    public string nextLevelName;

    void Update()
    {
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(allEnemies.Length == 0)
        {
            nextLevel = true;
        }
        if (nextLevel)
        {
            SceneManager.LoadScene(nextLevelName, LoadSceneMode.Single);
        }
    }
}
