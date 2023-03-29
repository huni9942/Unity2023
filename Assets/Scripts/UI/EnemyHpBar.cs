using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHpBar : MonoBehaviour
{
    // ** 따라다닐 객체
    public GameObject Target;

    // ** 세부위치 조정
    public Vector3 offset;

    public void Start()
    {
        // ** 위치 셋팅
        offset = new Vector3(2.5f, 1.0f, 0.0f);
    }

    private void Update()
    {
        // ** WorldToScreenPoint = 월드좌표를 카메라 좌표로 변환.
        // ** 월드상에 있는 타겟의 좌표를 카메라 좌표로 변환하여, UI에 셋팅한다.

        if (Target)
            transform.position = Camera.main.WorldToScreenPoint(Target.transform.position + offset);
        else
            Destroy(this.gameObject);
    }

}
