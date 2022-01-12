using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    
     public Rigidbody2D rig;

    public float velocidade;
    public float velPulo;
    public bool EstaPulando;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao();
        Pulinho();

        
    }

    void Movimentacao()
    {
        float direcao = Input.GetAxis("Horizontal");
        rig.velocity = new Vector2(direcao*velocidade,rig.velocity.y);

        if(direcao > 0)
        {
           transform.eulerAngles = new Vector2(0,0);
        }
        if(direcao < 0)
        {
           transform.eulerAngles = new Vector2(0,180);
        }
        if(direcao == 0)
        {
           
        }
    }

    void Pulinho()
    {
       if(Input.GetKeyDown(KeyCode.W) && !EstaPulando)
       {
          rig.velocity = new Vector2(0,velPulo); 
       
       }
    }

   
     
}
