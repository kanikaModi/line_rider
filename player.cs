using UnityEngine;

public class player : MonoBehaviour {
    private Rigidbody2D rgd;
    void Start()
    {
        rgd = GetComponent<Rigidbody2D>();
    }
    public void playbutton()
    {
        rgd.bodyType = RigidbodyType2D.Dynamic;
    }
}
