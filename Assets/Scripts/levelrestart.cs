using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelrestart : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {

		GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
		if(player.Length == 0)
		{
			//yield return new WaitForSeconds(2);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}
	}
}
