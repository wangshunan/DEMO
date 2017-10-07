using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

    [SerializeField]
    Gravity gravity;

    public GameObject cube;

    void Start () {
        gravity = GetComponent<Gravity>();
	}

	void Update () {

        float dis;
        float r = transform.localScale.y / 2;
        float cubeR = cube.transform.localScale.y / 2;
        float offset = r + cubeR;

        dis = Vector3.Distance(transform.position, cube.transform.position);

        /*if ( dis <= offset )
        {
            transform.position = new Vector3(transform.position.x, cube.transform.position.y + offset, transform.position.z);
            gravity.onGravity = false;
        }*/

        Vector3 tmp = cube.transform.position - gameObject.transform.position;

        float angle = Vector3.Angle(cube.transform.position.normalized, tmp);

        Debug.Log(angle);
        Debug.DrawLine(cube.transform.position, gameObject.transform.position);
        //Debug.DrawLine(transform.position, transform.position.normalized);
        //Debug.DrawLine(cube.transform.position, cube.transform.up * 2);
    }
}
