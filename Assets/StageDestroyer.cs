using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageDestroyer : MonoBehaviour
{
    public GameObject[] instantiate;
    // public GameObject instantiate01;
    // public GameObject instantiate02;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("AAA");
        Destroy(other.gameObject);
        for(int i=0;i<instantiate.Length;i++){
            instantiate[i].SendMessage("Create");
        }   
        // instantiate01.gameObject.SendMassage("Create");
        // instantiate02.SendMessage("Create");
    }
}
