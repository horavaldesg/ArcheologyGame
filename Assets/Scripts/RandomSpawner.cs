using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSpawner : MonoBehaviour
{
    public GameObject[] artifacts;
    int i;
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        i = Random.Range(0, artifacts.Length);
        Debug.Log(artifacts[i].GetComponent<DiggableArtifact>().nameOfArtifact);
        //Spawn artifacts[i]
    }
}
