using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Binary_Search_Tree
{
    class Binary_Tree
    {
        Node root = null;

        public void Add(int value)
        {
            Node node = new Node();
            node.data = value;

            if (root == null)
            {
                root = node;
                return;
            }
            Node current = root;

            while (true)
            {
                if (value > current.data)
                {

                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                        break;

                    }
                    else
                    {
                        current = current.RightChild;
                    }
                }
                else
                {

                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                        break;
                    }
                    else
                    {
                        current = current.LeftChild;
                    }

                }
            }



        }

        public bool Search(int value)
        {
            Node Current = root;

            while (true)
            {
                if (Current.data == value)
                {
                    Console.WriteLine("found");
                    return true;
                }

                else if (Current.data < value)
                {
                    if (Current.RightChild == null)
                    {
                        return false;
                    }
                    else
                    { 
                        Current = Current.RightChild;

                    }
                   

                }
                  
                else if(Current.data > value)
                {
                    if (Current.LeftChild == null)
                    {
                        return false;
                    }
                    else
                    { 
                        Current = Current.LeftChild;

                    }
                   
                }
                
                
                
                
              
                
                
                
                
                
             






            }
        }
    
    } 
}
