using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTakeDamage : MonoBehaviour
{
    public float currentHealth = 100f;
    public float maxPlayerHealth = 100f; //To be used later for health pickup
    public float ghoulDamage = 25f; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "enemy"){
            currentHealth = currentHealth - ghoulDamage;
            if(currentHealth <= 0){
                Debug.Log("You have died!");
            }
        }
    }
}
