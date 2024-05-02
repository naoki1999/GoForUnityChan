using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSE : MonoBehaviour
{
    //SE
    public AudioSource audioSource;
        
    //Cubeのオブジェクト
    private GameObject Cube;

    //Groundのオブジェクト
    private GameObject ground;

    // Start is called before the first frame update
    void Start()
    {
        //オーディオコンポーネントを取得する
        audioSource = GetComponent<AudioSource>();

        //グラウンドのコンポーネントを取得する
        this.ground = GetComponent<GameObject>();

        //キューブのコンポーネントを取得する
        this.Cube = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //生成されたキューブがキューブと接触した場合SEを流す
        if (collision.gameObject.tag == "CubeTag")
        {
            audioSource.Play();
        }
        //生成されたキューブが地面に着地した場合もSEを流す
        if (collision.gameObject.tag == "GroundTag")
        {
            audioSource.Play();
        }
       
    }
}
