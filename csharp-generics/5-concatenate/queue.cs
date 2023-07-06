using System;


    class Queue<T>
    {
        public object CheckType(){
            return typeof(T);
        }
        class Node{
            public dynamic value = null;
            public Node next = null;
            public Node(dynamic val){
                value = val;
            }
        }
        Node head;
        Node tail;
        int count;
        public void Enqueue(dynamic value){
            Node king = new Node(value);
            if(count == 0){
                head = king;
                tail = king;
            }
            else{
                tail.next = king;
                tail = king;}
            count++;
            }
        public int Count(){
            return count;
        }
        public dynamic Dequeue(){
            if(count == 0)
            {
                System.Console.WriteLine("Queue is empty");
                return default(T);
            }
            count--;
            dynamic tempn = head.value;
            head = head.next;
            return tempn;
            
            }
        public dynamic Peek(){
            if(count == 0)
            {
                System.Console.WriteLine("Queue is empty");
                return default(T);
            }
            return head.value;
        }
        public void Print(){
            if(count == 0){
                System.Console.WriteLine("Queue is empty");
                return;
            }
            Node pn = head;
            while(pn != null){
                System.Console.WriteLine(pn.value);
                pn = pn.next;
            }
            
        }
        public string Concatenate(){
            if(count == 0){
                System.Console.WriteLine("Queue is empty");
                return null;
            }
            if((Type)this.CheckType() != typeof(string) && (Type)this.CheckType() != typeof(char)){
                System.Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
                return null;
            }
            Node pn = head;
            string temp = "";
            while(pn != null){
                temp += pn.value;
                pn = pn.next;
            }
            return temp;
        }
    }
    