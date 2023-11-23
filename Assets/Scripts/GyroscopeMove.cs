using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroscopeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation = Input.gyro.attitude;
        //transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, -Input.gyro.rotationRateUnbiased.y); //celular horizontal
        transform.Rotate(-Input.gyro.rotationRateUnbiased.x, Input.gyro.rotationRateUnbiased.z, Input.gyro.rotationRateUnbiased.y);
    }
}
