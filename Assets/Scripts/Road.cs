using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road :SomeThing {

    // Use this for initialization
    private float[] arr4Random = new float[] { -0.5266f, 0f, 0.5266f };
    void Start () {
		
	}

    // Update is called once per frame
    void createObstacle()
    {
        GameObject ob = GetObject.Instance.GetGameObject("Sphere");
        GameObject ob2 = Instantiate(ob) as GameObject;
        Debug.Log(ob.transform.position);
        ob2.transform.SetParent(this.transform);
        ob2.transform.position = this.transform.position;
        ob2.transform.Translate(Vector3.back * 1.99f / 2);

        int ind = Random.Range(0, 3);
        ob2.transform.Translate(new Vector3(arr4Random[ind], 0, 0));
    }
    new bool Destroy()
    {
        if (this.transform.position.z <= Variables.minZ)
        {
            Vector3 temp = this.transform.position;
            temp.z = Variables.maxZ;
            this.transform.position = temp;
            if (Random.Range(0, 2) == 0)
                createObstacle();
        }
        return false;
    }
    void Update () {
        base.Update_frame();
        Destroy();
	}
}
