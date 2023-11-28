// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class FishCounter : MonoBehaviour
// {
//     private int fishCounter = 0;

//     [SerializeField] private Text fishText;

//     private void OnTriggerEnter2D(Collider2D collision){
//         if(collision.gameObject.CompareTag("fish")){
//             Destroy(collision.gameObject);
//             fishCounter++;
//             fishText.text = "Fish: " + fishCounter;
//         }
//     }

// }
