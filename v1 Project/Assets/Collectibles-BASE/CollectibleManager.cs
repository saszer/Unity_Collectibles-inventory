using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace collectibles
{
    public class CollectibleManager : MonoBehaviour
    {
        [SerializeField] List<bool> ItemsIcons = new List<bool>(); //to save on file
        [SerializeField] private GameObject ItemGroup;
        [SerializeField] private OpenClose Icon;
        [SerializeField] private GameObject inventorypanel;
        [SerializeField] private GameObject popup;
        [SerializeField] private TextMeshProUGUI UnOponednumbertext;

        public UnityEvent OnAnyCollectibleClicked;
        

        private Scene m_Scene;
        void Awake()
        {

            m_Scene = SceneManager.GetActiveScene(); //needed for playerpref storage
            
            
            foreach (Transform t in ItemGroup.transform) //Logic - icons are already there but not interactable hence we can create a list of all items from here.
            {
                ItemsIcons.Add(t); //add to list
            }
            
            
        }

        private void Start()
        {
            StartCoroutine(LoadCollectibleState());
        }

        public void UpdateItemsCollectedList()
        {
            int iteratelist = 0;
            foreach (Transform t in ItemGroup.transform)
            {
                ItemsIcons[iteratelist] = t.GetComponent<Button>().interactable;
                iteratelist++;
            }
            
            //To Autoopen Main panel on item click
            //Icon.OpenBasic();
            
            IconsNumberCheck();
            SaveCollectibleState();
        }

        public void IconsNumberCheck()
        {
            int u = 0;
            foreach (Transform t in ItemGroup.transform)
            {
                var ioc = t.GetComponent<IconOpenedCheck>();
                var unlocked = t.GetComponent<Button>().interactable;
                if (ioc.iconchecked == false && unlocked == true)
                {
                    ioc.EnableTop();
                    u++;
                }
                
            }

            UnOponednumbertext.text = u.ToString();
            if (u == 0)
            {
                popup.SetActive(false);
            }
            else
            {
                popup.SetActive(true);
            }
        }

        void SaveCollectibleState()
        {
           // PlayerPrefs.SetInt(m_Scene + "ItemsIconsListCount", ItemsIcons.Count);

            for (int i = 0; i < ItemsIcons.Count; i++)
                PlayerPrefs.SetInt(Application.productName+ m_Scene.name + "ItemsIconsList" + i, (ItemsIcons[i] ? 1 : 0));
        }

        IEnumerator  LoadCollectibleState()
        {
            for (int i = 0; i < ItemsIcons.Count; i++)
                ItemsIcons[i] = (PlayerPrefs.GetInt((Application.productName+ m_Scene.name + "ItemsIconsList" + i)) != 0);
            
           
            int iteratelist = 0;
            
            foreach (Transform t in ItemGroup.transform)
            {
                t.GetComponent<Button>().interactable = ItemsIcons[iteratelist];
                yield return new WaitForSeconds(0.2f); // this is needed cuz playerprefs bugs out if many pulls are made together-sz trial n error;
                t.GetComponent<IconOpenedCheck>().LoadState();
                
                
                iteratelist++;
                
            }
            inventorypanel.SetActive(false);
            IconsNumberCheck();
            
        }
        
    }

}
