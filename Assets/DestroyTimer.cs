using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public float Timer { get; private set; } = 0.75f;
    
    void Update()
    {
        if(Timer <= 0)
        {
            Destroy(gameObject);
        } else
        {
            Timer -= Time.deltaTime;
        }
    }

    public void SetTimer(float timer)
    {
        Timer = timer;
    }
}
