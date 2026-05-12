using UnityEngine;

public class InputScript : MonoBehaviour
{

    [SerializeField] float velocidade = 10.0f;

    
    void Update()
    {
        // ACELERA플O DE DESACELERA플O
        // print(Input.GetAxis("Horizontal"));
        // print(Input.GetAxis("Vertical"));
        // SEM ACELERA플O E DESACELERA플O
        // print(Input.GetAxisRaw("Horizontal"));

        // float mover_x = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        // float mover_x = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        // transform.Translate(mover_x, 0.0f, 0.0f);
        // transform.Rotate(0.0f, 0.0f, mover_x);



    }
}
