using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {  
	//MonoBehaviourコンポーネントとして引っ付けることができるクラスのこと
    public float rotSpeed=30.0f;
	public Color c;
	public Vector3 vec;

	// Use this for initialization
	void Start () {  //プレイボタン押したときに一回だけ実行される
		vec = new Vector3(0,0,1);
	
	}
	
	// Update is called once per frame
	void Update () {  //１フレーム６０回描画している
        transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed, Space.World);
		
    }
}
