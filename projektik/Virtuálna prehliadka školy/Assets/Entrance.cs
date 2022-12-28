using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Entrance : MonoBehaviour
{

    public string SceneName;


    private void OnMouseDown()
    {
        global::System.Object p = SceneManager.LoadScene(SceneName);

    }
}
