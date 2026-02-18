public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        else
        {
            bool inRight = false;
            if (Right != null)
            {
                inRight = Right.Contains(value);
            }
            if (inRight)
            {
                return inRight;
            }
            else
            {
                if (Left != null)
                {
                    return Left.Contains(value);
                }
            }
        }
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left == null && Right == null)
        {
            return 1;
        }
        else
        {
            int countL = 1;
            int countR = 1;
            if (Left != null)
            {
                countL = countL + Left.GetHeight();
            }
            if (Right != null)
            {
                countR = countR + Right.GetHeight();
            }
            if (countL > countR)
            {
                return countL;
            }
            else
            {
                return countR;
            }
        }

        return 0; // Replace this line with the correct return statement(s)
    }
}