using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))// ���콺 ��ư�� ������
        {
            RaycastHit hit; //Ray ����
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);// ī�޶󿡼� ���̸� ���� �����Ѵ�.

            if (Physics.Raycast(ray, out hit)) // Hit �� ������Ʈ�� �����Ѵ�.
            {
                if (hit.collider != null) //Hit �� ������Ʈ�� �������
                {
                    Debug.Log

                }
}
