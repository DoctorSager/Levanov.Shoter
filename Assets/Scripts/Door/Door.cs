using System.Collections;
using System.Collections.Generic;
using ShotingProject.Plate;
using UnityEngine;

namespace ShoterProject.Door
{
    public class Door : MonoBehaviour
    {

        void OnTriggerEnter(Collider other)
        {
            transform.localPosition += new Vector3(0, 0, 0.3f);
            
        }

        void OnTriggerExit(Collider other)
        {
            transform.localPosition -= new Vector3(0, 0, 0.3f);

        }


    }
}
