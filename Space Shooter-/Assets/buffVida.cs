using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buffVida : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMinima;
    public float velocidadeMaxima;
    private float velocidadeY;

    void Start()
    {   
        this.velocidadeY = Random.Range(this.velocidadeMinima, this.velocidadeMaxima);
    }


    void Update()
    {
        this.rigidbody.velocity = new Vector2(-this.velocidadeY, 0 );
       
    }
     void OnCollisionEnter2D(Collision2D col){
     if(col.gameObject.layer == 6){
       col.gameObject.GetComponent<ControlePlayer>().TakeLife(1);
       Destroy(gameObject);
      }
       if(col.gameObject.layer == 9){
      Destroy(gameObject);
    }
    }
}
