using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentaCamera : MonoBehaviour
{

    public GameObject player;
    Vector3 posiCamera;

    //serve pra rodar uma vez, quando inicializado
    void Start()
    {
        posiCamera = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + posiCamera;
    }
}
