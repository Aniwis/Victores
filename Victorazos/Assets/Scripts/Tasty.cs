using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasty : MonoBehaviour
{
    [SerializeField]
    Victor thefirst;
    [SerializeField]
    Victor thesecond;
    [SerializeField]
    [Range(0, 1)]
    public float range = 0.0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        thefirst.Draw();
        thesecond.Draw();
        var diffVictor = thesecond.Resta(thefirst);
        diffVictor.Multi(range).Draw();
        diffVictor.Draw(thefirst);
        thefirst.lerp(thesecond,range).Draw();
    }
}
