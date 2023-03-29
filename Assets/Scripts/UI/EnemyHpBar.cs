using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBar : MonoBehaviour
{
    // ** ����ٴ� ��ü
    public GameObject Target;

    // ** ������ġ ����
    public Vector3 offset;

    public void Start()
    {
        // ** ��ġ ����
        offset = new Vector3(2.5f, 1.0f, 0.0f);
    }

    private void Update()
    {
        // ** WorldToScreenPoint = ������ǥ�� ī�޶� ��ǥ�� ��ȯ.
        // ** ����� �ִ� Ÿ���� ��ǥ�� ī�޶� ��ǥ�� ��ȯ�Ͽ�, UI�� �����Ѵ�.

        if (Target)
            transform.position = Camera.main.WorldToScreenPoint(Target.transform.position + offset);
        else
            Destroy(this.gameObject);
    }

}
