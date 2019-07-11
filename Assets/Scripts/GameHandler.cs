using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    private ObjectPooler objectPooler;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = FindObjectOfType(typeof(ObjectPooler)) as ObjectPooler;
        objectPooler.PooltheObjects(ball, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
