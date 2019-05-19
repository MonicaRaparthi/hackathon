using UnityEngine;
using UnityEngine.AI;
using System;
using System.IO;

public class PlayerController : MonoBehaviour
{

    public Camera cam;

    public NavMeshAgent agent;

    //public void changescreen(string itemname)
    //{
    //    Debug.Log("Item Name: " + itemname);
    //}

    // Update is called once per frame

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        Debug.Log("Hit position" + hit.point);
        //        agent.SetDestination(hit.point);
        //        //agent.SetDestination(new Vector3((float)-9.4, (float)0.5, (float)0.2));
        //    }
        //}
        Vector3 vct;
        String var = "bread";
        String[] values = File.ReadAllText("data.txt").Split('\n');
        int ln = values.Length;
        for (int i = 1; i < ln; i++)
        {
            String[] dest = values[i].Split('\t');
            if (dest[0] == var)
            {
                String[] pos = dest[1].Split(',');
                vct = new Vector3(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]));
                Debug.Log(vct);
                agent.SetDestination(vct);
            }

        }

    }
}
