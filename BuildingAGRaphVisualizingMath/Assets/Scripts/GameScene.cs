using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public Transform cube;
    public Transform mainPlayer;
    Transform[] points;



    void Start()
    {



    }

    void Awake()
    {

        Vector3 position = Vector3.zero;
        float step = 2f / 50;
        points = new Transform[50];
        for (int i = 0; i < 50; i++)
        {
            Transform point = Instantiate(cube);
            points[i] = point;
            point.SetParent(transform, false);
            print(mainPlayer.transform.position);
            position.x = (i + 0.5f) * step - 1f;
            point.localPosition = position;
            point.localScale = new Vector3(0.04f, 0.04f, 0.04f);
            print(point.position);
        }
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 50; i++)
        {
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + Time.time));
            point.localPosition = position;
        }





    }
}
