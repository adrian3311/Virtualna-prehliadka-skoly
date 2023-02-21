using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    public float uhol = 0;



    public static GameObject manager;

    private void Start () 
    {
        DontDestroyOnLoad(gameObject);
        if (manager != null)
        {
            Destroy(this.gameObject);

        }

        else {

            manager = this.gameObject;
        
        }
    
    
    }







}
