using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LessonBasic
{
    public class FirstLessonScript : MonoBehaviour
    {   /// comment yani herhangi bir þey
        /// <summary>
        /// C# variables
        /// </summary>

        public int tamSayi = 1; //integar
        [SerializeField] int tamSayi2 = 100;
        float ondalikSayi = 0.25f;
        float ondalikSayi2 = 5.2342f;
        bool dogru = true;
        bool yanlis = false;

        [SerializeField] private Vector3 ucFloat = new Vector3(1, 2, 3);

        //First lesson property
        public float FloatProperty { get; private set; }

        // Start is called before the first frame update
        void Start()
        {
            ondalikSayi = 1000;
            FloatProperty = 1000000;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}