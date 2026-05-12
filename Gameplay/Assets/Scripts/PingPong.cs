using UnityEngine;

public class PingPong : MonoBehaviour
{
    [SerializeField] float velocidade;


    // CPU (PROCESSADOR)
    void Update()
    {
        // transform.Translate(1.0f * Time.deltaTime, 0.0f, 0.0f);
         transform.Rotate(0.0f, 0.0f, 50.0f * Time.deltaTime);
    }
}
