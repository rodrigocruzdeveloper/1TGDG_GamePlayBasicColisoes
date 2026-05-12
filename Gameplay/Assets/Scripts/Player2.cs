using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector2 initalPosition;
    [SerializeField] private float leftLimit, rightLimit, upLimit, bottomLimit;

    void Start()
    {
        transform.position = initalPosition;
    }

    
    void Update()
    {
        // ESCALA
        if (Input.GetButton("Fire1"))
        {
            transform.localScale = new Vector2(2.0f, 2.0f);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            transform.localScale = new Vector2(1.0f, 1.0f);
        }

        // MOVIMENTAÇÃO
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float y = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(x, y, 0.0f);

        // lIMITE DA CAMERA
        if ((transform.position.x < leftLimit || transform.position.x > rightLimit) || 
            (transform.position.y < bottomLimit || transform.position.y > upLimit))
        {
            transform.position = Vector2.zero;
        }

    }
}
