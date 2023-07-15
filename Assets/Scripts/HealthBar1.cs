// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class HealthBar1 : MonoBehaviour
// {
//     public Slider healthBar;
//     private float totalHealth = 100.0f;
//     private float obstacleHealth;
//     public GameObject obstacle;

//     // Start is called before the first frame update

//     void Start()
//     {
//         obstacleHealth = totalHealth;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         transform.position = obstacle.transform.position;

//     }

//      public void AdjustSlider(float damage)
//     {

//         obstacleHealth -= damage;
//         healthBar.value = obstacleHealth / totalHealth;
//     }
// }
