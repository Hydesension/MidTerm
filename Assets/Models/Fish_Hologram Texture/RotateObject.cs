using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 rotationAxis = new Vector3(0, 1, 0); // ��˹�᡹�����ع (���������鹤����ع�ͺ᡹ Y)
    public float rotationSpeed = 50f; // ��������㹡����ع

    void Update()
    {
        transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
    }
}