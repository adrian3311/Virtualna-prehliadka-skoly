    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybMysou : MonoBehaviour
{
    //rychlost otacania
    public float speed = 2;

    private Camera mainCamera;
  

    //autom. rotacia
    float rotationTime = 3;
    float rotationTick = 0;
    float rotationSave = 0;
    float rotationSpeed = 0.05f;

    [SerializeField]
    private float minFov = 25, maxFov = 60;

// Start is called before the first frame update
void Start()
    {

        mainCamera = Camera.main;

        print(Camera.main.transform.eulerAngles);

        if(GameObject.Find("Manager").GetComponent<Manager>().uhol != 0)
        {

            Camera.main.transform.eulerAngles = new Vector3(0, GameObject.Find("Manager").GetComponent<Manager>().uhol, 0);


        }

        print(Camera.main.transform.eulerAngles);

        print("fsgdre");


    }

    // Update is called once per frame
    void Update()
    {
        var delta = Input.mouseScrollDelta;
        mainCamera.fieldOfView -= delta.y;
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, minFov, maxFov);

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0);
            var x = transform.rotation.eulerAngles.x;
            var y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(x, y, 0);

            rotationTick = 0;
        }

        rotationSave = transform.rotation.eulerAngles.y;

        if (rotationTick >= rotationTime)
        {
            mainCamera.transform.rotation = Quaternion.Euler(mainCamera.transform.rotation.x, rotationSpeed + rotationSave, 0);
            rotationSave = 0;
        }

        rotationTick += Time.deltaTime;

    }

}