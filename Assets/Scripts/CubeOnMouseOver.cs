using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOnMouseOver : MonoBehaviour
{
    GameObject gameController;
   
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    private void OnMouseDown()
    {
        //GetComponent<Renderer>().material.color = Color.yellow;

        gameController.GetComponent<RandomSpawner>().Spawn();
        GetComponent<Collider>().enabled = false;

    }
    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.green;

    }
}
