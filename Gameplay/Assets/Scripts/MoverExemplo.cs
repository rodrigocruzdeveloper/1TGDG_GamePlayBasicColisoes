using UnityEngine;

public class MoverExemplo : MonoBehaviour
{
    [SerializeField] float velocidade;

    void Update()
    {
        float mover_x = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        float mover_y = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(mover_x, mover_y, 0.0f);        
    }
}
