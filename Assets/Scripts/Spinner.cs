using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] int typeOfSpin = 0; // 0 = x, 1 = y, 2 = z
    [SerializeField] float spinSpeed = 90f;


    void Start()
    {
       
    }

    void Update()
    {
        if(typeOfSpin == 0)
        {
            transform.Rotate(spinSpeed * Time.deltaTime, 0, 0);
        }
        else if(typeOfSpin == 1)
        {
            transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
        }
        
    }
}
