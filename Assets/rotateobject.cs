using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateobject : MonoBehaviour{
     public GameObject chair;

float speed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {          if (Input.GetKey(KeyCode.A)){
        this.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
             if (Input.GetKey(KeyCode.D))  
        {  
            this.transform.Rotate(Vector3.down * speed * Time.deltaTime);  
        }  
    }
}
