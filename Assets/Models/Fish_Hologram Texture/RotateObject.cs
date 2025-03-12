using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationAxis = new Vector3(0, 1, 0); // กำหนดแกนการหมุน (ค่าเริ่มต้นคือหมุนรอบแกน Y)
    public float rotationSpeed = 50f; // ความเร็วในการหมุน

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}