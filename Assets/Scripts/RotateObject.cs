using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime);
    }
}
