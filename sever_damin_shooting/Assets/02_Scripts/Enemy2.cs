using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    float speed = 2;
    int hp = 3;
    Vector3 dir= Vector3.down;
    private void Start()
    {
   
    }
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
            
      
        UImanager sc = GameObject.Find("UImanager").GetComponent<UImanager>();
        sc.SetScore(sc.GetScore() +1);
      
    
           if(collision.gameObject.CompareTag("Bullet")){
               hp-=1;
                Destroy(collision.gameObject);
               if(hp==0){
                   Destroy(gameObject);
   
               }
        }
     
    }
}
