using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntantiateHandler : MonoBehaviour
{
    public GameObject[] objects; 
    public GameObject parent; 
    void Start()
    {
        foreach (GameObject obj in objects)
        {
            Debug.Log(obj);
            Instantiate(obj,parent.transform.position, Quaternion.identity);   
        }
    }
    void Update()
    {
        
    }
}
