using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuStart : MonoBehaviour {

    public void changemenuscene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
}
