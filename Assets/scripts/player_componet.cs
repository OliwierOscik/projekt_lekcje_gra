using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pllayer_componet : MonoBehaviour
{
    public float moveSpeed = 50f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //idzie w prawe sam
        //transform.position += new Vector3(1, 0, 3) * Time.deltaTime;
        //zczytuje klawe
        float x = Input.GetAxisRaw("Horizontal");

        //wysiwetluje stan klawy
        Debug.Log(x);

        //wylicz przesuniecie w osi x
        Vector3 movment = Vector3.right * x;

        //wylicz przesuniecie w osi y i dodaj istniejacego przesuniecia w osi x
        float y = Input.GetAxisRaw("Vertical");

        //wylicz przesuniecie w osi y i dodaj d istniejacego przesuniecia w osi x
        movment += Vector3.forward * y;

        //normalizujemy wektor
        movment = movment.normalized;

        //poprawka na czas od ostaniej klatki
        movment *= Time.deltaTime;

        //pomnó¿ przez prêdkoœæ ruchu
        movment *= moveSpeed;

        //przesun gracza w osi x
        transform.position += movment;


    }
}
