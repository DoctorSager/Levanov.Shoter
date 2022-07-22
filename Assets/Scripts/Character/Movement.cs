using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Movement
{

    public class Movement : MonoBehaviour
    {

        [SerializeField] private float Speed = 3f;
        [SerializeField] private float UpSpeed = 5f;

        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";
        private const string Running = "Running";


        private Vector3 direction;
        private bool IsRunning;


        void Update()
        {

            direction.x = Input.GetAxis(Horizontal);
            direction.z = Input.GetAxis(Vertical);

            IsRunning = Input.GetButton(Running);

            transform.position += direction * ((IsRunning ? UpSpeed : Speed) * Time.deltaTime);

        }

    }
}