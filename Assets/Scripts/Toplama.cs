using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplama : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D collision)
        {
            Skor.trashcount++;
            Destroy(gameObject);

        }
    }


