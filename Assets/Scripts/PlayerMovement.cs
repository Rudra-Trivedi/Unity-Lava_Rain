using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    
    public CharacterController2D Controller;
    float HorizontalMove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    

    
	// Use this for initialization
	void Start () {

        
        
    }
	
	// Update is called once per frame
	void Update () {

        
        
        HorizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        
	}

    void FixedUpdate()
    {
        Controller.Move(HorizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;

    }

    

   


   

}
