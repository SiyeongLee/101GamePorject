using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{public float MoveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -MoveSpeed * Time.deltaTime);//�� ���̳ʽ� �������� �̵�
        if (transform.position.z < -20)// ť�갡 z������ -20 ���Ϸ� ������ Ȯ��
        Destroy(gameObject);
    }
}
