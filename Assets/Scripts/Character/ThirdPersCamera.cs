using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShoterProject.thirdPersCamera
{

    public class ThirdPersCamera : MonoBehaviour
    {
        public bool lockCursor;
        public float mouseSence = 10f;
        public Transform target;
        public float distanceFromTarget = 2;
        public Vector2 pitchMinMax = new Vector2(-40, 85);


        public float rotationSmoothTime = .12f;
        Vector3 rotationSmoothVelocity;
        Vector3 currentRotation;

        float yaw;
        float pitch;


        private void Start()
        {
            if (lockCursor)
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }


        void LateUpdate()
        {
            yaw += Input.GetAxis("Mouse X") * mouseSence;
            pitch -= Input.GetAxis("Mouse Y") * mouseSence;
            pitch = Mathf.Clamp(pitch, pitchMinMax.x, pitchMinMax.y);

            currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(pitch, yaw), ref rotationSmoothVelocity, rotationSmoothTime);

          
            transform.eulerAngles = currentRotation;

            transform.position = target.position - (transform.forward * distanceFromTarget);
 



        }
    }
    

}