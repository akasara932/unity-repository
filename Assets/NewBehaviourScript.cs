using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
        //throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message:"start");
        
    }
    void OnEnable()
    {
        Debug.Log("OnEnable");
    
    }

    private void Update()
    {
        //throw new NotImplementedException();
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
        //throw new NotImplementedException();
    }
    // Update is called once per frame

}
