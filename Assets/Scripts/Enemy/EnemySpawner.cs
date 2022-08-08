using ShoterProject.Enemy;
using UnityEngine;

namespace EnemySpawner

{

    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private Enemy enemyPrefab;
        [SerializeField] private float spawnStep = 1f;

        private float nextSpawnTime;

        void Update()
        {
            if (Time.time > nextSpawnTime)
            {
                var enemy = Instantiate(enemyPrefab , transform);
                nextSpawnTime = Time.time + spawnStep;
            }

        }
    }
}
