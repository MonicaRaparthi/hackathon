using UnityEngine;
using UnityEngine.AI;
using System;
using System.IO;

public class ChangeScreen : MonoBehaviour
{
    public Camera cam;

    public NavMeshAgent agent;
    // Start is called before the first frame update
    public void button(string itemname)
    {
        Debug.Log("item Name : " + itemname);
        Vector3 vct;
        String var = "milk";
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
    public void button1(string itemname)
    {
        Debug.Log("item Name : " + itemname);
        Vector3 vct;
        String var = "tea bags";
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
    public void button2(string itemname)
    {
        Debug.Log("item Name : " + itemname);
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
    public void button3(string itemname)
    {
        Debug.Log("item Name : " + itemname);
        Vector3 vct;
        String var = "butter";
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
    public void button4(string itemname)
    {
        Debug.Log("item Name : " + itemname);
        Vector3 vct;
        String var = "jam";
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
    //public void button5(string itemname)
    //{
    //    Debug.Log("item Name : " + itemname);
    //    Vector3 vct;
    //    String var = "bread";
    //    String[] values = File.ReadAllText("/Users/z002qyt/data.txt").Split('\n');
    //    int ln = values.Length;
    //    for (int i = 1; i < ln; i++)
    //    {
    //        String[] dest = values[i].Split('\t');
    //        if (dest[0] == var)
    //        {
    //            String[] pos = dest[1].Split(',');
    //            vct = new Vector3(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]));
    //            Debug.Log(vct);
    //            agent.SetDestination(vct);
    //        }

    //    }
    //}
    //public void button6(string itemname)
    //{
    //    Debug.Log("item Name : " + itemname);
    //    Vector3 vct;
    //    String var = "bread";
    //    String[] values = File.ReadAllText("/Users/z002qyt/data.txt").Split('\n');
    //    int ln = values.Length;
    //    for (int i = 1; i < ln; i++)
    //    {
    //        String[] dest = values[i].Split('\t');
    //        if (dest[0] == var)
    //        {
    //            String[] pos = dest[1].Split(',');
    //            vct = new Vector3(float.Parse(pos[0]), float.Parse(pos[1]), float.Parse(pos[2]));
    //            Debug.Log(vct);
    //            agent.SetDestination(vct);
    //        }

    //    }
    //}

}
