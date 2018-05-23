using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MainController : MonoBehaviour {

    // Use this for initialization
    public GameObject road;
    public GameObject obstacle;
    private float lenRoad = 1.99f;
    private float wRoad = 1.58f;
    public Transform VRcamera;
    private float toogle = 20f;
    private int currentX = 1;
    private float currentChange = 0.5266f;
    private int flagMove = 0;//1 move left ,2 move right
    private bool flagCheck = true;
    private bool flagCurrentLane = true;
// public GameObject roads;
    void Start () {
        //Khoi tao duong
        for (int i =0;i < 10; i++)
        {
            CreateObject(road, Vector3.forward * lenRoad * i);
        }
        //Get Camera: 
	}
	void CreateObject(GameObject _go, Vector3 pos)
    {
        GameObject go = Instantiate(_go) as GameObject;
        //GameObject ob = Instantiate(obstacle) as GameObject;
        go.transform.SetParent(transform);
        //ob.transform.SetParent(go.transform );  
        //ob.transform.Translate(Vector3.back * lenRoad/2);
        
        //int ind = Random.Range(0, 3);
        //ob.transform.Translate(new Vector3(arr4Random[ind], 0, 0));
        go.transform.position = pos;
    }

    int Controll()
    {
        //Debug.Log(VRcamera.eulerAngles.x);
        //Debug.Log(VRcamera.eulerAngles.z + "zzzz");
        //if (VRcamera.eulerAngles.x > 25 && VRcamera.eulerAngles.x < 75.0f)
        //{
        //    //Debug.Log("Down");
        //}
        //else if (VRcamera.eulerAngles.x < 360 && VRcamera.eulerAngles.x > 285.0f)
        //{
        //   // Debug.Log("forward");
        //}
        //else if (VRcamera.eulerAngles.x >= 0 && VRcamera.eulerAngles.x < 5.0f)
        //{
        //   // Debug.Log("forward");
        //}
        //else
        //{
            
        //}

        //if (VRcamera.eulerAngles.y > toogle && VRcamera.eulerAngles.y < 90.0f)
        //{
            
        //    //Debug.Log("Right");
           
        //}
        //else if (VRcamera.eulerAngles.y < 360 - toogle && VRcamera.eulerAngles.y > 180.0f)
        //{
        //    //Debug.Log("Left");

        //}
        if (VRcamera.eulerAngles.z > toogle && VRcamera.eulerAngles.z < 75.0f)
        {
            
            Debug.Log("Left--");
            //right.gameObject.SetActive(true);
            //trans = VRcamera.TransformDirection(Vector3.forward);
            //this.transform.Translate(Vector3.right * Variables.speed * Time.deltaTime);
            return 1;       
        }
        else if (VRcamera.eulerAngles.z < 360 - toogle && VRcamera.eulerAngles.z > 285.0f)
        {
            Debug.Log("Right--");
            //this.transform.Translate(Vector3.left * Variables.speed * Time.deltaTime);
            return 2;
        }
        else
        {

            //test.OnPointerUp(null);
            return 0;
        }
    }
    // Update is called once per frame
    void Update () {
        if (flagCheck) flagMove = Controll();
        if (flagMove==1)//Queo trai 
        {
            Debug.Log("CAhy queo trai");
            flagCheck = false;
            print(currentX);
            if (currentX <= 1 && currentChange>=0)
            {

                //if (flagCurrentLane)
                //{
                //    currentX += 1;
                //    flagCurrentLane = false;
                //}
                Vector3 trans = Vector3.right * Variables.speed * Time.deltaTime;
                this.transform.Translate(trans);
                currentChange -= Mathf.Abs(trans.x);
            }
            else
            {
                //currentX = this.transform.position.x;
                currentChange = 0.5266f;
                flagCheck = true;
                if (currentX<2) currentX += 1;
            }
        }
        else if (flagMove == 2) //Queo phai
        {
            Debug.Log("CAhy queo phai");
            flagCheck = false;
            if (currentX >= 1 && currentChange >= 0)
            {
                //if (flagCurrentLane)
                //{
                //    currentX -= 1;
                //    flagCurrentLane = false;
                //}
                Vector3 trans = Vector3.left * Variables.speed * Time.deltaTime;
                this.transform.Translate(trans);
                currentChange -= Mathf.Abs(trans.x);
            }
            else
            {
                if (currentX>0) currentX -= 1;
               // currentX = this.transform.position.x;
                currentChange = 0.5266f;
                flagCheck = true;
            }
        }
	}
}
