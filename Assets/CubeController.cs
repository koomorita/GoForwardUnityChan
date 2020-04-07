using UnityEngine;
using System.Collections;
using System;

public class CubeController : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GameObject ground = GameObject.Find("BG");
        GameObject CubePrefab = GameObject.Find("cube");
    }

    // Update is called once per frame
    void Update()
    {
      


        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        //地面に衝突したか、ブロック同士で衝突したか。

        if (collision.gameObject.tag == "BG")
        {
            audioSource.PlayOneShot(sound1);

        }

        if (collision.gameObject.tag == "cube")
        {
            audioSource.PlayOneShot(sound1);

        }

    }

}