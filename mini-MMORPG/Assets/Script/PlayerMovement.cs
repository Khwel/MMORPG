using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Vitesse de déplacement du joueur

    public Rigidbody2D rb; // Référence au Rigidbody2D
    private Vector2 movement; // Stocke les inputs de direction

    void Update()
    {
        // Récupération des touches directionnelles (ZQSD ou flèches)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Appliquer le mouvement en multipliant par la vitesse
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
