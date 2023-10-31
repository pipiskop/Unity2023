using UnityEngine;

public class Snarad : MonoBehaviour
{
    public float speed = 5f; // �������� �������� ��������

    void Update()
    {
        // ������� ������� ������
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // ��������� ������������ � ������� ���������
        if (other.CompareTag("Enemy"))
        {
            // ������� �� ������������ � ������, ��������, ����������� �����
            Destroy(other.gameObject);

            // ���������� �������
            Destroy(gameObject);
        }
    }
}
