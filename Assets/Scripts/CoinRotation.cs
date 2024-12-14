using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    // Rotation speed
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate around the Y-axis
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }
}
