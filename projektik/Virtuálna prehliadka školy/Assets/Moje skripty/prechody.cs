using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class prechody : MonoBehaviour
{

    public string SceneName;
    public int cameraRotation = 0;

private void OnMouseDown()
    {
        GameObject.Find("Manager").GetComponent<Manager>().uhol = cameraRotation;

        SceneManager.LoadScene(SceneName);

    }
}