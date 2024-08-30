using System;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    // Start is called before the first frame update
   public static event Action OnCollected;
     public static int total;
     void Awake() => total++;
    // Update is called once per frame
    void Update()
    {
        
    }
     
    void OnTriggerEnter(Collider other)
       {
        if(other.CompareTag("Player"))
          {
            OnCollected?.Invoke();
            Destroy(gameObject);
          }
       }
}
