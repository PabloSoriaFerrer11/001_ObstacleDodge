using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] private GameObject[] projectiles;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player")
        {
            foreach(GameObject projectile in projectiles)
            {
                projectile.SetActive(true);    
            }
            Destroy(gameObject);
            
        }
    }
}
