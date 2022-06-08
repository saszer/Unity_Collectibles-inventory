using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace collectibles
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
        [SerializeField] private bool crossSceneCompatibility = true;
        void Awake()
        {
            if(crossSceneCompatibility)
                DontDestroyOnLoad(this.gameObject);
        }

   
    }

}
