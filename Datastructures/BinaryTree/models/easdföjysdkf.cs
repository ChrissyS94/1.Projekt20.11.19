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

        

       
        
    }
}
