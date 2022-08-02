using System;

namespace WS2
{
	static class Program
	{
		static void Main(string[] args)
		{
			MyStack s1 = new MyStack();
			MyStack s2 = new MyStack(5);

			s1.Push(1);
			s1.Push("hello");
			s1.Push(new Pet("red", "kliford", "dog"));
			s1.Push(new Person(2, "ronen", 24, new Pet("brown", "bobi", "baer")));

			s2.Push(3);
			s2.Push("bye");
			s2.Push(new Pet("blue", "mizi", "cat"));
			s2.Push(new Person(4, "albert", 26, new Pet("yellow", "simba", "lion")));

			Console.WriteLine(s1.Peek().ToString());
			Console.WriteLine(s2.Peek().ToString());

			s1.Pop();
			s1.Pop();
			s1.Pop();
			s1.Pop();

            Console.WriteLine("s1: " + (s1.IsEmpty() == true ? "empty" : "not empty"));

			s2.Pop();
			s2.Pop();
			s2.Pop();
			s2.Pop();

            Console.WriteLine("s2: " + (s2.IsEmpty() == true ? "empty" : "not empty"));

		}
		public static void TestPush(MyStack s1, MyStack s2)
        {
			s1.Push(1);
			s1.Push("hello");
			s1.Push(new Pet("red", "kliford", "dog"));
			s1.Push(new Person(2, "ronen", 24, new Pet("brown", "bobi", "baer")));

			s2.Push(3);
			s2.Push("bye");
			s2.Push(new Pet("blue", "mizi", "cat"));
			s2.Push(new Person(4, "albert", 26, new Pet("yellow", "simba", "lion")));
		}

	}

}
