using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyForShooter : MonoBehaviour
{
    
    
        public GameObject Character;
        public Rigidbody rig;
       

        bool enabled = true;

        void Start()
        {
            rig = GetComponent<Rigidbody>();
          
        }



        public void shoot()
        {
            if (!enabled)
        {
                return;
            }

            rig.isKinematic = false;
            Character.SetActive(false);

            enabled = false;
        }


}
