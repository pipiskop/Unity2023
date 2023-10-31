using UnityEngine;

public class manaPickup : MonoBehaviour
{
    public float manaAmount = 20f; // ���������� ����������������� ����� ������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ��������, ��� ������, � ������� ��������� ���������������, �������� �������
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                // �������������� ����� ������ ������
                player.RestoreMana(manaAmount);

                // ����������� �������, ��� ��� �� ��� ��������
                Destroy(gameObject);
            }
        }
    }
}
