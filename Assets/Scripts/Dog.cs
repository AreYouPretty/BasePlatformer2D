using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    float weight = 31.4f;
    int height = 40;//54;
    //bool master = true;
    string breed = "�������";

    void Start()
    {
        //gameObject.transform.position = new Vector2(3f, 0f);

        if (weight > 35)
        {
            print("����� ������ ���������� �������� ������ ���.");
        }
        else
        {
            print("� ����� ������ �� ������� � �����.");
        }

        if (height <= 40 && breed != "��������")
        {
            print("���� ������ ��� �� �������.");
        }

    }
}
