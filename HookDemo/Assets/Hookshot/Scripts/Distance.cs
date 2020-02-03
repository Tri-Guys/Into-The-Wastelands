using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Distance : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public GameObject Player;
    public GameObject thing;
    private float Distance_X;
    private float Distance_Y;
    private float Distance_Z;
    private float Distance_;
    private string distanceText;
    void Start()
    {
        {
            textMesh = GetComponent<TextMeshProUGUI>();
        }
    }

    void Update()
    {

        //Distance_ = Mathf.Abs(Player.transform.position - thing.transform.position);


        Distance_X = Mathf.Abs(Player.transform.position.x - thing.transform.position.x);
        Distance_Y = Mathf.Abs(Player.transform.position.x - thing.transform.position.x);
        Distance_Z = Mathf.Abs(Player.transform.position.x - thing.transform.position.x);


        Distance_ = Distance_X + Distance_Y + Distance_Z;
       // Distance_ = Vector3.Distance(Player.transform.position, thing.transform.position);

        /* Distance_X = Mathf.Abs(Player.transform.position.x - thing.transform.position.x);
         Distance_Y = Mathf.Abs(Player.transform.position.y - thing.transform.position.y);
         Distance_Z = Mathf.Abs(Player.transform.position.z - thing.transform.position.z); (/)
         Distance_ = Vector3.Distance(Player.transform.position, thing.transform.position);  */
        //  Distance_ = Vector3.Distance(Player.transform.position, thing.transform.position);
        distanceText = Distance_.ToString();
        textMesh.text = distanceText;
    }
}
 