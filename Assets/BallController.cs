using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるｚ軸の最小値
    private float visiblePoeZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    private GameObject scoreText;

    private int score = 0;

    private int small = 10;

    private int large = 20;




    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面を出た場合
        if (this.transform.position.z < this.visiblePoeZ)
        {
            //GameoverTextにゲームオーバーを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";

        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "SmallStarTag" || other. gameObject.tag == "SmallCloudTag") 
        {
            this.score += this.small;


        }

        else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag") 
        {
            this.score += this.large;
        }
        
        this.scoreText.GetComponent<Text>().text = score + "点";
    }
}
