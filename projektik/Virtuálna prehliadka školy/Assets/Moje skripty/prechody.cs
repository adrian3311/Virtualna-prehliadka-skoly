using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class prechody : MonoBehaviour
{

    public string SceneName;
    public int cameraRotation = 0;

    /*void Update()
    {
        int readText = File.ReadAllText("C:\\Users\\adoli\\Desktop\\Virtualna-prehliadka-skoly\\projektik\\Virtuálna prehliadka školy\\Assets\\data.txt");
        this.rotate = new Vector3(0, int.Parse(readText), 0);
    }*/

private void OnMouseDown()
{
        //string readText = File.ReadAllText("C:\\Users\\adoli\\Desktop\\Virtualna-prehliadka-skoly\\projektik\\Virtuálna prehliadka školy\\Assets\\data.txt");
        //File.WriteAllText("C:\\Users\\adoli\\Desktop\\Virtualna-prehliadka-skoly\\projektik\\Virtuálna prehliadka školy\\Assets\\data.txt",cameraRotation.ToString());
        //Debug.Log(readText);

        SceneManager.LoadScene(SceneName);

    }
}