// 人のあらゆる間違いパターンを網羅するようにプログラムを作成すること
using System;

namespace SystemHelper
{
	public static class ConsoleHelper
	{
		public static T ReadLineAs<T>(string message)
		{
			var tryParseMethod = typeof(T).GetMethod("TryParse", new[] { typeof(string), typeof(T).MakeByRefType() });

			if (tryParseMethod == null)
			{
				throw new NotSupportedException($"Type {typeof(T)} does not have a TryParse method.");
			}

			T result = default;
			string input;

			do
			{
				Console.Write(message);
				input = Console.ReadLine() ?? string.Empty;
			}
			while (!(bool)tryParseMethod.Invoke(null, new object[] { input, result }));

			return result;
		}
	}
}