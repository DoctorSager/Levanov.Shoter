using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ShoterProject.Enemy
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private float damage = 5f;
 
        void Update()
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }



        private void OnCollisionEnter(Collision collision)
        {
            Hurt(collision.gameObject);
        }




        private void OnTriggerEnter(Collider other)
        {
            Hurt(other.gameObject);
        }



        private void Hurt(GameObject collisionGO)
        {
            if (collisionGO.TryGetComponent(out Health health))
            {
                health.Hurt(damage);
            }
            Destroy(gameObject);
        }
    }
}
