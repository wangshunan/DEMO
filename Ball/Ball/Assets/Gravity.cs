using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
	
    private float gravity;
    private float fallSpeed;
    
    public bool onGravity;

    private void Start()
    {
        //onGravity = true;
        gravity = 9.8f;
        fallSpeed = 0;
    }

    void Update () {

        if ( !onGravity )
        {
            return;
        }

        fallSpeed -= gravity * Time.deltaTime;

        gameObject.transform.position += new Vector3(0, fallSpeed * Time.deltaTime, 0);

	}
}
