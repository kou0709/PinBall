using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    //�{�[����������\���̂��邚���̍ŏ��l
    private float visiblePoeZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;

    private GameObject scoreText;

    private int score = 0;

    private int small = 10;

    private int large = 20;




    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");

        this.scoreText = GameObject.Find("ScoreText");
        
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʂ��o���ꍇ
        if (this.transform.position.z < this.visiblePoeZ)
        {
            //GameoverText�ɃQ�[���I�[�o�[��\��
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
        
        this.scoreText.GetComponent<Text>().text = score + "�_";
    }
}
