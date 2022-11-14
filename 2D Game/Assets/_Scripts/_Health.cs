using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Health : MonoBehaviour
{
    public GameObject Player;
    int Health = 3;
    int actualHealth;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.tag == "Laser")
        {
            actualHealth -= Health;
            Debug.Log(actualHealth);
            if(actualHealth <= 0)
            {
                actualHealth = 0;
                Destroy(Player);
            }
        }
        else if(collision.collider.tag == ("Enemy"))
        {
            actualHealth = 0;
            if (actualHealth <= 0)
            {
                actualHealth = 0;
                Destroy(Player);
            }
        }
    }


}
