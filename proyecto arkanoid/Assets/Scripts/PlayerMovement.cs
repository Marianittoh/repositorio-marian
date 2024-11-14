
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f; // Velocidad de movimiento
    private float movementInput;  // Valor de entrada del movimiento (A/D o flechas)

    // Update se llama una vez por cuadro
    void Update()
    {
        // Obtener la entrada horizontal (teclas A/D o flechas izquierda/derecha)
        movementInput = Input.GetAxis("Horizontal");

        // Mover al jugador de forma horizontal
        Vector3 move = new Vector3(movementInput, 0f, 0f) * moveSpeed * Time.deltaTime;

        // Aplicar el movimiento al jugador
        transform.Translate(move);
    }

}
