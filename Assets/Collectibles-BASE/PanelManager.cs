using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace collectibles
{

    public class PanelManager : MonoBehaviour
    {
        [SerializeField] private GameObject ItemGroup;
        [SerializeField] private RectTransform firstpanel;

        public Panel[] ps;

        private void Awake()
        {
            ps = ItemGroup.GetComponentsInChildren<Panel>();
        }

        void Start()
        {
            /*
            Vector3 min = firstpanel.TransformPoint(firstpanel.rect.min);
            Vector3 max = firstpanel.TransformPoint(firstpanel.rect.max);
            foreach (var p in ps)
            {
                 p.transform.localScale = new Vector3(Mathf.Abs(min.x - max.x) , Mathf.Abs(min.y - max.y), 1f);
                 p.transform.position = firstpanel.TransformPoint(firstpanel.rect.center);
            }
            */
        }

        private void OnEnable()
        {
            OpenClose.OnClicked += CloseAllPanels;
        }

        public void CloseAllPanels()
        {
            foreach (var p in ps)
            {
                p.gameObject.SetActive(false);
                p.gameObject.transform.parent.GetComponent<OpenClose>().state = false;
            }
        }

    }
}
