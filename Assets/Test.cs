using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //MP

    // 攻撃用の関数
    public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

    // 防御用の関数
    public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }

    //発展課題、魔法攻撃用の関数
    public void Magic()
    {
        for (int a = 0; a <= 10; a++)
        {

                if (mp >= 5)
                {
                    this.mp -= 5;
                    Debug.Log("魔法攻撃をした。残りMPは" + mp);
                }

                else
                {
                    Debug.Log("MPが足りないため、魔法が使えない");
                }
        }
    }
}
public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // 通常課題1、int型の配列arrayの宣言と初期化
        int[] array = new int[5];

        // 配列の各要素に値を代入する
        array[0] = 10;
        array[1] = 20;
        array[2] = 30;
        array[3] = 40;
        array[4] = 50;

        // 通常課題2、配列の要素を順列表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        // 通常課題3、配列の要素を逆順表示
        for (int t = 4 ; t >= 0 ; t--)
        {
            Debug.Log(array[t]);
        }
        
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        //lastboss.Attack();
        // 防御用の関数を呼び出す
        //lastboss.Defence(3);

        //発展課題、魔法攻撃用の関数を呼び出す
        lastboss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}