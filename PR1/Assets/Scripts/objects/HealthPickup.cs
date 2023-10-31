using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float healthAmount = 20f; // ���������� ����������������� ����� ������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ��������, ��� ������, � ������� ��������� ���������������, �������� �������
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                // �������������� ����� ������ ������
                player.RestoreHealth(healthAmount);

                // ����������� �������, ��� ��� �� ��� ��������
                Destroy(gameObject);
            }
        }
    }
}
