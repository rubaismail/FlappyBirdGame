using UnityEngine;

public class PipeSpwanerScript : MonoBehaviour
{
    public GameObject pipe;
    public double spwanRate = 4.4;
    private float timer = 0;
    public float heightOffset = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spwanPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spwanRate)
            timer+= Time.deltaTime;
        else
        {
            spwanPipe();
            timer = 0;
        }
    }

    void spwanPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
