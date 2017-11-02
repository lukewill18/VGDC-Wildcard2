using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {
    public GameObject projectilePrefab;
    private List<GameObject> Projectiles = new List<GameObject>();
    private float projectileVelocity;
    public Transform Rotate;

	// Use this for initialization
	void Start () {
        projectileVelocity = 5;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Shoot"))
        {   
            // rotation = transform.parent.GetComponent
            GameObject bullet = Instantiate(projectilePrefab, transform.position, Rotate.rotation);
            Projectiles.Add(bullet);
        }

        for (int i = 0; i < Projectiles.Count; i++)
        {
            GameObject goBullet = Projectiles[i];
            if (goBullet != null)
            {
                goBullet.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * projectileVelocity);

                Vector3 bulletScreenPos = Camera.main.WorldToScreenPoint(goBullet.transform.position);
                if (bulletScreenPos.y >= Screen.height || bulletScreenPos.y <= 0)
                {
                    DestroyObject(goBullet);
                    Projectiles.Remove(goBullet);
                }
            }
        }
	}
}
