using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SpawnEnemy : MonoBehaviour
{

    public GameObject preFab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Spawner()
    {
        while (true)
        {
            var position = new Vector3(Random.Range(-10.4f, 10.4f), 5f, 0);
            GameObject newEnemy = Instantiate(preFab, position, Quaternion.identity);
            yield return new WaitForSeconds(4);
            Destroy(newEnemy);

        }
    }


}
