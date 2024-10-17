using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    public Respond_Button_Pyer CallMethod;

    void Start()
    {
       CallMethod  = GetComponent<Respond_Button_Pyer>();
       
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            CallMethod.Move_Left();
        }
        else if(Input.GetKey(KeyCode.D))
        {
            CallMethod.Move_Right();
        }
        else if(Input.GetKey(KeyCode.W))
        {
            CallMethod.Make_Jump();
        }
        else if(Input.GetKey(KeyCode.E))
        {
            CallMethod.SetFaster();
        }
        else if(Input.GetKey(KeyCode.Q))
        {
            CallMethod.SetSlower();
        }
        else
        {
            CallMethod.Stop_Right();
            CallMethod.Stop_Left();
        }
        /*
        var GetInput = Input.inputString;
        //CallMethod = GetComponent<Respond_Button_Pyer>();
        if (!string.IsNullOrEmpty(GetInput))
        {
            switch (GetInput)
            {
                case 'A':
                    CallMethod.Move_Left();
                    break;

                case 'D':
                    CallMethod.Move_Right();
                    break;

                case 'W':
                    CallMethod.Make_Jump();
                    break;

                case 'E':
                    CallMethod.SetFaster();
                    break;

                case 'Q':
                    CallMethod.SetSlower();
                    break;

                case 'S':
                    CallMethod.Stop_Right();
                    CallMethod.Stop_Left();
                    break;
            }
        }
        */
    }
    
}
