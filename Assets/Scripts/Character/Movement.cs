using UnityEngine;

namespace ShoterProject
{

    public class Movement : MonoBehaviour
    {


        public float walkSpeed = 2;
        public float runSpeed = 6;

        public float turnSmoothTime = 0.2f;
        float turnSmoothVelocity;

        public float speedSmoothTime = 0.1f;
        float speedSmoothVelocity;
        float currentSpeed;

        Transform cameraT;

        private void Start()
        {
            cameraT = Camera.main.transform;
        }

        private void Update()
        {
            Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
            Vector2 inputDir = input.normalized;

            if (inputDir != Vector2.zero)
            {
                float targetRotation = (Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg) + cameraT.eulerAngles.y;
                transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);

            }

            bool running = Input.GetKey(KeyCode.LeftShift);
            float targetSpeed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;
            currentSpeed = Mathf.SmoothDamp(currentSpeed, targetSpeed, ref speedSmoothVelocity, speedSmoothTime);

            transform.Translate(transform.forward * currentSpeed * Time.deltaTime, Space.World);

           
        }
    }
}