using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("me dice de algo");
        Debug.LogWarning("me dice de algo raro");
    }

    // Update is called once per frame
    void Update()
    {
        int x;
        Debug.LogError("me dice de algo malo");
        x = x + 1;
        Debug.LogError(x);
    }
}
