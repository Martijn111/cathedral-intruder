using UnityEngine;

public class Fireball : MonoBehaviour {

    private AudioSource mAudiosrc;
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    private void Start()
    {
        mAudiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update ()
    {
		
        if (Input.GetButtonDown("Fire1"))
        {
            mAudiosrc.Play();
            Shoot();
        }

	}

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}