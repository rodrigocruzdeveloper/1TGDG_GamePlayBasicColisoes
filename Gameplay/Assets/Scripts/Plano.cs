using UnityEngine;

public class Plano : MonoBehaviour
{
    [SerializeField] Vector2 nova_posicao;
    [SerializeField] Vector3 nova_rotacao;
    [SerializeField] Vector2 nova_escala;

    private void Start()
    {
        // OBTEM AS INFORMAÇÕES DO COMPONENTE TRANSFORM E SUA PROPRIEDADE
        print("Posição: " + transform.position);
        print("Rotação: " + transform.eulerAngles);      // ROTAÇÃO EM GRAUS (EULER)
        print("Escala: " + transform.localScale);

        // ATRIBUINDO COM VALORES NUMÉRICOS
        transform.position = new Vector2(0.0f, 0.0f);

    }


    private void Update()
    {
        if (Input.anyKeyDown)
        {
            // ATRIBUINDO COM VARIAVEIS
            /*
            transform.position = nova_posicao;
            transform.eulerAngles = nova_rotacao;
            transform.localScale = nova_escala;*/

            // ALTERAR A POSIÇÃO DO MEU OBJETO ALEATORIAMENTE
            transform.position = new Vector2(Random.Range(-4.0f, 4.0f), Random.Range(-3.0f, 3.0f)); 

        }
    }

}
