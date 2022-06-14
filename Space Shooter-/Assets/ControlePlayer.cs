using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePlayer : MonoBehaviour
{
    public float speed = 10f;
    public float min_Y, max_Y;
    public GameObject player_Bullet;
    public Transform attack_Point;
    public int life = 5;
    public Barra barra;
    public Rigidbody2D rigidbody;


    void Start()
    {
        
    }

    void Update()
    {
        movePlayer();
        Attack();
    }
    void movePlayer(){
   float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float velocidadeX = (horizontal * this.speed);
        float velocidadeY = (vertical * this.speed);

        this.rigidbody.velocity = new Vector2(velocidadeX, velocidadeY);
    }
    void Attack(){
        
           if (Input.GetMouseButtonDown (0)){
                 Instantiate(player_Bullet,attack_Point.position, Quaternion.identity);              
                }
           }
   public void TakeDamage(int damage){
        life -= damage;
        barra.SetHelth(life);

         if (life==0){
           Destroy(gameObject);
       }
    }
    public void TakeLife(int lifeBonus){
        life += lifeBonus;
        if(life > 5){
            life-=lifeBonus;
        }
        barra.SetHelth(life);
    }
}