using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    public int cardValue; //ī�� �� (ī�� �ܰ�)
    public Sprite cardImage;//ī�� �̹���
    public TextMeshPro cardText;// ī�� �ؽ�Ʈ
    // ī�� ���� �ʱ�ȭ �Լ�
    public void InitCard(int value, Sprite image)
    {
        cardValue = value;
        cardImage = image;

        //ī�� �̹��� ����
        GetComponent<SpriteRenderer>().sprite = image; // �ش� �̹����� ī�忡 ǥ��
        
        
        
        // ī�� �ؽ�Ʈ ����(�ִ� ���)
        if (cardText != null)
        {
            cardText.text = cardValue.ToString(); // ī�尪�� ǥ���Ѵ�.
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
