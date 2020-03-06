
// C# proram to evaluate value of a postfix expression 
using System; 
using System.Collections; 

namespace GFG 
{ 
	class Geek 
	{ 
		//Main() method 
		static void Main() 
		{ 
			Geek e = new Geek(); 
			e.v = ("231*+9-"); 
			e.expression(); 
			Console.WriteLine("postfix evaluation: " + e.answer); 
			Console.Read(); 
		} 

		public string v; 
		//'v' is variable to store the string value 

		public string answer; 
		Stack i = new Stack(); 
		//'Stack()' is inbuilt function for namespace 'System.Collections' 

		public void expression() 
		//evaluation method 
		{ 
			int a, b, ans; 
			for (int j = 0; j < v.Length; j++) 
			//'v.Length' means length of the string 
			{ 
				String c = v.Substring(j, 1); 
				if (c.Equals("*")) 
				{ 
					String sa = (String)i.Pop(); 
					String sb = (String)i.Pop(); 
					a = Convert.ToInt32(sb); 
					b = Convert.ToInt32(sa); 
					ans = a * b; 
					i.Push(ans.ToString()); 

				} 
				else if (c.Equals("/")) 
				{ 
					String sa = (String)i.Pop(); 
					String sb = (String)i.Pop(); 
					a = Convert.ToInt32(sb); 
					b = Convert.ToInt32(sa); 
					ans = a / b; 
					i.Push(ans.ToString()); 
				} 
				else if (c.Equals("+")) 
				{ 
					String sa = (String)i.Pop(); 
					String sb = (String)i.Pop(); 
					a = Convert.ToInt32(sb); 
					b = Convert.ToInt32(sa); 
					ans = a + b; 
					i.Push(ans.ToString()); 

				} 
				else if (c.Equals("-")) 
				{ 
					String sa = (String)i.Pop(); 
					String sb = (String)i.Pop(); 
					a = Convert.ToInt32(sb); 
					b = Convert.ToInt32(sa); 
					ans = a - b; 
					i.Push(ans.ToString()); 

				} 
				else
				{ 
					i.Push(v.Substring(j, 1)); 
				} 
			} 
			answer = (String)i.Pop(); 
		} 
	} 
} 
