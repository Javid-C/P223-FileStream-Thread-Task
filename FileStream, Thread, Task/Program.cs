using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileStream__Thread__Task
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Classwork
			//try
			//{
			//	User user = new User("javidgmail.com", "1234567");
			//}
			//catch (Exception e)
			//{

			//	Console.WriteLine(e.Message);
			//}
			#endregion

			#region File Stream
			//using (FileStream fileStream = new FileStream(@"C:\Users\nijat\OneDrive\Рабочий стол\P223\p223.txt", FileMode.Append, FileAccess.Write))
			//{
			//	string text = "this is append message";

			//	byte[] byteArr = Encoding.UTF8.GetBytes(text);

			//	fileStream.Write(byteArr);

			//}
			#region Stream Writer
			//StreamWriter streamWriter = new StreamWriter(fileStream);

			//streamWriter.WriteLine("This is custom text");
			//streamWriter.WriteLine("This is custom text 2");

			//streamWriter.Close();
			#endregion



			//foreach (var item in byteArr)
			//{
			//	Console.WriteLine(item);
			//}

			//fileStream.Write(byteArr);
			//int size = fileStream.Read(byteArr);


			//Console.WriteLine(size);
			//fileStream.Close();
			#endregion




			//Thread thread = new Thread(Write0);

			//thread.IsBackground = true; //Foreground

			//Thread thread1 = new Thread(Write1);

			//thread.Start();
			//thread1.Start();


			//Task task = Task.Run(() =>
			//{
			//	Console.WriteLine("task");
			//});

			//var task = GetSource().ContinueWith(t=> {

			//	Console.WriteLine(t.Result);
			//});

			ShowSource();

			//while (!task.IsCompleted)
			//{
			//	Console.WriteLine("loading...");
			//}

			Console.WriteLine("this text written after task");



			Console.ReadLine();



		}

		public static async Task ShowSource()
		{
			HttpClient httpClient = new HttpClient();

			var task = await httpClient.GetStringAsync("https://www.google.com");

			Console.WriteLine(task);
		}

		public static Task<string> GetSource()
		{
			HttpClient httpClient = new HttpClient();

			var task = Task.Run(() =>
			{
				return httpClient.GetStringAsync("https://www.google.com").Result;
			});
			return task;
		}

		public static void Write0()
		{
			for (int i = 0; i < 10000; i++)
			{
				Thread.Sleep(50);
				Console.Write(0);
			}
		}
		public static void Write1()
		{
			for (int i = 0; i < 10000; i++)
			{
				Thread.Sleep(50);
				Console.Write(1);
			}
		}
	}
}
