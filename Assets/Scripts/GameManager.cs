using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public List<OrbBehavior> OrbList;

    [SerializeField]
    int totalOrbs;
    //[SerializeField]
    //int orbsActivated;

    public GameObject prefab;
    public Transform cubeSpawn;

    bool activeCube;

    private void Start()
    {
        totalOrbs = OrbList.Count;
    }

    void Update () {


        Debug.Log(AreAllInListBlue(OrbList));

        if (AreAllInListBlue(OrbList) == true)
        {
            if (!activeCube)
            {
                Instantiate(prefab, cubeSpawn);
                activeCube = true;
            }
            
        }

    }

    public bool OrbsBlue()
    {
        for (int i = 0; i < OrbList.Count; i++)
        {
            if (OrbList[i].blue)
            {
                return true;
            }
        }
        return false;
    }

    public bool AreAllInListBlue(List<OrbBehavior> bools)
    {
        bool to_return = true;

        foreach(OrbBehavior x in bools)
        {
            if (!x.blue)
            {
                to_return = false;
            }
        }

        return to_return;
    }

    public bool AreAllInListRed(List<OrbBehavior> bools)
    {
        bool to_return = true;

        foreach (OrbBehavior x in bools)
        {
            if (!x.red)
            {
                to_return = false;
            }
        }

        return to_return;
    }

    public void EndGame()
    {
        //Changes scene after some time
        SceneManager.LoadScene(0);
    }
}
