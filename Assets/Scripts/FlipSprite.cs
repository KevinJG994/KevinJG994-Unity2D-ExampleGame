using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    private float movimientoHorizontal;

    void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal");

        // Cambiar la escala en el eje X para dar la vuelta el sprite
        if (movimientoHorizontal < 0)
        {
            transform.localScale = new Vector3(-2.742044f, 2.900258f, 1f); // Dar vuelta hacia la izquierda
        }
        else if (movimientoHorizontal > 0)
        {
            transform.localScale = new Vector3(2.742044f, 2.900258f, 1f); // No da la vuelta (orientación normal)
        }
    }
}
