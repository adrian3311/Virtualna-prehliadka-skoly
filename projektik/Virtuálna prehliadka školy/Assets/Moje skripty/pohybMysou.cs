using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybMysou : MonoBehaviour
{

    public float speed = 2;

    private Camera mainCamera;

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

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            print("fdggq");

            transform.Rotate(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0);
            var x = transform.rotation.eulerAngles.x;
            var y = transform.rotation.eulerAngles.y;
            transform.rotation = Quaternion.Euler(x, y, 0);

            rotationTick = 0;
        }

        var delta = Input.mouseScrollDelta;
        mainCamera.fieldOfView -= delta.y;
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView, minFov, maxFov);

        rotationSave = transform.rotation.eulerAngles.y;

        if (rotationTick >= rotationTime)
        {
            mainCamera.transform.rotation = Quaternion.Euler(mainCamera.transform.rotation.x, rotationSpeed + rotationSave, 0);
            rotationSave = 0;
            print("uwu");
        }

        rotationTick += Time.deltaTime;

        print(rotationSave);
    }

}
