using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoPlayer : MonoBehaviour
{

    public float velocidade;
    Vector3 victor;

    void Update(){ //roda a cada frame do jogo

        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");

        victor = new Vector3(eixoX, 0, eixoZ);

        //transform.Translate(victor * Time.deltaTime); diz pra andar 1 grid por sec. Delta time tem a ver com o run time da unity

        

        if(victor != Vector3.zero) //gatilhos pra começar ou parar animações de correr e parado
        {
            GetComponent<Animator>().SetBool("Correndo", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Correndo", false);
        }
    }

    private void FixedUpdate() //roda em tempo fixo (0,02 sec)
    {
        GetComponent<Rigidbody>().MovePosition(
            GetComponent<Rigidbody>().position 
            + (victor * velocidade * Time.deltaTime));
    }
}
