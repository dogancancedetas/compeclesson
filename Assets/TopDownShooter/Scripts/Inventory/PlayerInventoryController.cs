using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private AbstractBasePlayerInventoryItemData[]_inventoryItemDataArray;
        private List<AbstractBasePlayerInventoryItemData> _createdItemDataList;
        public Transform parent;

        private void Start()
        {
            //FOR TESTIN PURPOSES ONLY
            InitializeInventory(_inventoryItemDataArray);
        }

        private void OnDestroy()
        {
            ClearInventory();
        }

        public void InitializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
        {
            ClearInventory();

            _createdItemDataList = new List<AbstractBasePlayerInventoryItemData>();
            for (int i = 0; i < inventoryItemDataArray.Length; i++)
            {
                var instantiated = Instantiate(inventoryItemDataArray[i]);
                instantiated.CreateIntoInventory(this);
            }
        }

        private void ClearInventory()
        {
            if (_createdItemDataList != null)
            {
                for (int i = 0; i < _createdItemDataList.Count; i++)
                {
                    _createdItemDataList[i].Destroy();
                }
            }
        }
    }
}
