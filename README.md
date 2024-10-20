# 🏰 SystemHelper 〜すべての間違いを征服せよ！〜

## 序章
> 勇敢なる冒険者よ！
> 
> この**SystemHelper**のコンソールでのやり取りを通じ、あらゆる間違いパターンを網羅し、君はエラーという名の怪物を打ち倒すことができるだろう。
> 
> このプログラムは、型ごとに異なる**TryParse**メソッドを駆使し、確実に正しい入力を得ることを使命としている。

## 目次
1. 🛠️ [インストール](#インストール)
2. 📜 [使用方法](#使用方法)
3. ✨ [特徴](#特徴)
4. 📚 [依存関係](#依存関係)
5. ⚙️ [設定](#設定)
6. 🔄 [トラブルシューティング](#トラブルシューティング)
7. 🤝 [貢献者](#貢献者)
8. 📜 [ライセンス](#ライセンス)

## 🛠️ インストール
まずは、このプログラムを手に入れるのだ！ソースコードをダウンロードし、以下の手順で進もう。

```bash
git clone https://your-repository-url.git
cd your-repository
```

## 📜 使用方法
> 「入力」という冒険の始まりだ！
>
> 次のようにConsoleHelperクラスのReadLineAsメソッドを呼び出すことで、任意の型の入力を安全に受け取ることができる。

```csharp
using SystemHelper;

class Program
{
    static void Main(string[] args)
    {
        int age = ConsoleHelper.ReadLineAs<int>("年齢を入力してください：");
        Console.WriteLine($"あなたの年齢は {age} 歳です！");
    }
}
ReadLineAs<T>は、ユーザーの入力が正しい形式になるまで、何度でも尋ね続けるだろう。入力が適切でない場合、もう一度挑戦するのだ！
```

# ✨ 特徴
- 多様な型対応：int、double、DateTimeなど、あらゆる型を征服しよう！
- 入力検証：入力が正しくない限り、絶対に先へ進めない。このチェックは厳格だが、君の味方だ！
- 拡張可能：新たな型を追加し、君の冒険に合わせて自由にカスタマイズ可能！

# 📚 依存関係
このプログラムは標準ライブラリのみを使用しているため、追加のライブラリは不要だ！
- .NET 6.0以上
  
# ⚙️ 設定
このプログラムに特別な設定は必要ないが、必要であればプログラムの中でメッセージや入力内容を変更して、自分だけの冒険をデザインできるぞ！

# 🔄 トラブルシューティング
道に迷った場合、以下を確認しよう。

1. `Type {T} does not have a TryParse method.`
-> おそらく対応していない型だ！TryParseメソッドを持つ型か確認しよう。

2. 入力がうまく処理されない
-> 型が正しいか、間違った入力が原因か確認し、再度挑戦せよ！

# 🤝 貢献者
開発者：airu3醤

# 📜 ライセンス
このプロジェクトはMITライセンスのもとに公開されている。詳細はLICENSEファイルを確認せよ。

---

エラーの世界を征服し、プログラムの正しさを守る勇敢な開発者として、君は「SystemHelper」とともにエラーの海を渡ることになるだろう！
