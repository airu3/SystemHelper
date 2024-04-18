// 人のあらゆる間違いパターンを網羅するようにプログラムを作成すること
using System;

namespace SystemHelper
{
	public static class ConsoleHelper
	{
		public static T ReadLineAs<T>(string message)
		{
			var tryParseMethod = typeof(T).GetMethod("TryParse", [typeof(string), typeof(T).MakeByRefType()])
			?? throw new NotSupportedException($"Type {typeof(T)} does not have a TryParse method.");


			T result = default!;
			string input;

			do
			{
				Console.Write(message);
				input = Console.ReadLine()!;
			}
			while (!(bool)tryParseMethod.Invoke(null, [input, result])!);

			return result;
		}
	}
}