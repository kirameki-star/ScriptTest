using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53; //MP

    // �U���p�̊֐�
    public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }

    // �h��p�̊֐�
    public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            // �c��hp�����炷
            this.hp -= damage;
        }

    //���W�ۑ�A���@�U���p�̊֐�
    public void Magic()
    {
        for (int a = 0; a <= 10; a++)
        {

                if (mp >= 5)
                {
                    this.mp -= 5;
                    Debug.Log("���@�U���������B�c��MP��" + mp);
                }

                else
                {
                    Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
                }
        }
    }
}
public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // �ʏ�ۑ�1�Aint�^�̔z��array�̐錾�Ə�����
        int[] array = new int[5];

        // �z��̊e�v�f�ɒl��������
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // �ʏ�ۑ�2�A�z��̗v�f������\��
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // �ʏ�ۑ�3�A�z��̗v�f���t���\��
        for (int t = 4 ; t >= 0 ; t--)
        {
            Debug.Log(array[t]);
        }
        
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        //lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        //lastboss.Defence(3);

        //���W�ۑ�A���@�U���p�̊֐����Ăяo��
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}