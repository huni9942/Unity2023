using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    private Image image;
    private int MaxHP = 1500;

    // Start is called before the first frame update
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            int damage = Random.Range(50, 150);

            image.fillAmount -= (damage * 100 / MaxHP) * 0.01f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            image.fillAmount = 1;
        }
    }
}
