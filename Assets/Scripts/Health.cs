using UnityEngine;

namespace ShoterProject.Enemy
{

    public class Health : MonoBehaviour
    {
        [SerializeField] private float maxHp = 100f;
        [SerializeField] private float currentHp;


        private void Awake()
        {
            currentHp = maxHp;
        }

        public void Hurt(float damage)
        {
            currentHp -= damage;
            if (currentHp <= 0)
            {
                Die();
            }
        }



        private void Die()
        {

            Destroy(gameObject);
        }

    }
}

