using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{

    private float velocidadePlayer;
    public float velocidadeCorrida = 10;
    public float velocidadeAndar = 5;                           
    public Camera cameraPlayer;
    private Vector3 direcoes;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    { 
        float InputX = Input.GetAxis("Horizontal");
        float InputZ = Input.GetAxis("Vertical");
        float InputRun = Input.GetAxis("correr");
       

        direcoes = new Vector3(InputX,0, InputZ);
        if(InputX != 0|| InputZ != 0)
        {
            var camrotation = cameraPlayer.transform.rotation;
            camrotation.x = 0;
            camrotation.z = 0;
            anim.SetBool("Andar", true);
            transform.Translate(0, 0, velocidadePlayer * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(direcoes) * camrotation, 5 * Time.deltaTime);

            if(InputRun != 0)
            { 
                anim.SetBool("Correr", true);
                velocidadePlayer = velocidadeCorrida;        
            }
            else
            {
                anim.SetBool("Correr", false);
                velocidadePlayer = velocidadeAndar;
            }
        }
        else if (InputX == 0 && InputZ == 0)
        {
            anim.SetBool("Andar", false);
            anim.SetBool("Correr", false);
        }
    }
}

