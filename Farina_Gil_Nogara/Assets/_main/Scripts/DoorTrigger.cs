using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField] private GameObject door;
    //[SerializeField] private float doorOffsetX = 0f;
    //[SerializeField] private float doorOffsetY = 0f;
    //[SerializeField] private float speed = 5f;
    [SerializeField] private Vector2 moveDirection;
    private bool keyObtain = false;
    //Vector3 startingPos;

    private void Start()
    {
        keyObtain = false;
       //startingPos = door.transform.position;
    }
    
    //Esto es lo que pasa cuando el player interactua con las llaves del nivel.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        keyObtain = true;
        //Destroy(door.gameObject); La idea original era que se destruyan las puertas.
        //door.transform.position += moveDirection * speed * Time.deltaTime;
        Update();
    }

    void Update()
    {
        
        if (keyObtain == true)
        {
            door.transform.Translate(moveDirection * Time.deltaTime);
            //door.transform.Translate(doorOffsetX * Time.deltaTime, doorOffsetY * Time.deltaTime, 0f);
        }
    }
}
