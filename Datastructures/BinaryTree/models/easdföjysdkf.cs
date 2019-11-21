using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree.models
{
    class easdföjysdkf
    {
        private BinaryTreeItem _root;
        private int _count;

        public BinaryTree()
        {
            this._root = null;
        }
        public BinaryTree(int? item)
        {
            this._root = new BinaryTreeItem(item, 0, null, null);
        }
        public BinaryTree(BinaryTree list)
        {
            this._root = list._root;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Add(int? itemToAdd, BinaryTreeItem actItem = null)
        {
            BinaryTreeItem newItem = new BinaryTreeItem(itemToAdd, 1, null, null);

            if (itemToAdd == null)
            {
                return;
            }
            if (_root == null)
            {
                _root = newItem;
            }
            if (actItem == null)
            {
                actItem = _root;
            }

            if (actItem.Item == itemToAdd)
            {
                _count++;
            }
            else if (actItem.Item < itemToAdd)
            {
                if (actItem.ItemRight != null)
                {
                    actItem = actItem.ItemRight;
                    Add(itemToAdd, actItem);

                }
                else
                {
                    actItem.ItemRight = newItem;
                }

            }
            else
            {
                if (actItem.ItemLeft != null)
                {
                    actItem = actItem.ItemLeft;
                    Add(itemToAdd, actItem);
                }
                else
                {
                    actItem.ItemLeft = newItem;
                }
            }
        }
    }
}
