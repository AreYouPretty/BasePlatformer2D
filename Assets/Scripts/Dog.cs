using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    float weight = 31.4f;
    int height = 40;//54;
    //bool master = true;
    string breed = "Овчарка";

    void Start()
    {
        //gameObject.transform.position = new Vector2(3f, 0f);

        if (weight > 35)
        {
            print("Вашей собаке желательно сбросить лишний вес.");
        }
        else
        {
            print("У вашей собаки всё отлично с весом.");
        }

        if (height <= 40 && breed != "Чихуахуа")
        {
            print("Ваша собака ещё не выросла.");
        }

    }
}
