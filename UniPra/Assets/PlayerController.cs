using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// プレイヤーの移動(操作)をここにまとめる
public class PlayerController : MonoBehaviour {

    public GameObject chaseObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // プレイヤーと対象の座標の差を取って、2次元ベクトルの成分とする
        float chasedirx = this.chaseObject.transform.position.x - this.transform.position.x;
        float chasediry = this.chaseObject.transform.position.y - this.transform.position.y;
        // 三平方の定理を使って対象への単位ベクトルを作成用のベクトルの長さ
        float chasedirlength = Mathf.Sqrt(chasedirx * chasedirx + chasediry * chasediry);
        // 単位ベクトルを用いてプレイヤーを移動させる
        transform.Translate(- chasedirx / chasedirlength / 10, chasediry / chasedirlength / 10, 0);
        
        if(chasedirlength < 1)
        {
            Destroy(chaseObject);
            
        }

    }
}
