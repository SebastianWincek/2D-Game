using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ShotSystem : MonoBehaviour
{
    public GameObject Laser;
    public Transform shootingPoint;
    public float projectileSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shot();
    }

    void Shot()
    {
        if (Input.GetKeyDown("space"))
        {
            Instantiate(Laser, shootingPoint.position, shootingPoint.rotation);
            Rigidbody rb = Laser.GetComponent<Rigidbody>();
            rb.velocity = transform.up * projectileSpeed;
        }
    }
}
