using UnityEngine;

namespace ShoterProject.Enemy
{
    public class MineDamage : MonoBehaviour
    {

        [SerializeField] private float damage = 1000f;




        private void OnCollisionEnter(Collision collision)
        {

            Hurt(collision.gameObject);

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









