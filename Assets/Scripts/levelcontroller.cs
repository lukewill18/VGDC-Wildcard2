using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelcontroller : MonoBehaviour
{

    private bool nextLevel = false;
    public string nextLevelName;

    void Update()
    {
        GameObject[] allSpawners = GameObject.FindGameObjectsWithTag("Spawner");
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(allEnemies.Length == 0)
        {
            nextLevel = true;
            for(int i = 0; i < allSpawners.Length; i++)
            {
                if (!allSpawners[i].GetComponent<SpawnEnemies>().done_spawning)
                {
                    nextLevel = false;
                }
            }
        }
        if (nextLevel)
        {
            StartCoroutine(ChangeLevel());
        }
    }

    private IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(nextLevelName, LoadSceneMode.Single);
    }
}


