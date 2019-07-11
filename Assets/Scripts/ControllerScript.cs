using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public Vector3 mousePos;
    private Rigidbody rigidbody;
    private Vector3 direction;

    private Vector3 dummyVec;
  
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {


        mousePos = Input.mousePosition;
        mousePos.z = 10f;

        Debug.Log("mouse pos x: " + mousePos.x + " mouse pos y: " + mousePos.y);
        rigidbody.MovePosition(new Vector3((Camera.main.ScreenToWorldPoint(mousePos).x), (Camera.main.ScreenToWorldPoint(mousePos).y), 0.5f));

        dummyVec = transform.position;
        dummyVec.z = 0.5f;
        transform.position = dummyVec;


    }

    private void FixedUpdate()
    {
      

    }
}
