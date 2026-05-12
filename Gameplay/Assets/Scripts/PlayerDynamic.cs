using UnityEngine;

public class PlayerDynamic : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(x, 0.0f, 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        // Destroy(collision.gameObject);


        // EXECUTA QUANDO O OBJETO INICIA UM COLISÃO 
        // print("Enter");
        // GetComponent<SpriteRenderer>().color = Color.pink;

        if (collision.collider.tag == "Big")
        {
            Destroy(collision.gameObject);

            if (transform.localScale.x < 6.0f)
            {
                transform.localScale = transform.localScale * 2;
            }
        }
        else if(collision.collider.tag == "Small")
        {
            Destroy(collision.gameObject);

            if (transform.localScale.x > 1.0f)
            {
                transform.localScale = transform.localScale / 2;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // EXECUTA ENQUANTO O OBJETO ESTIVER COLIDINDO COM ALGO
        // print("Stay");
        // transform.localScale = new Vector2(2.0f, 2.0f);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // EXECUTA QUANDO O OBJETO PARA DE COLIDIR
        // print("Exit");
        // transform.localScale = new Vector2(1.0f, 1.0f);
    }

}
