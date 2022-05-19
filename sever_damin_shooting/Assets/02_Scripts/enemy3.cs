using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy3 : MonoBehaviour
{
      float speed = 2;
    Vector3 dir= Vector3.down;
      public float shootDuration = 1f;
    public GameObject enemybullet = null;
  void Start()
    {
        StartCoroutine(Shooting());
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
    private IEnumerator Shooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Instantiate(enemybullet, transform.position, Quaternion.identity);
        }
    }
}
