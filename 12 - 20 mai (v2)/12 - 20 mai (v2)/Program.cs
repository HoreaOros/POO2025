using BST;
BSTree T = new BSTree();
List<Node> lst = new List<Node>
{
                new Node{ Key = 5  },
                new Node{ Key = 3  },
                new Node{ Key = 10  },
                new Node{ Key = 4  },
                new Node{ Key = 1  },
                new Node{ Key = 15  },
                new Node{ Key = 7  }
            };
foreach (Node node in lst)
{
    T.Insert(node);
}
T.InorderTreeWalk();