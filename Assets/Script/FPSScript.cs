using UnityEngine;
using System.Collections;

public class FPSScript : MonoBehaviour {

	public GameObject gun;
	public GameObject dangan;
	public int zandan = 7; 

	public int walk = 0;

	public bool reload = false;
	public float reloadstart = 0;
	public int reloadend = 1;

	// Use this for initialization
	void Start () {
	}

	RaycastHit hit;
	// Update is called once per frame
	void Update () {
	
		UnityEngine.Cursor.visible = false;//マウスカーソル表示
		UnityEngine.Cursor.lockState = CursorLockMode.Locked;//カーソルを真ん中にロック
		float horz = Input.GetAxis ("Horizontal");//水平方向入力
		float vert = Input.GetAxis ("Vertical");//垂直方向入力
		float mousex = Input.GetAxis ("Mouse X");//X座標
		float mousey = Input.GetAxis ("Mouse Y");//Y座標

		transform.Rotate(Vector3.up * mousex * 200 * Time.deltaTime);//水平方向回転
		Camera.main.transform.Rotate(Vector3.left * mousey * 100 * Time.deltaTime);//垂直方向回転
		//Player.transform.Rotate(Vector3.up * mousey * 100 * Time.deltaTime);

		//attack
		if(Input.GetMouseButtonDown(0) && zandan >= 1 && reload == false){
			Instantiate(dangan,new Vector3 (gun.transform.position.x,gun.transform.position.y,gun.transform.position.z),
				Quaternion.Euler(0,0,0));
			zandan--;
		}
		//reload
		if(Input.GetMouseButtonDown(1)){
			zandan = 7;
			reload = true;
		}
		if(reload == true){
			reloadstart += Time.deltaTime;
		}
		if(reloadstart >= reloadend){
			reload = false;
		}

	

	}
}
