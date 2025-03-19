using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Monster : MonoBehaviour
{
    public int Health = 100;        //ü���� ���� �Ѵ�. (����)
    public float Timer = 1.0f;      //Ÿ�̸Ӹ� ���� �Ѵ�.
    public int AttackPoint = 10;    //���ݷ��� �����Ѵ�.
    // ù ������ ������ �ѹ� ���� �ȴ�.
    void Start()
    {
        Health += 100; //ù ������ ������ ����ɶ� 100ü���� �߰� �����ش�.
    }

    // �Ź� ������ �� ȣ��ȴ�
    void Update()
    {

        void CharacterHealthUp()
        Timer -= Time.deltaTime; // �ð��� �� �����Ӹ��� ���� ��Ų��.(deltaTime �����Ӱ��� �ð� ������ �ǹ��Ѵ�.)

        if (Timer < 0)//���� TImer�� ��ġ�� 0���Ϸ� ������ ���    }
        {
            Timer = 1.0f; //�ٽ� 1�ʷ� ���� ���� �ش�.
            Health += 20; // 1�ʸ��� ü�� 20�� �÷��ش�
        }

        CharacterHealthUp();
        if (Input.GetKeyUp(KeyCode.Space)) //�����̽� Ű�� ������ �� 
        {
            CharacterHit(AttackPoint);  //Health -= AttackPoint; //ü�� ����Ʈ�� ���� ����Ʈ ��ŭ ���� �����ش�. (Health = Health - AttackPoint)ss
        }
        CheckDeath();//�Լ� ȣ��

        if (Health <= 0) // ü���� 0 ���Ϸ� �������� �ı� ��Ų��.
            Destroy(gameObject);
    }
        public svoid CharacterHit(int Damage)//Ŀ���� �������� �޴� �Լ��� ����Ѵ�.
    {
        Health -= Damage; //���� ���ݷ¿� ���� ü���� ���� ��Ų��.
    }

    void CheckDeath()
    {
        if (Health <= 0)// ü���� 0 ���Ϸ� �������� �ı� ��Ų��.
            Destroy(gameObject); //�� ������Ʈ�� �ı� �Ѵ�.
    }



}
   