using UnityEngine;
using DataStarter;

namespace DataStarter
{
    // This script is a simple example of how an interactive item can
    // be used to change things on gameobjects by handling events.
    public class ExampleInteractiveItem : MonoBehaviour
    {
        [SerializeField] private Material m_NormalMaterial;                
        [SerializeField] private Material m_OverMaterial;                  
        [SerializeField] private Material m_ClickedMaterial;               
        [SerializeField] private Material m_DoubleClickedMaterial;         
        [SerializeField] private VRInteractiveItem m_InteractiveItem;
        [SerializeField] private Renderer m_Renderer;

        public Canvas upperCanvas;
        public Canvas midCanvas;
        public Canvas lowerCanvas;

        private void Awake ()
        {
            m_Renderer.material = m_NormalMaterial;
        }


        private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
            m_InteractiveItem.OnClick += HandleClick;
            m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
        }


        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
            m_InteractiveItem.OnClick -= HandleClick;
            m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
        }


        //Handle the Over event
        private void HandleOver()
        {
            Debug.Log("Show over state");//this changes the color of material on the next line.
            m_Renderer.material = m_OverMaterial;
        }


        //Handle the Out event
        private void HandleOut()
        {
            Debug.Log("Show out state");
            m_Renderer.material = m_NormalMaterial;
        }


        //Handle the Click event
        private void HandleClick()
        {
            string tag = gameObject.tag;
            Debug.Log("Show click state: " + tag);
            m_Renderer.material = m_ClickedMaterial;
            if (midCanvas.GetComponent<ChemicalGraph>().generated == false)
            {
                midCanvas.transform.position = transform.position;
                midCanvas.GetComponent<ChemicalGraph>().genGraph(tag);
            }
            else if (upperCanvas.GetComponent<ChemicalGraph>().generated == false && !tag.Equals(midCanvas.GetComponent<ChemicalGraph>().stateTitle.text))
            {
                upperCanvas.transform.position = transform.position;
                upperCanvas.GetComponent<ChemicalGraph>().genGraph(tag);
            }
            else if (lowerCanvas.GetComponent<ChemicalGraph>().generated == false && !tag.Equals(midCanvas.GetComponent<ChemicalGraph>().stateTitle.text) && !tag.Equals(upperCanvas.GetComponent<ChemicalGraph>().stateTitle.text))
            {
                lowerCanvas.transform.position = transform.position;
                lowerCanvas.GetComponent<ChemicalGraph>().genGraph(tag);
            }
            else
            {
                Debug.Log("No open graphs to draw to!");
            }
        }


        //Handle the DoubleClick event
        private void HandleDoubleClick()
        {
            Debug.Log("Show double click");
            m_Renderer.material = m_DoubleClickedMaterial;
        }
    }

}