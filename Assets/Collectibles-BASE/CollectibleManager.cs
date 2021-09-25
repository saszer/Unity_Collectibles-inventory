using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace collectibles
{
    public class CollectibleManager : MonoBehaviour
    {
        [SerializeField] List<bool> ItemsIcons = new List<bool>(); //to save on file
        [SerializeField] private GameObject ItemGroup;
        [SerializeField] private OpenClose Icon;

        void Start()
        {
            foreach (Transform t in ItemGroup.transform) //Logic - icons are already there but not interactable hence we can create a list of all items from here.
            {
                ItemsIcons.Add(t); //add to list
            }

            UpdateItemsCollectedListFromGame(); //Load initialstate from editor
            LoadCollectibleState();
        }

        public void UpdateItemsCollectedListFromGame()
        {
            int iteratelist = 0;
            foreach (Transform t in ItemGroup.transform)
            {
                ItemsIcons[iteratelist] = t.GetComponent<Button>().interactable;
                iteratelist++;
            }

            Icon.OpenBasic();

            SaveCollectibleState();
        }

        void SaveCollectibleState()
        {
            //Save ItemsIcons to Cloud Or file or Cache
            
            //string json = JsonUtility.ToJson(ItemsIcons, false);
        }

        void LoadCollectibleState()
        {
            //Load ItemsIcons from Cloud or File or Cache

            UpdateItemsCollectedListfromSavedFile();

        }

        void UpdateItemsCollectedListfromSavedFile()
        {
            //read saved data according to format and update game state >

            /*
            foreach (Transform t in ItemGroup.transform)
            {
                t.GetComponent<Button>().interactable = 
            }
             */
        }

    }

}
