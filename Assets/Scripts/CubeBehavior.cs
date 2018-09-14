using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

    public bool isRotating;

    public float xRot, yRot, zRot;

    private void Start()
    {
        isRotating = true;
    }

    // Update is called once per frame
    void Update () {
        // Move to a point

        if (isRotating)
        {
            transform.Rotate(new Vector3 (xRot, yRot, zRot) * Time.deltaTime);
          
        }
	}
}
