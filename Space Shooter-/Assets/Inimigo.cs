using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMinima;
    public float velocidadeMaxima;
    public int life =3;
    //public AudioClip explosaoInimigo;

    private float velocidadeY;

    // Start is called before the first frame update
    void Start()
    {
        this.velocidadeY = Random.Range(this.velocidadeMinima, this.velocidadeMaxima);
    }

 public void TakeDamage(int damage){
        life -= damage;

        if(life <= 0){
          Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.rigidbody.velocity = new Vector2(-this.velocidadeY, 0 );


    }


    void OnCollisionEnter2D(Collision2D col){
     if(col.gameObject.layer == 6){
       col.gameObject.GetComponent<ControlePlayer>().TakeDamage(1);
       //AudioSource.PlayClipAtPoint(explosaoInimigo,transform.position);
       Destroy(gameObject);
      }
    if(col.gameObject.layer == 9){
      Destroy(gameObject);
    }
    }
    

    


}
