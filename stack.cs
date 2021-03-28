using System;

class MainClass {

  class Stack {
    public Stack (int size = 1000) {
      // Implement constructor
    }
    public bool isFull() {
      // Implment isFull
      return true;
    }

    public bool isEmpty() {
      // Implment isEmpty
      return true;
    }

    public void push (string item) {
      // Implement push()
      return;
    }

    public string pop () {
      // return pop()
      return "You have implemented pop() yet";
    }

    public  string peek () {
      return "A boo";
    }

    public void print () {
      Console.WriteLine ("print() not implemented yet");
    }

  }
  public static void Main (string[] args) {
    Console.WriteLine ("Hello to Stack World");

    Stack s = new Stack ();

    // Complete your testing here...


    s.push ("Hello World");
    Console.WriteLine ("pop (push (hello world)) gives: {0}", s.pop());
    s.print();


  }
}
