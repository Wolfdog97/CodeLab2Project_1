using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbBehavior : MonoBehaviour {

    public bool blue;
    public bool red;

    public Material blueMaterial, redMaterial;
    

	void Update () {
        if (blue)
        {
            transform.Translate(Vector3.up * 1 * Time.deltaTime);
            GetComponent<Renderer>().material = blueMaterial;
        }

        if (red)
        {
            //Sink and do other things
            GetComponent<Renderer>().material = redMaterial;
        }
	}

    public void setBlue(bool setting = true)
    {
        blue = setting;
    }
}
