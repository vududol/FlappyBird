using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject Filler;
    public Transform spawnPos;

    float reSpawnTime = 2f;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if(reSpawnTime <=0)
        {
            //계속 만들어야되서 클론으로 만들어야됨
            GameObject FillerClone = Instantiate(Filler, spawnPos.position, spawnPos.rotation);
            FillerClone.GetComponent<Rigidbody2D>().velocity = Vector2.left;
            FillerClone.transform.position = new Vector3(FillerClone.transform.position.x,
                Random.Range(-1.0f, 1.0f),
                FillerClone.transform.position.z);
            //생성후 리스폰타임을 1로 해서 다시 1초뒤에 생성되게 함
            reSpawnTime = Random.Range(1.5f, 4f);

        }
        //1프레임마다
        reSpawnTime -= Time.deltaTime;
        //up뒤에 Time.deltaTime을 붙이면 1프레임마다에서 1초마다로 변경됨
        //transform.position = Vector2.up * Time.deltaTime;
    
    }
}
