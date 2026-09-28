using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToDrop = 3f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;
        myRigidbody = GetComponent<Rigidbody>();
        myRigidbody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > timeToDrop && Time.time < timeToDrop + 2f)
        {
            myMeshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
