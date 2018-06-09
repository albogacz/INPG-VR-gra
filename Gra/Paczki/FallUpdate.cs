using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallUpdate : MonoBehaviour {

	
	void Start () {

        FixedUpdate();
        
    }

    void FixedUpdate()
    {
        if (transform.position.y < -15)
        {
            MoveBack();
        }
    }

    void MoveBack()
    {

        transform.position = new Vector3(-2, 3, 33);

    }
}
