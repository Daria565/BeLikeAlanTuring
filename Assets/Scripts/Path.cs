using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Path : MonoBehaviour
{
    Transform[] fields;
    public List<Transform> fieldsList = new List<Transform>() ;
    // Start is called before the first frame update


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        FillFields();
        for (int i = 0; i < fieldsList.Count; i++)
        {
            Vector3 currentPosition = fieldsList[i].position;
            if (i > 0)
            {
                Vector3 previousPosition = fieldsList[i-1].position;
                Gizmos.DrawLine(previousPosition, currentPosition);
            }
        }
    }

    void FillFields()
    {
        fieldsList.Clear();
        fields = GetComponentsInChildren<Transform>();
        foreach (Transform field in fields)
        {
            if (field != this.transform)
            {
                fieldsList.Add(field);
            }
        }
    }
}
