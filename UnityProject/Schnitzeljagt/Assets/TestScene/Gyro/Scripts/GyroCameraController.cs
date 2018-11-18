using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroCameraController : MonoBehaviour {

    public float RotationMaxSpeed;

	void Update () {
        GyroModifyCamera();

        transform.Rotate(Vector3.forward, Input.GetAxis("Horizontal") * RotationMaxSpeed);


	}


    // The Gyroscope is right-handed.  Unity is left handed.
    // Make the necessary change to the camera.
    void GyroModifyCamera()
    {
        transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }

}
