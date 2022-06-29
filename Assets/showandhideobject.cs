
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showandhideobject : MonoBehaviour

{   
    public GameObject chair;
    
    
        
    
       public void showIt(){
        chair.SetActive(true);
        
    } 

    public void hideIt(){
        chair.SetActive(false);
        
    }
    

}
