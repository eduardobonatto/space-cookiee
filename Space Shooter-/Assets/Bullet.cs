using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bullet : MonoBehaviour
{
    public float speed =20f;
    public Rigidbody2D rb;
    public float deactivate_Timer = 4f;
    public float tempSpawn;
    public float cronometro;
    void Start()
    {
         
         rb.velocity = transform.right * speed;
        Invoke("DeactivateGameObject", deactivate_Timer);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void DeactivateGameObject(){
        Destroy(gameObject, 3);
    }
     void OnCollisionEnter2D(Collision2D col){
     if(col.gameObject.layer == 8){
       col.gameObject.GetComponent<Inimigo>().TakeDamage(1);
       Destroy(gameObject);
      }
      if(col.gameObject.layer == 10){
       Destroy(gameObject);
      }
      if(col.gameObject.layer == 11){
          Destroy(gameObject);
      }

    }
}
