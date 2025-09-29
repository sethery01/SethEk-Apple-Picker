using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed Difficulty Levels")]
    public float[] speedLevels;                 
    public float[] changeDirChanceLevels;      
    public float[] appleDropDelayLevels;       

    [Header("Runtime Settings")]
    public int currentLevel = 0;               

    public GameObject applePrefab;
    public float leftAndRightEdge = 10f;

    private float speed;
    private float changeDirChance;
    private float appleDropDelay;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        //else if (Random.value < changeDirChance)
        //{
        //    speed *= -1;
        //}
    }

    void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }

    public void SetDifficulty(int level)
    {
        currentLevel = Mathf.Clamp(level, 0, speedLevels.Length - 1);

        speed = speedLevels[currentLevel];
        changeDirChance = changeDirChanceLevels[currentLevel];
        appleDropDelay = appleDropDelayLevels[currentLevel];
    }
}
