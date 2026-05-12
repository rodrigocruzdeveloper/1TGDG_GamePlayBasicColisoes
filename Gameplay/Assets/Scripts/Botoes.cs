using UnityEngine;

public class Botoes : MonoBehaviour
{   
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            print("Down");
        }
        else if (Input.GetButton("Fire1"))
        {
            print("Button");
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            print("Up");
        }
        
    }
}
