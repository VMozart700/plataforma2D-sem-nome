using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerseguiPlayer : MonoBehaviour
{
    [SerializeField]
    private Transform  Player;

    [SerializeField]
    private Vector3 distancia;

    [SerializeField]
    private float lerpVal;

    [SerializeField]
    private Vector3 pos,AlvoPos;

    void Start()
    {
        distancia = Player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        PersegueFunc();
    }
    void LateUpadate()
    {
        
    }
    void PersegueFunc(){
        pos = transform.position;
        AlvoPos = Player.position-distancia;
        pos = Vector3.Lerp(pos,AlvoPos,lerpVal * Time.deltaTime);
        transform.position = pos;
    }
}
