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
        float chasedirx = this.transform.position.x - this.chaseObject.transform.position.x;
        float chasediry = this.transform.position.y - this.chaseObject.transform.position.y;

        float chasedirlength = Mathf.Sqrt(chasedirx * chasedirx + chasediry * chasediry);

        transform.Translate(chasedirx / chasedirlength / 10, chasediry / chasedirlength / 10, 0);
        
        //transform.position.x += chasedirx / chasedirlength;
    }
}
