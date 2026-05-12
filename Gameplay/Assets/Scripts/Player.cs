using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speedMovement;
    [SerializeField] private float speedRotation;

    void Update()
    {
        float rotation_z = Input.GetAxis("Horizontal") * speedRotation * Time.deltaTime;
        transform.Rotate(0.0f, 0.0f, rotation_z);
        
        float movement_y = Input.GetAxis("Vertical") * speedMovement * Time.deltaTime;
        transform.Translate(0.0f, movement_y, 0.0f);

        if (Input.GetButtonDown("Jump"))
        {
            transform.position = new Vector2(0.0f, 0.0f);
            transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        }

    }
}
