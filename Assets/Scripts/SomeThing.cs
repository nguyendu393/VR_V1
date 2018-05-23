using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeThing : MonoBehaviour{
    protected static float speed = 1;
	protected void Update_frame()
    {
        this.transform.Translate(Vector3.back * Variables.speed * Time.deltaTime);
    }
    protected bool Destroy()
    {
        if(this.transform.position.z <= Variables.minZ)
        {
            Destroy(gameObject);
            return true;
        }
        return false;
    }
}
