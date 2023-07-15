using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroyobstacle : MonoBehaviour
{
    // public HealthBar1 HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        // HealthBar = GameObject.Find("HealthBar1").GetComponent<HealthBar1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
        Destroy(other.gameObject);
        // if (other.CompareTag("BigRock"))
        // {
        //     HealthBar.AdjustSlider(35);

        //      if(HealthBar.healthBar.value <= 0)
        //     {
        //     Destroy(other.gameObject);
        //     }
        //     // Destroy(gameObject);
        // }
        // if (other.CompareTag("MidRock"))
        // {
        //     HealthBar.AdjustSlider(50);
        //      if(HealthBar.healthBar.value <= 0)
        //     {
        //     Destroy(other.gameObject);
        //     }
        //     // Destroy(gameObject);
        // }
        // if (other.CompareTag("smallRock"))
        // {
        //     HealthBar.AdjustSlider(100);
        //      if(HealthBar.healthBar.value <= 0)
        //     {
        //     Destroy(other.gameObject);
        //     }
            
        //     // Destroy(gameObject);
        // }
        // // if(HealthBar.healthBar.value <= 0)
        // // {
        // //    Destroy(other.gameObject);
        // // }


    }
}
