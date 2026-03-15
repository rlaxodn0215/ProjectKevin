using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public Vector3 rotationSpeed = new Vector3(0f, 45f, 0f); // Y ekseninde saniyede 45 derece

    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime);
    }
}
