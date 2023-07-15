using UnityEngine;

public class DestroyBaal : MonoBehaviour
{
    public void OnMouseDown()
    {
        ScoreManager.addPoint();
        Destroy(gameObject);
    }
}
