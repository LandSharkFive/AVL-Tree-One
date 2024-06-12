namespace XTreeFour
{

    // AVL Tree.  The tree is Height Balanced from leaf to root at each level.
    public class Tree
    {
        public TreeNode Root;

        public Tree()
        {
            Root = null;
        }

        public bool Contains(int value)
        {
            if (Root is null)
            {
                return false;
            }

            return Root.Find(value) is not null;
        }

        public void Add(int value)
        {
            if (Root is null)
            {
                Root = new TreeNode(value);
            }
            else
            {
                Root.Insert(value);
            }
        }

        public void AddRange(List<int> list)
        {
            foreach (int x in list) 
            {
                Add(x);
            }
        }

        public bool IsEmpty()
        {
            return Root is null;
        }

        public int Min()
        {
            if (Root is null)
            {
                return 0;
            }

            return Root.Min().Value;
        }

        public int Max()
        {
            if (Root is null)
            {
                return 0;
            }

            return Root.Max().Value;
        }
        public void Remove(int value)
        {
            if (Root is null)
            {
                return;
            }

            Root = Root.Remove(value);
        }

        public void RemoveRange(List<int> list)
        {
            foreach (int x in list)
            {
                Remove(x);
            }
        }

        public List<int> ToList()
        {
            if (Root is null)
            {
                return new List<int>();
            }
            else
            {
                List<int> list = new List<int>();
                Root.AddTo(list);
                return list;
            }
        }

        public int Height()
        {
            if (Root is null)
            {
                return 0;
            }

            return Root.Height;
        }

        public int GetOverload()
        {
            if (Root is null)
            {
                return 0;
            }

            return Root.GetOverload();
        }

        public void Rebuild(Tree a)
        {
            if (a.Root == null)
            {
                return;
            }

            var b = a.ToList().OrderBy(x => x).ToList();
            a.Root = BuildTree(b, 0, b.Count - 1);
            a.SetHeight();
        }


        /// <summary>
        /// Build Tree
        /// </summary>
        /// <param name="">sorted array</param>
        /// <param name="">start index, 0</param>
        /// <param name="">end index, n-1</param>
        public TreeNode BuildTree(List<int> array, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int mid = (start + end) / 2;
            TreeNode a = new TreeNode(array[mid]);
            a.Left = BuildTree(array, start, mid - 1);
            a.Right = BuildTree(array, mid + 1, end);
            return a;
        }

        public void Clear()
        {
            Clear(Root);
            Root = null;
        }

        public void Clear(TreeNode r)
        {
            if (r != null)
            {
                Clear(r.Left);
                Clear(r.Right);
                r.Left = null;
                r.Right = null;
            }
        }

        public int Count()
        {
            return Count(Root);
        }

        public int Count(TreeNode r)
        {
            if (r == null)
            {
                return 0;
            }
            else
            {
                return Count(r.Left) + Count(r.Right) + 1;
            }
        }

        public void SetHeight()
        {
            SetHeight(Root);
        }

        public void SetHeight(TreeNode r)
        {
            if (r != null)
            {
                SetHeight(r.Left);
                SetHeight(r.Right);
                r.UpdateHeight();
            }
        }


    }
}
