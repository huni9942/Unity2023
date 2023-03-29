using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHpBar : MonoBehaviour
{
    // ** ����ٴ� ��ü
    public GameObject Target;

    // ** ������ġ ����
    public Vector3 offset;


    public void Start()
    {
        // ** ��ġ ����
        offset = new Vector3(0.0f, 0.6f, 0.0f);
    }

    private void Update()
    {
        // ** WorldToScreenPoint = ������ǥ�� ī�޶� ��ǥ�� ��ȯ.
        // ** ����� �ִ� Ÿ���� ��ǥ�� ī�޶� ��ǥ�� ��ȯ�Ͽ�, UI�� �����Ѵ�.
        transform.position = Camera.main.WorldToScreenPoint(Target.transform.position + offset);
    }

}
