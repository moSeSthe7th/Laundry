using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    private ObjectPooler objectPooler;
    public GameObject ball;
    private List<GameObject> ballsList;
    private GameObject selectedBall;

    private float selectedBallx;
    private float selectedBally;

    private Vector3 selectedBallPos;
    
    void Start()
    {
        objectPooler = FindObjectOfType(typeof(ObjectPooler)) as ObjectPooler;
        ballsList = objectPooler.PooltheObjects(ball, 20);

        StartCoroutine(ballSender());
    }

    public IEnumerator ballSender()
    {
        while (true)
        {
            selectedBall = objectPooler.GetPooledObject(ballsList);

            if (selectedBall != null && Input.GetMouseButton(0))
            {

                selectedBallPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                selectedBallPos.z = 0.5f;
                
                Debug.Log("Selected Ball Coord x: " + selectedBallx + " y: " + selectedBally);

                
                selectedBall.transform.position = selectedBallPos;
                selectedBall.gameObject.SetActive(true);
            }
            yield return new WaitForSecondsRealtime(0.1f);
        }
        
    }

}
