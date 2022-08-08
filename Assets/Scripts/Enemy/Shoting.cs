using System;
using UnityEngine;

namespace ShoterProject.Enemy
{

    public class Shoting : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float spawnStep = 1f;
        [SerializeField] private float angularSpeed = 5f;

        private float nextSpawnTime;
        private Transform Character;

        private void Start()
        {
            Character = GameObject.FindObjectOfType<Movement>().transform;
        }

        private void Update()
        {
            LookAtPlayer();
            Shoot();

        }

        private void LookAtPlayer()
        {
            var direction = Character.transform.position - transform.position;
            var rotation = Vector3.RotateTowards(transform.forward, direction, angularSpeed * Time.deltaTime, 0f);
            transform.rotation = Quaternion.LookRotation(rotation);
        }

        private void Shoot()
        {
            if (Time.time > nextSpawnTime)
            {
                Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
                nextSpawnTime = Time.time + spawnStep;
            }
        }
    }
}
