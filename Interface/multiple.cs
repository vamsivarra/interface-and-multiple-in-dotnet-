using System;
namespace interfaceexample
{
	public interface Idrawable
	{
		void test();
		int test1();
	}
	public interface Idrawable1
	{
		void test2();
		int test3();
	}
	public class Multipleinheritance : Idrawable, Idrawable1
	{
		public void test()
		{
			Console.WriteLine("i am a test method");
		}
		public int test1()
		{
			int i = 10;
			Console.WriteLine("i a test 1 method",+i);
			return i;
		}
		public void test2()
		{
			Console.WriteLine("i am a test 2 method");
		}
		public int test3()
		{
			int i = 10;
			Console.WriteLine("i a test 3 method", +i);
			return i;
		}
		public static void Main(string[] args)
		{
			Multipleinheritance m1 = new Multipleinheritance();
			m1.test();
			m1.test1();
			m1.test2();
			m1.test3();
		}
	}
}

