using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PassarFaze : MonoBehaviour
{
   
    public Rigidbody2D rigidbody;
    public float velocidadeMinima;
    public float velocidadeMaxima;
    private float velocidadeY;
    public string nomeCenaJogo;

    // Start is called before the first frame update
    void Start()
    {   
        this.velocidadeY = Random.Range(this.velocidadeMinima, this.velocidadeMaxima);
    }

    // Update is called once per frame
    void Update()
    {
        this.rigidbody.velocity = new Vector2(-this.velocidadeY, 0 );
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.layer == 6){
            SceneManager.LoadScene(nomeCenaJogo);
       
      }
    }
}
