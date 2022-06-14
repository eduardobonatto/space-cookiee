using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class atirar : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public int municao= 1;

    // Start is called before the first frame update
    void Start()
    {
   

    }

   void Update () {
         if (municao>0){
            Fire ();
         }
         
         recarregar ();
         

   }
   void Fire() {
      //Cria um Bullet apartir de BulletPrefab
      if (Input.GetMouseButtonDown (0)){
     var bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

    //Adiciona velocidade a Bullet
      bullet.GetComponent<Rigidbody2D>().velocity = bullet.transform.forward * 50;

      //Destruir bala depois de X segundos
     Destroy(bullet, 10);
     municao= municao-1;
      }
      
   }
   void recarregar (){
      if (Input.GetMouseButtonDown(1)){
         municao=5;
      }
   }
 }