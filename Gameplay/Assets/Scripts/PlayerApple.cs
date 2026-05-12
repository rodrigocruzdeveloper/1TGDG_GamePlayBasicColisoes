using UnityEngine;

public class PlayerApple : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private int score;

    void Start()
    {
        score = 0;
        transform.position = new Vector2(0.0f, -3.0f);
    }

    void Update()
    {
        // MOVIMENTAÇÃO
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, y, 0.0f);
    }

   
}
