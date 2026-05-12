using UnityEngine;

public class Controles : MonoBehaviour
{
    [SerializeField] float velocidade;
    [SerializeField] float velocidadeRotacao;
         
    void Update()
    {
        // INPUT E MOVIMENTO
        float x = velocidade * Input.GetAxis("Horizontal") * Time.deltaTime;
        float y = velocidade * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(x, y, 0.0f);

        // INPUT QUE RETORNA O VALOR PARA COORDENADA INDICADA
        if (Input.GetButtonDown("Fire1"))
        {
            transform.position = new Vector2(0.0f, 0.0f);
        }

        if (Input.GetButton("Fire2"))
        {
            transform.Rotate(0.0f, 0.0f, velocidadeRotacao * Time.deltaTime);
            GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (Input.GetButtonUp("Jump"))
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }        
    }
}
