using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ShoterProject.Lenght
{

    public class Length : MonoBehaviour
    {
        public Text Dalnost;
        float rasstoyanie = 0; // переменная для расстояния до цели 
        public GameObject sharik;

        RaycastHit hitInfo;

        void Update()
        {
           

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitInfo, 200))
            {
                rasstoyanie = hitInfo.distance;
                Dalnost.text = rasstoyanie.ToString();
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    GameObject go = Instantiate(
                        sharik,
                        transform.position + Vector3.Normalize(hitInfo.point - transform.position),
                        transform.rotation
                    );
                    Rigidbody rig = go.GetComponent<Rigidbody>();
                    rig.velocity = Vector3.Normalize(hitInfo.point - transform.position) * 10;
                }
            }
        }
    }
}