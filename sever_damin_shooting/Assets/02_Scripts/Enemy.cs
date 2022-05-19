using System.Net;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{
   

    float speed = 3;
    Vector3 dir;
    private void Start()
    {
        int rd = Random.Range(0, 10);//0~9
        if (rd<3)
        {
            GameObject target = GameObject.Find("Player");
            dir = target.transform.position - transform.position;
            dir.Normalize();

        }
        else
        {
            dir = Vector3.down;
        }
    }
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
      
        UImanager sc = GameObject.Find("UImanager").GetComponent<UImanager>();
        sc.SetScore(sc.GetScore() +1);
      
    
           if(collision.gameObject.CompareTag("Bullet")){
        Destroy(collision.gameObject);
        }
     
    }
}
