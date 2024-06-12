namespace XTreeFour
{
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public int Height;

        public TreeNode(int value)
        {
            Value = value;
        }

        public void Insert(int value)
        {
            if (value < Value)
            {
                if (Left is null)
                {
                    Left = new TreeNode(value);
                }
                else
                {
                    Left.Insert(value);
                }
            }
            else
            {
                if (Right is null)
                {
                    Right = new TreeNode(value);
                }
                else
                {
                    Right.Insert(value);
                }
            }

            UpdateHeight();
            Balance();
        }

        public void UpdateHeight()
        {
            Height = Math.Max(Left?.Height ?? -1, Right?.Height ?? -1) + 1;
        }

        private static void Swap(TreeNode a, TreeNode b)
        {
            int temp = a.Value;
            a.Value = b.Value;
            b.Value = temp;
        }

        private void RotateRight()
        {
            if (Left is null)
            {
                throw new InvalidOperationException();
            }

            Swap(this, Left);
            var oldRight = Right;
            Right = Left;
            Left = Right.Left;
            Right.Left = Right.Right;
            Right.Right = oldRight;
            Right.UpdateHeight();
            UpdateHeight();
        }

        private void RotateLeft()
        {
            if (Right is null)
            {
                throw new InvalidOperationException();
            }

            Swap(this, Right);
            var oldLeft = Left;
            Left = Right;
            Right = Left.Right;
            Left.Right = Left.Left;
            Left.Left = oldLeft;
            Left.UpdateHeight();
            UpdateHeight();
        }

        public int GetOverload()
        {
            return (Right?.Height ?? -1) - (Left?.Height ?? -1);
        }

        private void Balance()
        {
            var overload = GetOverload();

            if (overload == -2)
            {
                if (Left?.GetOverload() == 1)
                {
                    Left.RotateLeft();
                }

                RotateRight();
            }
            else if (overload == 2)
            {
                if (Right?.GetOverload() == -1)
                {
                    Right.RotateRight();
                }

                RotateLeft();
            }
        }

        /// <summary>
        /// Remove value from node.
        /// </summary>
        /// <param name="value">int</param>
        /// <returns>node</returns>
        public TreeNode Remove(int value)
        {
            TreeNode node;
            var comparison = value.CompareTo(Value);
            if (comparison < 0)
            {
                node = this;
                if (Left != null)
                {
                    Left = Left.Remove(value);
                }
            }
            else if (comparison > 0)
            {
                node = this;
                if (Right != null)
                {
                    Right = Right.Remove(value);
                }
            }
            else if (Left is null || Right is null)
            {
                if (Left is null)
                {
                    node = Right;
                }
                else
                {
                    node = Left;
                }
            }
            else
            {
                var leftMax = Left.Max();
                Left = Left.Remove(leftMax.Value);
                Value = leftMax.Value;
                node = this;
            }

            if (node != null)
            {
                node.UpdateHeight();
                node.Balance();
            }
            return node;
        }


        public TreeNode Min()
        {
            if (Left is null)
            {
                return this;
            }
            else
            {
                return Left.Min();
            }
        }

        public TreeNode Max()
        {
            if (Right is null)
            {
                return this;
            }
            else
            {
                return Right.Max();
            }
        }

        public TreeNode Find(int value)
        {
            var comparison = value.CompareTo(Value);
            if (comparison == 0)
            {
                return this;
            }
            else if (comparison < 0)
            {
                if (Left is null)
                {
                    return null;
                }
                else
                {
                    return Left.Find(value);
                }
            }
            else
            {
                if (Right is null)
                {
                    return null;
                }
                else
                {
                    return Right.Find(value);
                }
            }
        }

        public void AddTo(ICollection<int> list)
        {
            Left?.AddTo(list);
            list.Add(Value);
            Right?.AddTo(list);
        }

    }
}
