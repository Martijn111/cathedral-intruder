using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooter : MonoBehaviour {

    GameObject prefab;
	void Start () {
        prefab = Resources.Load("particle_projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown(0))
        {
            GameObject particle_projectile = Instantiate(prefab) as GameObject;
            particle_projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = particle_projectile.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 40;
        }
	}
}
