public class Node
{ 
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
     {
        this.Data = data;
    
     }
        // TODO Start Problem 1

        public void Insert(int value)
{
    if (value == Data)
    {
        return; // Ignore duplicate
    }

    if (value < Data)
    {
        if (Left == null)
            Left = new Node(value);
        else
            Left.Insert(value);
    }
    else
    {
        if (Right == null)
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
    else if (value < Data)
       {
        if (Left == null)
            return false;

        return Left.Contains(value);
        }
    else
        {
        if (Right == null)
            return false;

        return Right.Contains(value);
        }

    }

    // problem 3
 // Problem 3 helper: recursive reverse in-order
  public IEnumerable<int> TraverseBackward()
{
    if (Right != null)
    {
        foreach (var value in Right.TraverseBackward())
        {
            yield return value;
        }
    }

    yield return Data;

    if (Left != null)
    {
        foreach (var value in Left.TraverseBackward())
        {
            yield return value;
        }
    }
}

//Problem 4: 
public int GetHeight()
{
    int leftHeight = -1;
    int rightHeight = -1;

    if (Left != null)
    {
        leftHeight = Left.GetHeight();
    }

    if (Right != null)
    {
        rightHeight = Right.GetHeight();
    }

    return 1 + Math.Max(leftHeight, rightHeight);
}

public class BinarySearchTree
{
        
    
private Node? Root;

// Wrapper for Problem 1
public void Insert(int value)
{
    if (Root == null)
    {
        Root = new Node(value);
    }
    else
    {
        Root.Insert(value);
    }
}

// Wrapper for Problem 2
public bool Contains(int value)
{
    if (Root == null)
    {
        return false;
    }

    return Root.Contains(value);
}

// Problem 3 Wrapper
public IEnumerable<int> Reversed()
{
    if (Root == null)
    {
        return Enumerable.Empty<int>();
    }

    return Root.TraverseBackward();
}

// Problem 4 Wrapper
public int GetHeight()
{
    if (Root == null)
    {
        return -1;
    }

    return Root.GetHeight();
}


     // problem 5
       // Moved inside BinarySearchTree class + made it build a balanced tree
public static void InsertMiddle(
    BinarySearchTree tree,
    List<int> values,
    int first,
    int last)
{
    if (first > last)
    {
        return;
    }

    int middle = first + (last - first) / 2;

    tree.Insert(values[middle]);

    InsertMiddle(tree, values, first, middle - 1);

    InsertMiddle(tree, values, middle + 1, last);
}

class Program
   {
    static void Main()
      {
        BinarySearchTree tree = new BinarySearchTree();

        tree.Insert(50);
        tree.Insert(25);
        tree.Insert(75);
        tree.Insert(25); // Duplicate now ignored

        Console.WriteLine(tree.Contains(75)); // True
        Console.WriteLine(tree.Contains(100)); // False

        Console.WriteLine("Height: " + tree.GetHeight());

        Console.WriteLine("Descending: " + string.Join(", ", tree.Reversed()));
      }
   }  
}
 }