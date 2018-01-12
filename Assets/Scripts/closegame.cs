using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closegame : MonoBehaviour {

	int timer = 0;

	void Update () {
		timer++;
		if (timer > 300)
		{
			Application.Quit();
		}
	}
}
