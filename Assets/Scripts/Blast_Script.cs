using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(RemoveAfterSeconds(1, gameObject));
    }
    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
