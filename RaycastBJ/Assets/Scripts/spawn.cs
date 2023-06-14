using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        float x = UnityEngine.Random.Range(-3, 5);
        float z = UnityEngine.Random.Range(0, 4);
        Vector3 pos = new Vector3(x, 2, z);
        Instantiate(obj, pos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
       if (raycast.atingiu)
        {
            float x = UnityEngine.Random.Range(-3, 5);
            float z = UnityEngine.Random.Range(0, 4);
            Vector3 pos = new Vector3(x, 2, z);
            Instantiate(obj, pos, Quaternion.identity);
            raycast.atingiu = false;
        }
    }
}
