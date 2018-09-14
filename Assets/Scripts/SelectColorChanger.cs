using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectColorChanger : MonoBehaviour {

    GameManager GameManager;

    public int nextSceneNum;

	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction*100, Color.yellow);

            if ( Physics.Raycast(ray, out hit))
            {
                Debug.Log(ray);

                if (hit.collider.CompareTag("Start"))
                {
                    SceneManager.LoadScene(1);
                }

                if (hit.collider.CompareTag("Point"))
                {
                    var orb = hit.collider.gameObject.GetComponent<OrbBehavior>();

                    orb.setBlue();
                
                }

                if (hit.collider.CompareTag("CUBE"))
                {
                    SceneManager.LoadScene(nextSceneNum);
                }

            }
        }
	}
}

