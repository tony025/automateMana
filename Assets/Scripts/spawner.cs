using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] GameObject sphere;
    [SerializeField] string carteIdSpawn;



    [SerializeField]//prendre le component ControlManger pour ecouter les bouton
    private SampleMessageListener messageSender;


    // Start is called before the first frame update
    void Start()
    {
        messageSender.carteScanner.AddListener(Spawn);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void Spawn() {
        
        carteIdSpawn = messageSender.carteId;
        Debug.Log(carteIdSpawn);

        if (carteIdSpawn == "41ECE62") {
            Instantiate(cube, transform.position, Quaternion.identity);
        }else if (carteIdSpawn == "13FC28AD") {
            Instantiate(sphere, transform.position, Quaternion.identity);
        }else {
            Debug.Log(carteIdSpawn + " N'EST PAS VALID!");
        }


    }
}
