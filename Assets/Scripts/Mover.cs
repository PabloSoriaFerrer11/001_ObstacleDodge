using UnityEngine;

public class Mover : MonoBehaviour
{
    private float moveSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

       PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // Vamos a utilizar la forma "vieja" de mover el objeto. Se ha tenido que cambiar la configuración
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game!");
        Debug.Log("Move with WASD or Arrow Keys");
        Debug.Log("Don't hit the walls!");
    }
}
