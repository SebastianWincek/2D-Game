using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _EnemyDestroy : MonoBehaviour
{
    public int lifetime;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}


