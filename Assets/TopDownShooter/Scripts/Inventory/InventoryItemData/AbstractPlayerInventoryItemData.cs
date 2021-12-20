using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    public enum InventoryItemDataType { Cannon, Body }
    public abstract class AbstractPlayerInventoryItemData<T> : AbstractBasePlayerInventoryItemData where T: AbstractPlayerInventoryItemMono
    {
        [SerializeField] protected string _itemID;
        [SerializeField] protected InventoryItemDataType _InventoryItemDataType;
        [SerializeField] protected T _prefab;

        protected T InstantiateAndInitializePrefab(Transform parent)
        {
            return Instantiate(_prefab, parent);
        }
    }
}
