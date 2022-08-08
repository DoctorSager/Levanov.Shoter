using System.Collections;
using System.Collections.Generic;
using ShoterProject.Door;
using UnityEngine;


namespace ShotingProject.Plate
{
    public class Plate : MonoBehaviour
    {
       
        public GameObject door;

      


        void OnTriggerEnter(Collider other)
        {
            door.SetActive(false);
            transform.localPosition += new Vector3(0, 0, 0.3f);
           
            
        }

        void OnTriggerExit(Collider other)
        {
            door.SetActive(true);
            transform.localPosition -= new Vector3(0, 0, 0.3f);
            
        }


    }
}
