using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField]
    float Yrotation = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Yrotation * Time.deltaTime, 0.0f);
    }
}
