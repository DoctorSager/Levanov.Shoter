using System;
using UnityEngine;

namespace ShoterProject
{

    public class ShotingCharacter : MonoBehaviour
    {

            
            public int ammo;
            public int allAmmo;

            public float ShootSpeed; 
            public float ReloadSpeed; 

            public float ReloadTimer = 0.0f;
        public float ShootTimer = 0.0f;

        private void Update()
            {
            if (Input.GetMouseButton(0))
            {
                Ray ray = new Ray(transform.position, transform.forward); //Луч
                RaycastHit hit; // Точка пересечения
                if (Physics.Raycast(ray, out hit))
                { //Бросаем луч
                    if (hit.collider.tag == "Tag")
                    { // Если луч бросить в цель "Tag (тег твоей цели)", то:
                      //Делай что хочешь
                        Destroy(hit.collider.gameObject); //Уничтожить объект, в который бросил луч (необязательно, это моя проверка).
                    }
                }
            }
        }
        }
    }
