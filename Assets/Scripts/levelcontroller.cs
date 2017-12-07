using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcontroller : MonoBehaviour
{

    private bool nextLevel = false;
    public string nextLevelName;

    void Start()
    {
        StartCoroutine(Wait());
    }

    void Update()
    {
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(allEnemies.Length == 0)
        {
            nextLevel = true;
        }
        if (nextLevel)
        {
            StartCoroutine(ChangeLevel());
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(7);
    }
    private IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(nextLevelName, LoadSceneMode.Single);
    }
}


