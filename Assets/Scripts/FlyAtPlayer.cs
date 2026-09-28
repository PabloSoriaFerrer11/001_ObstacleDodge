using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float speed = 15f;
    private Vector3 playerPosition;

    void Awake() 
    {
        gameObject.SetActive(false);
        
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        DestroyOnReach();
    }

    private void DestroyOnReach()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
