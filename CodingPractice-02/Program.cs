using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.
{
    string name = null;
    name ??= "이름 없음";
    name ??= "새 이름";

    string playerName = null;
    if (playerName == null)
    {
        playerName = "플레이어";
    }
    Console.WriteLine(playerName);

    List<string> _itmes = null;
    _itmes ??= new List<string>();
    _itmes.Add("검");
    _itmes ??= new List<string>();
    _itmes.Add("방패");
    Console.WriteLine($"아이템 수: {_itmes.Count}");
    foreach (string item in _itmes)
    {
        Console.WriteLine($"- {item}");
    }

    string message = null;
    int? length = message?.Length;
    Console.WriteLine($"길이: {length}");
    message = "안녕하세요";
    length = message?.Length;
    Console.WriteLine($"길이: {length}");

    string text = null;
    if (text?.Length == null)
    {
        Console.WriteLine("텍스트가 없습니다.");
    }
}

{
    string name = null;
    Console.WriteLine($"대문자: {name?.ToUpper()}");
    name = "hello";
    Console.WriteLine($"대문자: {name?.ToUpper()}");

    string text = null;
    Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");
    text = "  hello  ";
    Console.WriteLine($"결과: {text?.ToUpper()?.Trim()}");

    List<string> items = null;
    int? count = items?.Count;
    Console.WriteLine($"아이템 수: {count}");
    items = new List<string>() { "사과", "바나나" };
    count = items?.Count;
    Console.WriteLine($"아이템 수: {count}");
}

{
    string text = null;
    char? first = text?[0];
    Console.WriteLine($"첫 글자: {first}");
    text = "Hello";
    first = text?[0];
    Console.WriteLine($"첫 글자: {first}");

    string message = null;
    int length = message?.Length ?? 0;
    Console.WriteLine($"길이: {length}");
    message = "Hello";
    length = message?.Length ?? 0;
    Console.WriteLine($"길이: {length}");

    List<string> names = null;
    Console.WriteLine($"이름 수: {names?.Count ?? 0}");
    names = new List<string>() { "Kim", "Lee", "Park" };
    Console.WriteLine($"이름 수: {names?.Count ?? 0}");

    string playerName = null;
    int? playerLevel = null;
    List<string> inventory = null;

    string displayName = playerName ?? "Unknown";
    int level = playerLevel ?? 1;
    int itemCount = inventory?.Count ?? 0;

    Console.WriteLine($"플레이어: {displayName}");
    Console.WriteLine($"레벨: {level}");
    Console.WriteLine($"인벤토리 아이템: {itemCount}");
}