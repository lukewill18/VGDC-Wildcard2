using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bile_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(RemoveAfterSeconds(4, gameObject));
    }
    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(4);
        obj.SetActive(false);
    }
        // Update is called once per frame
        void Update () {
		
	}
}
